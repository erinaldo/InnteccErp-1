﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ActionService;
using BusinessObjects;
using BusinessObjects.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Utilities;

namespace WinFormsApp
{
    public partial class EntradaalmacenImpNotaCreditoClienteFrm : XtraForm
    {
        public int IdEntidadMnt { get; set; }
        public TipoMantenimiento TipoMnt { get; set; }

        static readonly IService Service = new Service();

        private List<VwNotacreditocli> _vwNotacreditocliList;
        private List<VwNotacreditocliimpentradaalmacen> VwNotacreditocliimpentradaalmacenList { get; set; }        
        private List<VwAlmacen> VwAlmacenList { get; set; }
        public Tipodocmov TipodocmovSel { get; set; }
        public Almacen AlmacenSel { get; set; }
        public List<VwTipocp> VwTipocpList { get; set; }
        public EntradaalmacenMntFrm EntradaalmacenMntFrm { get; set; }
        public VwSocionegocio VwSocionegocioSel { get; set; }
        public EntradaalmacenImpNotaCreditoClienteFrm(Tipodocmov tipodocmov, VwSocionegocio vwSocionegocioSel, Almacen almacenSel, EntradaalmacenMntFrm entradaalmacenMntFrm)
        {
            InitializeComponent();
            var styleController = new StyleController();
            WinFormUtils.SetStyleController(this, styleController);
            TipodocmovSel = tipodocmov;
            VwSocionegocioSel = vwSocionegocioSel;
            AlmacenSel = almacenSel;
            EntradaalmacenMntFrm = entradaalmacenMntFrm;
        }
        private void EntradaalmacenImpNotaCreditoClienteFrm_Load(object sender, EventArgs e)
        {
            CargarReferencias();
            iIdalmacen.EditValue = AlmacenSel.Idalmacen;
            cboBuscarPor.SelectedIndex = 0; //Todos
            iNroDocumento.EditValue = VwSocionegocioSel.Nrodocentidadprincipal;
            iRazonSocial.EditValue = VwSocionegocioSel.Razonsocial;

        }
        private void CargarReferencias()
        {
            VwAlmacenList = Service.GetAllVwAlmacen("Nombrealmacen");
            iIdalmacen.Properties.DataSource = VwAlmacenList;
            iIdalmacen.Properties.DisplayMember = "Nombrealmacen";
            iIdalmacen.Properties.ValueMember = "Idalmacen";
            iIdalmacen.Properties.BestFitMode = BestFitMode.BestFit;


            string whereTipoCp = string.Format("nombretipodocmov = '{0}' and idsucursal = '{1}'", "NC-CLIENTE", SessionApp.SucursalSel.Idsucursal);
            VwTipocpList = Service.GetAllVwTipocp(whereTipoCp, "nombretipocp");
            iIdtipocp.Properties.DataSource = VwTipocpList;
            iIdtipocp.Properties.DisplayMember = "Nombretipocp";
            iIdtipocp.Properties.ValueMember = "Idtipocp";
            iIdtipocp.Properties.BestFitMode = BestFitMode.BestFit;
        }
        private void CargarDocumentosPendientes()
        {
            gcConsulta.DataSource = null;
            gcDetalleImp.DataSource = null;

            Cursor = Cursors.WaitCursor;
            string whereNumeroNcCliente = string.Empty;

            const string whereNoPendientes = @" and idnotacreditocli 
                                               in (select a.idnotacreditocli
                                               from almacen.vwnotacreditocliimpentradaalmacen a 
                                               where a.anulado = '0' and a.saldoaimportar > 0)";

            string whereSocioNegocio = string.Format(" and idcliente = {0}", VwSocionegocioSel.Idsocionegocio);

            //string whereAlmacen =  string.Format(" and almacenorigen = {0}",AlmacenSel.Idalmacen);
            string whereAlmacen = string.Empty;

            switch (cboBuscarPor.SelectedIndex)
            {
                case 0://Todos
                    whereNumeroNcCliente = string.Format("anulado = '0' {0} {1} {2}", whereAlmacen, whereSocioNegocio, whereNoPendientes);
                    break;
                case 1: //Nota de credito

                    whereNumeroNcCliente = string.Format(@"idtipocp = {0} and serienotacredito = '{1}'
                        and numeronotacredito = '{2}' and anulado = '0' {3} {4} {5}",
                        (int)iIdtipocp.EditValue,
                        rSerieDoc.Text.Trim(),
                        iNumeroDoc.Text.Trim(),
                        whereAlmacen,
                        whereSocioNegocio,
                        whereNoPendientes);

                    break;
            }


            _vwNotacreditocliList = Service.GetAllVwNotacreditocli(whereNumeroNcCliente, "nombretipoformato,serienotacredito,numeronotacredito");


            gcConsulta.BeginUpdate();
            gcConsulta.DataSource = _vwNotacreditocliList;
            gcConsulta.EndUpdate();
            gvConsulta.BestFitColumns();

            Cursor = Cursors.Default;
        }
        private void CargarInfoCorrelativo()
        {
            var idTipocp = iIdtipocp.EditValue;
            if (idTipocp != null)
            {
                VwTipocp vwTipocp = Service.GetVwTipocp((int)idTipocp);
                rSerieDoc.EditValue = vwTipocp.Seriecp;
                rSerieDoc.Properties.ReadOnly = true;
                iNumeroDoc.Focus();
            }
            else
            {
                rSerieDoc.EditValue = @"0000";
                iNumeroDoc.EditValue = 0;
            }
        }
        public void CargarDetalle()
        {
            VwNotacreditocli vwNotacreditocli = (VwNotacreditocli)gvConsulta.GetFocusedRow();

            if (vwNotacreditocli != null)
            {
                Cursor = Cursors.WaitCursor;
                string where = string.Format("idnotacreditocli = {0} and saldoaimportar > 0", vwNotacreditocli.Idnotacreditocli);
                VwNotacreditocliimpentradaalmacenList = Service.GetAllVwNotacreditocliimpentradaalmacen(where, "numeroitem");

                gcDetalleImp.BeginUpdate();
                gcDetalleImp.DataSource = VwNotacreditocliimpentradaalmacenList;
                gcDetalleImp.EndUpdate();

                gvDetalleImp.BestFitColumns();
                Cursor = Cursors.Default;

            }
        }
        private Entradaalmacendet AsignarEntradaAlmacenDetalle(VwNotacreditocliimpentradaalmacen vwNotacreditocliimpentradaalmacen)
        {
            Entradaalmacendet entradaalmacendetMnt = new Entradaalmacendet
            {
                Identradaalmacen = EntradaalmacenMntFrm.IdEntidadMnt,
                Numeroitem = vwNotacreditocliimpentradaalmacen.Numeroitem,
                Idarticulo = vwNotacreditocliimpentradaalmacen.Idarticulo,
                Idimpuesto = vwNotacreditocliimpentradaalmacen.Idimpuesto,
                Idunidadmedida = vwNotacreditocliimpentradaalmacen.Idunidadmedida,
                Especificacion = vwNotacreditocliimpentradaalmacen.Especificacion,
                Cantidad = vwNotacreditocliimpentradaalmacen.Cantidadaimportar,
                Preciounitario = vwNotacreditocliimpentradaalmacen.Preciounitario,
                Importetotal = Math.Round(vwNotacreditocliimpentradaalmacen.Cantidadaimportar * vwNotacreditocliimpentradaalmacen.Preciounitario,2),
                Idproyecto = vwNotacreditocliimpentradaalmacen.Idproyecto,
                Idarea = vwNotacreditocliimpentradaalmacen.Idarea,
                Idcentrodecosto = vwNotacreditocliimpentradaalmacen.Idcentrodecosto,
                Porcentajepercepcion = vwNotacreditocliimpentradaalmacen.Porcentajepercepcion,
                Idtipoafectacionigv = vwNotacreditocliimpentradaalmacen.Idtipoafectacionigv,
                Idnotacreditoclidet = vwNotacreditocliimpentradaalmacen.Idnotacreditoclidet,
                Calcularitem = vwNotacreditocliimpentradaalmacen.Calcularitem
            };
            return entradaalmacendetMnt;
        }      
        private void bmMntItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            var subMenu = e.Item as BarSubItem;
            if (subMenu != null) return;

            
            switch (e.Item.Name)
            {
                case "btnImportar":

                    if (!Validaciones()) return;

                    if (EntradaalmacenMntFrm.IdEntidadMnt == 0)
                    {
                        if (!EntradaalmacenMntFrm.Validaciones()) return;

                        string numeroDoc = string.Format("{0} {1}-{2}", EntradaalmacenMntFrm.iIdtipocp.Text.Trim(), EntradaalmacenMntFrm.rSerieentradaalmacen.Text.Trim(), EntradaalmacenMntFrm.rNumeroentradaalmacen.Text.Trim());
                        if (DialogResult.No == XtraMessageBox.Show(string.Format("¿Desea guardar el documento {0}?", numeroDoc),
                            "Atención", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                        {
                            return;
                        }


                        VwNotacreditocli vwNotacreditocli = (VwNotacreditocli)gvConsulta.GetFocusedRow();

                        //Asignar los controles de entrada a almacen desde la orden de compra seleccionada
                        EntradaalmacenMntFrm.iIdtipomoneda.EditValue = vwNotacreditocli.Idtipomoneda;
                        EntradaalmacenMntFrm.iIdtipomoneda.ReadOnly = true;
                        EntradaalmacenMntFrm.iIncluyeimpuestoitems.EditValue = vwNotacreditocli.Incluyeimpuestoitems;
                        EntradaalmacenMntFrm.EntradaalmacenMnt.Incluyeimpuestoitems = vwNotacreditocli.Incluyeimpuestoitems;
                        EntradaalmacenMntFrm.EntradaalmacenMnt.Tipocambio = vwNotacreditocli.Tipocambio;


                        //Asignar la propiedad del documento de referencia
                        EntradaalmacenMntFrm.EntradaalmacenMnt.Idnotacreditocli = vwNotacreditocli.Idnotacreditocli;

                        if (EntradaalmacenMntFrm.Guardar())
                        {
                            EntradaalmacenMntFrm.DeshabilitarModificacion();
                        }

                    }

                    if (EntradaalmacenMntFrm.IdEntidadMnt > 0)
                    {
                        foreach (var item in VwNotacreditocliimpentradaalmacenList.Where(x => x.Itemseleccionado))
                        {
                            Entradaalmacendet entradaalmacendetMnt = AsignarEntradaAlmacenDetalle(item);

                            int identradaalmacendet = Service.SaveEntradaalmacendet(entradaalmacendetMnt);
                            if (identradaalmacendet > 0)
                            {
                                //Verificar las ubicacion registradas por articulo
                                long cantidadRefUbicaciones = Service.CountVwArticuloubicacion(
                                    x => x.Idarticulo == entradaalmacendetMnt.Idarticulo
                                    && x.Idalmacen == (int)iIdalmacen.EditValue);

                                if (cantidadRefUbicaciones == 0)
                                {
                                    //Insertar ubicacion por defecto
                                    Entradaalmacenubicacion entradaalmacenubicacion = new Entradaalmacenubicacion
                                    {
                                        Identradaalmacendet = identradaalmacendet,
                                        Idubicacion = AlmacenSel.Idubicaciondefecto,
                                        Cantidadarticulo = entradaalmacendetMnt.Cantidad
                                    };
                                    Service.SaveEntradaalmacenubicacion(entradaalmacenubicacion);
                                }
                                else
                                {
                                    //Insertar la ubicaciones del articulo del almacen seleccionado
                                    List<VwArticuloubicacion> vwArticuloubicacionList = Service.GetAllVwArticuloubicacion(
                                        x => x.Idarticulo == entradaalmacendetMnt.Idarticulo
                                        && x.Idalmacen == (int)iIdalmacen.EditValue);

                                    foreach (var vwArticuloubicacion in vwArticuloubicacionList)
                                    {
                                        Entradaalmacenubicacion entradaalmacenubicacion = new Entradaalmacenubicacion
                                        {
                                            Identradaalmacendet = identradaalmacendet,
                                            Idubicacion = vwArticuloubicacion.Idubicacion,
                                            Cantidadarticulo = 0m
                                        };
                                        Service.SaveEntradaalmacenubicacion(entradaalmacenubicacion);
                                    }
                                }
                            }
                        }

                        EntradaalmacenMntFrm.CargarDetalle();
                        EntradaalmacenMntFrm.CargarDocumentoReferencia();
                    }

                    DialogResult = DialogResult.OK;                    
                    break;
                case "btnCancelarItem":
                    DialogResult = DialogResult.Cancel;
                    break;
                case "btnConsultar":
                    if (!ValidacionDatosConsulta()) return;
                    CargarDocumentosPendientes();


                    break;
                case "btnCerrar":
                    DialogResult = DialogResult.Cancel;
                    break;

            }
        }
        private bool ValidacionDatosConsulta()
        {
            switch (cboBuscarPor.SelectedIndex)
            {
                case 0://Todos
                    return true;
                case 1: //Requerimiento
                    var idTipoCel = iIdtipocp.EditValue;

                    if (idTipoCel == null)
                    {
                        XtraMessageBox.Show("Seleccion el tipo de documento.", "Atención", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        iIdtipocp.Focus();
                        return false;
                    }

                    if (string.IsNullOrEmpty(iNumeroDoc.Text))
                    {
                        XtraMessageBox.Show("Ingrese el numero de requerimiento.", "Atención", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        iNumeroDoc.Focus();
                        return false;
                    }
                    break;
            }

            return true;
        }
        private bool Validaciones()
        {
            if (gvConsulta.RowCount == 0 || gvDetalleImp.RowCount == 0)
            {
                XtraMessageBox.Show("No hay información de ordenes de compra, verifique", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            int cantidadItemsSeleccionados = VwNotacreditocliimpentradaalmacenList.Count(x => x.Itemseleccionado);
            if (cantidadItemsSeleccionados == 0)
            {
                XtraMessageBox.Show("Debe seleccionar los items a importar", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void EntradaalmacenImpNotaCreditoClienteFrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void gvDetalleImp_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            VwNotacreditocliimpentradaalmacen itemSel = (VwNotacreditocliimpentradaalmacen)gvDetalleImp.GetFocusedRow();

            string nameColumn = e.Column.FieldName;
            switch (nameColumn)
            {
                case "Cantidadaimportar":
                    if (itemSel.Cantidadaimportar > itemSel.Saldoaimportar)
                    {
                        XtraMessageBox.Show("Cantidad a importar no es valida", "Atención", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        itemSel.Cantidadaimportar = 0m;
                        itemSel.Itemseleccionado = false;
                    }
                    else
                    {
                        itemSel.Itemseleccionado = itemSel.Cantidadaimportar > 0;
                    }
                    gvDetalleImp.RefreshData();
                    break;
                case "Itemseleccionado":

                    if (itemSel.Saldoaimportar == 0)
                    {
                        itemSel.Cantidadaimportar = 0m;
                        itemSel.Itemseleccionado = false;
                    }
                    else
                    {
                        itemSel.Cantidadaimportar = itemSel.Itemseleccionado ? itemSel.Saldoaimportar : 0;
                    }
                    gvDetalleImp.RefreshData();
                    break;
            }
        }
        private void riItemseleccionado_EditValueChanged(object sender, EventArgs e)
        {
            //Para que actualize datos cuando se hace check en checkedit de la columan
            gvDetalleImp.PostEditor();

        }
        private void gvConsulta_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            CargarDetalle();
        }        
        private void cboBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            iIdtipocp.Enabled = false;
            rSerieDoc.Enabled = false;
            iNumeroDoc.Enabled = false;

            switch (cboBuscarPor.SelectedIndex)
            {
                case 0: //Todos
                    break;
                case 1: //N° Requerimiento de compra
                    iIdtipocp.Enabled = true;
                    rSerieDoc.Enabled = true;
                    iNumeroDoc.Enabled = true;
                    iIdtipocp.Focus();
                    break;
            }
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in VwNotacreditocliimpentradaalmacenList)
            {
                item.Itemseleccionado = (item.Saldoaimportar > 0 && chkSeleccionarTodo.Checked);
                item.Cantidadaimportar = item.Saldoaimportar > 0 && chkSeleccionarTodo.Checked ? item.Saldoaimportar : 0;

            }
            gvDetalleImp.RefreshData();
        }
        private void iIdtipocp_EditValueChanged(object sender, EventArgs e)
        {
            CargarInfoCorrelativo();
        }
    }
}