﻿namespace WinFormsApp
{
    partial class ItemhistoriaMntFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemhistoriaMntFrm));
            this.bmMantenimiento = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMnt = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrabar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrabarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrabarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnLimpiarCampos = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pkIdEntidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.iNombreitemhistoria = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.iOrdenitemhistoria = new DevExpress.XtraEditors.TextEdit();
            this.iIdcategoriaitem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.iTipodatoitemhistoria = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.iRequierearchivo = new DevExpress.XtraEditors.CheckEdit();
            this.iRequiereplanembarazoparto = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkIdEntidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNombreitemhistoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOrdenitemhistoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iIdcategoriaitem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTipodatoitemhistoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRequierearchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRequiereplanembarazoparto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bmMantenimiento
            // 
            this.bmMantenimiento.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMnt});
            this.bmMantenimiento.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Mantenimiento", new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5")),
            new DevExpress.XtraBars.BarManagerCategory("Navegación", new System.Guid("914e515b-0bf8-4995-97b2-cce8dc1d7479"))});
            this.bmMantenimiento.DockControls.Add(this.barDockControlTop);
            this.bmMantenimiento.DockControls.Add(this.barDockControlBottom);
            this.bmMantenimiento.DockControls.Add(this.barDockControlLeft);
            this.bmMantenimiento.DockControls.Add(this.barDockControlRight);
            this.bmMantenimiento.Form = this;
            this.bmMantenimiento.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevo,
            this.btnGrabar,
            this.btnGrabarCerrar,
            this.btnGrabarNuevo,
            this.btnLimpiarCampos,
            this.btnEliminar,
            this.btnCerrar,
            this.btnActualizar});
            this.bmMantenimiento.MaxItemId = 84;
            this.bmMantenimiento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bmMantenimiento_ItemClick);
            // 
            // BarMnt
            // 
            this.BarMnt.BarName = "Tools Mantenimiento";
            this.BarMnt.CanDockStyle = ((DevExpress.XtraBars.BarCanDockStyle)(((((DevExpress.XtraBars.BarCanDockStyle.Left | DevExpress.XtraBars.BarCanDockStyle.Top) 
            | DevExpress.XtraBars.BarCanDockStyle.Right) 
            | DevExpress.XtraBars.BarCanDockStyle.Bottom) 
            | DevExpress.XtraBars.BarCanDockStyle.Standalone)));
            this.BarMnt.DockCol = 0;
            this.BarMnt.DockRow = 0;
            this.BarMnt.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BarMnt.FloatLocation = new System.Drawing.Point(376, 165);
            this.BarMnt.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrabar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrabarCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrabarNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLimpiarCampos, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.BarMnt.OptionsBar.UseWholeRow = true;
            this.BarMnt.Text = "Barra de herramientas";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnNuevo.Glyph = global::WinFormsApp.Properties.Resources.Action_New;
            this.btnNuevo.Id = 55;
            this.btnNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnNuevo.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_New_32x32;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ShortcutKeyDisplayString = "Ctrl +N";
            toolTipTitleItem1.Text = "Nuevo (Ctrl + N)";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnNuevo.SuperTip = superToolTip1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Caption = "Grabar";
            this.btnGrabar.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnGrabar.Glyph = global::WinFormsApp.Properties.Resources.Action_Save;
            this.btnGrabar.Id = 78;
            this.btnGrabar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.btnGrabar.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_Save_32x32;
            this.btnGrabar.Name = "btnGrabar";
            toolTipTitleItem2.Text = "Grabar (Ctrl + G)";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnGrabar.SuperTip = superToolTip2;
            // 
            // btnGrabarCerrar
            // 
            this.btnGrabarCerrar.Caption = "Grabar y cerrar";
            this.btnGrabarCerrar.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnGrabarCerrar.Glyph = global::WinFormsApp.Properties.Resources.Action_Save_Close;
            this.btnGrabarCerrar.Id = 79;
            this.btnGrabarCerrar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnGrabarCerrar.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_Save_Close_32x32;
            this.btnGrabarCerrar.Name = "btnGrabarCerrar";
            toolTipTitleItem3.Text = "Grabar y cerrar (Ctrl + Enter)";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnGrabarCerrar.SuperTip = superToolTip3;
            // 
            // btnGrabarNuevo
            // 
            this.btnGrabarNuevo.Caption = "Grabar y nuevo";
            this.btnGrabarNuevo.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnGrabarNuevo.Glyph = global::WinFormsApp.Properties.Resources.Action_Save_New;
            this.btnGrabarNuevo.Id = 80;
            this.btnGrabarNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert));
            this.btnGrabarNuevo.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_Save_New_32x32;
            this.btnGrabarNuevo.Name = "btnGrabarNuevo";
            toolTipTitleItem4.Text = "Grabar y Nuevo (Ctrl + Ins)";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.btnGrabarNuevo.SuperTip = superToolTip4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnEliminar.Glyph = global::WinFormsApp.Properties.Resources.Action_Delete;
            this.btnEliminar.Id = 57;
            this.btnEliminar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEliminar.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_Delete_32x32;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShortcutKeyDisplayString = "Ctrl + E";
            toolTipTitleItem5.Text = "Eliminar (Ctrl + E)\r\n";
            superToolTip5.Items.Add(toolTipTitleItem5);
            this.btnEliminar.SuperTip = superToolTip5;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Caption = "Limpiar campos";
            this.btnLimpiarCampos.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnLimpiarCampos.Id = 82;
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.CategoryGuid = new System.Guid("bf24888c-c336-4331-92ed-90df15ac84f5");
            this.btnActualizar.Glyph = global::WinFormsApp.Properties.Resources.Action_Refresh;
            this.btnActualizar.Id = 77;
            this.btnActualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnActualizar.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_Refresh_32x32;
            this.btnActualizar.Name = "btnActualizar";
            toolTipTitleItem6.Text = "Actualizar (F5)";
            superToolTip6.Items.Add(toolTipTitleItem6);
            this.btnActualizar.SuperTip = superToolTip6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Salir";
            this.btnCerrar.CategoryGuid = new System.Guid("914e515b-0bf8-4995-97b2-cce8dc1d7479");
            this.btnCerrar.Glyph = global::WinFormsApp.Properties.Resources.Action_Close;
            this.btnCerrar.Id = 75;
            this.btnCerrar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnCerrar.LargeGlyph = global::WinFormsApp.Properties.Resources.Action_Close_32x32;
            this.btnCerrar.Name = "btnCerrar";
            toolTipTitleItem7.Text = "Salir de ventana (Ctrl + S)";
            superToolTip7.Items.Add(toolTipTitleItem7);
            this.btnCerrar.SuperTip = superToolTip7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(729, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 195);
            this.barDockControlBottom.Size = new System.Drawing.Size(729, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 164);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(729, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 164);
            // 
            // pkIdEntidad
            // 
            this.pkIdEntidad.EditValue = "0";
            this.pkIdEntidad.Location = new System.Drawing.Point(147, 39);
            this.pkIdEntidad.MenuManager = this.bmMantenimiento;
            this.pkIdEntidad.Name = "pkIdEntidad";
            this.pkIdEntidad.Properties.AllowFocused = false;
            this.pkIdEntidad.Properties.Appearance.Options.UseTextOptions = true;
            this.pkIdEntidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pkIdEntidad.Properties.ReadOnly = true;
            this.pkIdEntidad.Size = new System.Drawing.Size(59, 20);
            this.pkIdEntidad.TabIndex = 1;
            this.pkIdEntidad.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id.";
            // 
            // iNombreitemhistoria
            // 
            this.iNombreitemhistoria.Location = new System.Drawing.Point(147, 118);
            this.iNombreitemhistoria.MenuManager = this.bmMantenimiento;
            this.iNombreitemhistoria.Name = "iNombreitemhistoria";
            this.iNombreitemhistoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.iNombreitemhistoria.Size = new System.Drawing.Size(488, 20);
            this.iNombreitemhistoria.TabIndex = 7;
            this.iNombreitemhistoria.Tag = "Ingrese el nombre de tipo de historia";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Nombre tipo de historia";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Orden";
            // 
            // iOrdenitemhistoria
            // 
            this.iOrdenitemhistoria.EditValue = 0;
            this.iOrdenitemhistoria.Location = new System.Drawing.Point(147, 92);
            this.iOrdenitemhistoria.MenuManager = this.bmMantenimiento;
            this.iOrdenitemhistoria.Name = "iOrdenitemhistoria";
            this.iOrdenitemhistoria.Properties.Appearance.Options.UseTextOptions = true;
            this.iOrdenitemhistoria.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.iOrdenitemhistoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.iOrdenitemhistoria.Properties.Mask.EditMask = "n0";
            this.iOrdenitemhistoria.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.iOrdenitemhistoria.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.iOrdenitemhistoria.Size = new System.Drawing.Size(55, 20);
            this.iOrdenitemhistoria.TabIndex = 5;
            // 
            // iIdcategoriaitem
            // 
            this.iIdcategoriaitem.Location = new System.Drawing.Point(147, 66);
            this.iIdcategoriaitem.MenuManager = this.bmMantenimiento;
            this.iIdcategoriaitem.Name = "iIdcategoriaitem";
            this.iIdcategoriaitem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iIdcategoriaitem.Properties.View = this.searchLookUpEdit1View;
            this.iIdcategoriaitem.Size = new System.Drawing.Size(488, 20);
            this.iIdcategoriaitem.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id.";
            this.gridColumn1.FieldName = "Idcategoriaitem";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Código";
            this.gridColumn2.FieldName = "Codigocategoriaitem";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Categoria";
            this.gridColumn3.FieldName = "Nombrecategoriaitem";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Categoria";
            // 
            // iTipodatoitemhistoria
            // 
            this.iTipodatoitemhistoria.Location = new System.Drawing.Point(147, 145);
            this.iTipodatoitemhistoria.MenuManager = this.bmMantenimiento;
            this.iTipodatoitemhistoria.Name = "iTipodatoitemhistoria";
            this.iTipodatoitemhistoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iTipodatoitemhistoria.Properties.Items.AddRange(new object[] {
            "int",
            "string",
            "bool",
            "decimal",
            "char",
            "DateTime"});
            this.iTipodatoitemhistoria.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.iTipodatoitemhistoria.Size = new System.Drawing.Size(179, 20);
            this.iTipodatoitemhistoria.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 148);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Tipo de dato";
            // 
            // iRequierearchivo
            // 
            this.iRequierearchivo.Location = new System.Drawing.Point(147, 172);
            this.iRequierearchivo.MenuManager = this.bmMantenimiento;
            this.iRequierearchivo.Name = "iRequierearchivo";
            this.iRequierearchivo.Properties.AutoWidth = true;
            this.iRequierearchivo.Properties.Caption = "Requiere archivos";
            this.iRequierearchivo.Size = new System.Drawing.Size(108, 19);
            this.iRequierearchivo.TabIndex = 10;
            // 
            // iRequiereplanembarazoparto
            // 
            this.iRequiereplanembarazoparto.Location = new System.Drawing.Point(261, 172);
            this.iRequiereplanembarazoparto.MenuManager = this.bmMantenimiento;
            this.iRequiereplanembarazoparto.Name = "iRequiereplanembarazoparto";
            this.iRequiereplanembarazoparto.Properties.AutoWidth = true;
            this.iRequiereplanembarazoparto.Properties.Caption = "Requiere archivos";
            this.iRequiereplanembarazoparto.Size = new System.Drawing.Size(108, 19);
            this.iRequiereplanembarazoparto.TabIndex = 11;
            // 
            // ItemhistoriaMntFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(729, 195);
            this.Controls.Add(this.iRequiereplanembarazoparto);
            this.Controls.Add(this.iRequierearchivo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.iTipodatoitemhistoria);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.iIdcategoriaitem);
            this.Controls.Add(this.iOrdenitemhistoria);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.iNombreitemhistoria);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pkIdEntidad);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ItemhistoriaMntFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de items de historia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemhistoriaMntFrm_FormClosing);
            this.Load += new System.EventHandler(this.ItemhistoriaMntFrm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemhistoriaMntFrm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bmMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkIdEntidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNombreitemhistoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOrdenitemhistoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iIdcategoriaitem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTipodatoitemhistoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRequierearchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRequiereplanembarazoparto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmMantenimiento;
        private DevExpress.XtraBars.Bar BarMnt;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGrabar;
        private DevExpress.XtraBars.BarButtonItem btnGrabarCerrar;
        private DevExpress.XtraBars.BarButtonItem btnGrabarNuevo;
        private DevExpress.XtraBars.BarButtonItem btnLimpiarCampos;
        private DevExpress.XtraEditors.TextEdit pkIdEntidad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit iNombreitemhistoria;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit iOrdenitemhistoria;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit iIdcategoriaitem;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit iRequiereplanembarazoparto;
        private DevExpress.XtraEditors.CheckEdit iRequierearchivo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit iTipodatoitemhistoria;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;

    }
}