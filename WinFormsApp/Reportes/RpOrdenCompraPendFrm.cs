﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ActionService;
using BusinessObjects.Entities;
using DbNetLink.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FastReport;
using Utilities;

namespace WinFormsApp
{
    public partial class RpOrdenCompraPendFrm : XtraForm
    {
        public VwArticulo ArticuloSel { get; set; }

        static readonly IService Service = new Service();

        static readonly HelperDb HelperDb = new HelperDb();
        public RpOrdenCompraPendFrm()
        {
            InitializeComponent();
            var styleController = new StyleController();
            WinFormUtils.SetStyleController(this, styleController);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ArticuloSel = null;
            DialogResult = DialogResult.Cancel;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Reporte();
        }

        private void CargarReferencias()
        {
            
        }

        private void Reporte()
        {
            DateTime fechaInicio = (DateTime)iFechaInicio.EditValue;
            DateTime fechaFinal = (DateTime)iFechaFinal.EditValue;
            string nameRelation = null;
            string whereList = null;
            string ordersList = null;
            string fieldsList = null;
            string nameFileReport = null;
            string whereProveedor;
            string reporte = null;
            List<VwSucursal> vwSucursalList =
                       Service.GetAllVwSucursal(x => x.Idempresa == SessionApp.EmpresaSel.Idempresa);
            var idProveedor = iIdsocionegocio.EditValue;
            switch (lbOptions.SelectedIndex)
            {
                   
                case 0:
                    nameRelation = "compras.vwrpordenespendientesingreso";
                    whereProveedor = idProveedor != null ? string.Format(" and idproveedor = {0}", (int)idProveedor) : string.Empty;
                    whereList = string.Format("saldoaimportar > 0 and fechaordencompra BETWEEN '{0}' and '{1}' and idsucursal = {2} {3}"
                    , fechaInicio.ToString("yyyyMMdd")
                    , fechaFinal.ToString("yyyyMMdd")
                    , SessionApp.SucursalSel.Idsucursal
                    , whereProveedor);

                    ordersList = "nombretipoformato,serieorden,numeroorden,numeroitem";
                    fieldsList = "*";
                    nameFileReport = "ocpendienteingreso.frx";
                    break;

                case 1:

                    nameRelation = "compras.vwrpordenespendientescpcompra";
                    whereProveedor = idProveedor != null ? string.Format(" and idproveedor = {0}", (int)idProveedor) : string.Empty;
                    whereList = string.Format("saldoaimportar > 0 and fechaordencompra BETWEEN '{0}' and '{1}' and idsucursal = {2} {3}"
                    , fechaInicio.ToString("yyyyMMdd")
                    , fechaFinal.ToString("yyyyMMdd")
                    , SessionApp.SucursalSel.Idsucursal
                    , whereProveedor);
                    ordersList = "nombretipoformato,serieorden,numeroorden,numeroitem";
                    fieldsList = "*";
                    nameFileReport = "ocpendientecpcompra.frx";
                    
                    break;
                case 2:
                    
                   
                    break;

            }

                DataTable dt = HelperDb.SqlConsulta(nameRelation, whereList, ordersList, fieldsList);

                var report = new Report();

                reporte = FilesHelper.FindingFileName(Application.StartupPath, string.Format("Reportes\\Compras\\{0}", nameFileReport));
                report.Load(reporte);
                report.RegisterData(dt, "oc");
                report.RegisterData(vwSucursalList, "emp");
                report.SetParameterValue("FechaInicio", fechaInicio.ToString("yyyyMMdd"));
                report.SetParameterValue("FechaFinal", fechaFinal.ToString("yyyyMMdd"));
                int opcionReporte = (int)rgOpcionReporte.EditValue;
                switch (opcionReporte)
                {
                    case 0: //Vistaprevia
                        report.Show();
                        break;
                    case 1: //Diseño
                        report.Design();
                        break;
                }
                report.Dispose();
                    
            
        }

        private void beSocioNegocio_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0: //Buscar
                    BuscadorSocioNegocioFrm buscarSocioNegocioFrm = new BuscadorSocioNegocioFrm();
                    buscarSocioNegocioFrm.ShowDialog();

                    if (buscarSocioNegocioFrm.DialogResult == DialogResult.OK &&
                        buscarSocioNegocioFrm.VwSocionegocioSel != null)
                    {
                        var vwSocionegocioSel = buscarSocioNegocioFrm.VwSocionegocioSel;
                        beSocioNegocio.Text = vwSocionegocioSel.Razonsocial.Trim();
                        iIdsocionegocio.EditValue = vwSocionegocioSel.Idsocionegocio;
                    }
                    break;
                case 1: //Borrar
                    beSocioNegocio.Text = @"Todos los proveedores";
                    iIdsocionegocio.EditValue = null;
                    break;
            }
        }

        private void RpOrdenCompraPendFrm_Load(object sender, EventArgs e)
        {
            iFechaInicio.EditValue = SessionApp.DateServer;
            iFechaFinal.EditValue = SessionApp.DateServer;
            iFechaInicio.Select();
            rgOpcionReporte.EditValue = 0;
            lbOptions.SelectedIndex = 0;
            CargarReferencias();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbOptions.SelectedIndex)
            {

                case 0:
                 
                    beSocioNegocio.Visible = true;
                    lcProveedor.Visible = true;
                    break;
                case 1:
                    
                    beSocioNegocio.Visible = true;
                    lcProveedor.Visible = true;
                    break;
                case 2:
                    beSocioNegocio.Visible = false;
                    lcProveedor.Visible = false;
                   
                    break;
            }
        }
    }
}