namespace QLVT_DATHANG_PT
{
    partial class frmDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            DevExpress.XtraGrid.Columns.GridColumn colMANV;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThemDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnTailaiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatHangDataSet = new QLVT_DATHANG_PT.QLVT_DATHANGDataSet();
            this.grbDDH = new System.Windows.Forms.GroupBox();
            this.txtMakho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.cboNhanvien = new System.Windows.Forms.ComboBox();
            this.hoTenNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCTDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCTDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiCTDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.gcDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbCTDDH = new System.Windows.Forms.GroupBox();
            this.cboVattu = new System.Windows.Forms.ComboBox();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDDH_CT = new DevExpress.XtraEditors.TextEdit();
            this.gvCTDDH = new System.Windows.Forms.DataGridView();
            this.masoDDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.cboChinhanh = new System.Windows.Forms.ComboBox();
            this.vattuTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.khoTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.hoTenNVTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.HoTenNVTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatHangDataSet)).BeginInit();
            this.grbDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grbCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(12, 28);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(92, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 17);
            label1.TabIndex = 10;
            label1.Text = "Nhà cung cấp : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 17);
            label2.TabIndex = 11;
            label2.Text = "Ngày : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(398, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 17);
            label3.TabIndex = 12;
            label3.Text = "Kho : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(398, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 17);
            label4.TabIndex = 13;
            label4.Text = "Mã nhân viên : ";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel1.Location = new System.Drawing.Point(6, 29);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(92, 17);
            masoDDHLabel1.TabIndex = 0;
            masoDDHLabel1.Text = "Mã số DDH : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(5, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 17);
            label5.TabIndex = 8;
            label5.Text = "Vật tư : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(6, 108);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 17);
            label6.TabIndex = 9;
            label6.Text = "Số lượng : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(6, 148);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(57, 17);
            label7.TabIndex = 10;
            label7.Text = "Đơn giá";
            // 
            // colMANV
            // 
            colMANV.Caption = "Mã nhân viên";
            colMANV.FieldName = "MANV";
            colMANV.Name = "colMANV";
            colMANV.Visible = true;
            colMANV.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 47);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1286, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 650);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1286, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 603);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1286, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 603);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnXoaDDH,
            this.btnGhiDDH,
            this.btnThoat,
            this.btnThemDDH,
            this.btnPhuchoiDDH,
            this.btnTailaiDDH});
            this.barManager2.MaxItemId = 7;
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(1576, 151);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoiDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTailaiDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.Text = "Tools";
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Caption = "Thêm";
            this.btnThemDDH.Id = 4;
            this.btnThemDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemDDH.ImageOptions.SvgImage")));
            this.btnThemDDH.Name = "btnThemDDH";
            this.btnThemDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDDH_ItemClick);
            // 
            // btnXoaDDH
            // 
            this.btnXoaDDH.Caption = "Xóa";
            this.btnXoaDDH.Id = 1;
            this.btnXoaDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaDDH.ImageOptions.SvgImage")));
            this.btnXoaDDH.Name = "btnXoaDDH";
            this.btnXoaDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaDDH_ItemClick);
            // 
            // btnGhiDDH
            // 
            this.btnGhiDDH.Caption = "Ghi";
            this.btnGhiDDH.Id = 2;
            this.btnGhiDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiDDH.ImageOptions.SvgImage")));
            this.btnGhiDDH.Name = "btnGhiDDH";
            this.btnGhiDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiDDH_ItemClick);
            // 
            // btnPhuchoiDDH
            // 
            this.btnPhuchoiDDH.Caption = "Phục hồi";
            this.btnPhuchoiDDH.Id = 5;
            this.btnPhuchoiDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuchoiDDH.ImageOptions.SvgImage")));
            this.btnPhuchoiDDH.Name = "btnPhuchoiDDH";
            this.btnPhuchoiDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoiDDH_ItemClick);
            // 
            // btnTailaiDDH
            // 
            this.btnTailaiDDH.Caption = "Tải lại";
            this.btnTailaiDDH.Id = 6;
            this.btnTailaiDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTailaiDDH.ImageOptions.SvgImage")));
            this.btnTailaiDDH.Name = "btnTailaiDDH";
            this.btnTailaiDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTailaiDDH_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1286, 47);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 650);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1286, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 47);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 603);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1286, 47);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 603);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.DatHangDataSet;
            // 
            // DatHangDataSet
            // 
            this.DatHangDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.DatHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbDDH
            // 
            this.grbDDH.Controls.Add(this.txtMakho);
            this.grbDDH.Controls.Add(this.txtMaNV);
            this.grbDDH.Controls.Add(this.txtNhaCC);
            this.grbDDH.Controls.Add(this.cboNhanvien);
            this.grbDDH.Controls.Add(this.cboKho);
            this.grbDDH.Controls.Add(label4);
            this.grbDDH.Controls.Add(label3);
            this.grbDDH.Controls.Add(label2);
            this.grbDDH.Controls.Add(label1);
            this.grbDDH.Controls.Add(this.dtpNgay);
            this.grbDDH.Controls.Add(masoDDHLabel);
            this.grbDDH.Controls.Add(this.txtMaDDH);
            this.grbDDH.Location = new System.Drawing.Point(0, 270);
            this.grbDDH.Name = "grbDDH";
            this.grbDDH.Size = new System.Drawing.Size(754, 172);
            this.grbDDH.TabIndex = 17;
            this.grbDDH.TabStop = false;
            // 
            // txtMakho
            // 
            this.txtMakho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBindingSource, "MAKHO", true));
            this.txtMakho.Location = new System.Drawing.Point(688, 67);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.Size = new System.Drawing.Size(47, 20);
            this.txtMakho.TabIndex = 21;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(688, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(47, 20);
            this.txtMaNV.TabIndex = 20;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBindingSource, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(127, 104);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(209, 20);
            this.txtNhaCC.TabIndex = 19;
            // 
            // cboNhanvien
            // 
            this.cboNhanvien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoTenNVBindingSource, "HOTEN", true));
            this.cboNhanvien.DataSource = this.hoTenNVBindingSource;
            this.cboNhanvien.DisplayMember = "HOTEN";
            this.cboNhanvien.FormattingEnabled = true;
            this.cboNhanvien.Location = new System.Drawing.Point(509, 24);
            this.cboNhanvien.Name = "cboNhanvien";
            this.cboNhanvien.Size = new System.Drawing.Size(173, 21);
            this.cboNhanvien.TabIndex = 16;
            this.cboNhanvien.ValueMember = "MANV";
            this.cboNhanvien.SelectedIndexChanged += new System.EventHandler(this.cboNhanvien_SelectedIndexChanged);
            // 
            // hoTenNVBindingSource
            // 
            this.hoTenNVBindingSource.DataMember = "HoTenNV";
            this.hoTenNVBindingSource.DataSource = this.DatHangDataSet;
            // 
            // cboKho
            // 
            this.cboKho.DataSource = this.khoBindingSource;
            this.cboKho.DisplayMember = "TENKHO";
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(509, 68);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(173, 21);
            this.cboKho.TabIndex = 15;
            this.cboKho.ValueMember = "MAKHO";
            this.cboKho.SelectedIndexChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.DatHangDataSet;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datHangBindingSource, "NGAY", true));
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBindingSource, "NGAY", true));
            this.dtpNgay.Location = new System.Drawing.Point(127, 67);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(209, 20);
            this.dtpNgay.TabIndex = 3;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBindingSource, "MasoDDH", true));
            this.txtMaDDH.Location = new System.Drawing.Point(127, 27);
            this.txtMaDDH.MenuManager = this.barManager1;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(209, 20);
            this.txtMaDDH.TabIndex = 1;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.cTDDHBindingSource.DataSource = this.datHangBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.SP_TAOTAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            this.tableAdapterManager.Xoa_LoginTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCTDDH,
            this.btnXoaCTDDH,
            this.btnGhiCTDDH});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // btnThemCTDDH
            // 
            this.btnThemCTDDH.Name = "btnThemCTDDH";
            this.btnThemCTDDH.Size = new System.Drawing.Size(172, 22);
            this.btnThemCTDDH.Text = "Thêm chi tiết DDH";
            this.btnThemCTDDH.Click += new System.EventHandler(this.btnThemCTDDH_Click);
            // 
            // btnXoaCTDDH
            // 
            this.btnXoaCTDDH.Name = "btnXoaCTDDH";
            this.btnXoaCTDDH.Size = new System.Drawing.Size(172, 22);
            this.btnXoaCTDDH.Text = "Xóa chi tiết DDH";
            this.btnXoaCTDDH.Click += new System.EventHandler(this.btnXoaCTDDH_Click);
            // 
            // btnGhiCTDDH
            // 
            this.btnGhiCTDDH.Name = "btnGhiCTDDH";
            this.btnGhiCTDDH.Size = new System.Drawing.Size(172, 22);
            this.btnGhiCTDDH.Text = "Ghi chi tiết DDH";
            this.btnGhiCTDDH.Click += new System.EventHandler(this.btnGhiCTDDH_Click);
            // 
            // gcDDH
            // 
            this.gcDDH.DataSource = this.datHangBindingSource;
            this.gcDDH.Location = new System.Drawing.Point(4, 132);
            this.gcDDH.MainView = this.gridView1;
            this.gcDDH.MenuManager = this.barManager1;
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(750, 144);
            this.gcDDH.TabIndex = 27;
            this.gcDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDDH;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số DDH ";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // grbCTDDH
            // 
            this.grbCTDDH.Controls.Add(this.cboVattu);
            this.grbCTDDH.Controls.Add(label7);
            this.grbCTDDH.Controls.Add(label6);
            this.grbCTDDH.Controls.Add(label5);
            this.grbCTDDH.Controls.Add(this.txtDongia);
            this.grbCTDDH.Controls.Add(this.txtSoluong);
            this.grbCTDDH.Controls.Add(this.txtMaVT);
            this.grbCTDDH.Controls.Add(masoDDHLabel1);
            this.grbCTDDH.Controls.Add(this.txtMaDDH_CT);
            this.grbCTDDH.Location = new System.Drawing.Point(451, 439);
            this.grbCTDDH.Name = "grbCTDDH";
            this.grbCTDDH.Size = new System.Drawing.Size(303, 191);
            this.grbCTDDH.TabIndex = 28;
            this.grbCTDDH.TabStop = false;
            // 
            // cboVattu
            // 
            this.cboVattu.DataSource = this.vattuBindingSource;
            this.cboVattu.DisplayMember = "TENVT";
            this.cboVattu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVattu.FormattingEnabled = true;
            this.cboVattu.Location = new System.Drawing.Point(103, 64);
            this.cboVattu.Name = "cboVattu";
            this.cboVattu.Size = new System.Drawing.Size(143, 21);
            this.cboVattu.TabIndex = 11;
            this.cboVattu.ValueMember = "MAVT";
            this.cboVattu.SelectedIndexChanged += new System.EventHandler(this.cboVattu_SelectedIndexChanged);
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.DatHangDataSet;
            // 
            // txtDongia
            // 
            this.txtDongia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBindingSource, "DONGIA", true));
            this.txtDongia.Location = new System.Drawing.Point(103, 147);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(181, 20);
            this.txtDongia.TabIndex = 7;
            // 
            // txtSoluong
            // 
            this.txtSoluong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "SOLUONG", true));
            this.txtSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoluong.Location = new System.Drawing.Point(103, 105);
            this.txtSoluong.MenuManager = this.barManager1;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoluong.Size = new System.Drawing.Size(181, 20);
            this.txtSoluong.TabIndex = 5;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MAVT", true));
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBindingSource, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(252, 64);
            this.txtMaVT.MenuManager = this.barManager2;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(32, 20);
            this.txtMaVT.TabIndex = 3;
            this.txtMaVT.EditValueChanged += new System.EventHandler(this.txtMaVT_EditValueChanged);
            // 
            // txtMaDDH_CT
            // 
            this.txtMaDDH_CT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MasoDDH", true));
            this.txtMaDDH_CT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBindingSource, "MasoDDH", true));
            this.txtMaDDH_CT.Location = new System.Drawing.Point(103, 28);
            this.txtMaDDH_CT.MenuManager = this.barManager1;
            this.txtMaDDH_CT.Name = "txtMaDDH_CT";
            this.txtMaDDH_CT.Size = new System.Drawing.Size(181, 20);
            this.txtMaDDH_CT.TabIndex = 1;
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.AutoGenerateColumns = false;
            this.gvCTDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCTDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masoDDHDataGridViewTextBoxColumn,
            this.mAVTDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn});
            this.gvCTDDH.DataSource = this.cTDDHBindingSource;
            this.gvCTDDH.Location = new System.Drawing.Point(0, 445);
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.Size = new System.Drawing.Size(445, 185);
            this.gvCTDDH.TabIndex = 29;
            // 
            // masoDDHDataGridViewTextBoxColumn
            // 
            this.masoDDHDataGridViewTextBoxColumn.DataPropertyName = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.HeaderText = "Mã số DDH ";
            this.masoDDHDataGridViewTextBoxColumn.Name = "masoDDHDataGridViewTextBoxColumn";
            // 
            // mAVTDataGridViewTextBoxColumn
            // 
            this.mAVTDataGridViewTextBoxColumn.DataPropertyName = "MAVT";
            this.mAVTDataGridViewTextBoxColumn.HeaderText = "Mã vật tư ";
            this.mAVTDataGridViewTextBoxColumn.Name = "mAVTDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Chi nhánh";
            // 
            // cboChinhanh
            // 
            this.cboChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChinhanh.FormattingEnabled = true;
            this.cboChinhanh.Location = new System.Drawing.Point(80, 77);
            this.cboChinhanh.Name = "cboChinhanh";
            this.cboChinhanh.Size = new System.Drawing.Size(312, 21);
            this.cboChinhanh.TabIndex = 40;
            this.cboChinhanh.SelectedIndexChanged += new System.EventHandler(this.cboChinhanh_SelectedIndexChanged);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 650);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.cboChinhanh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvCTDDH);
            this.Controls.Add(this.grbCTDDH);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.grbDDH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmDatHang";
            this.Text = "frmDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatHangDataSet)).EndInit();
            this.grbDDH.ResumeLayout(false);
            this.grbDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grbCTDDH.ResumeLayout(false);
            this.grbCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.GroupBox grbDDH;
        private QLVT_DATHANGDataSet DatHangDataSet;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCTDDH;
        private System.Windows.Forms.DataGridView gvCTDDH;
        private System.Windows.Forms.GroupBox grbCTDDH;
        private System.Windows.Forms.TextBox txtDongia;
        private DevExpress.XtraEditors.SpinEdit txtSoluong;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraEditors.TextEdit txtMaDDH_CT;
        private DevExpress.XtraGrid.GridControl gcDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private DevExpress.XtraEditors.TextEdit txtMaDDH;
        private DevExpress.XtraBars.BarButtonItem btnThemDDH;
        private DevExpress.XtraBars.BarButtonItem btnXoaDDH;
        private DevExpress.XtraBars.BarButtonItem btnGhiDDH;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ComboBox cboChinhanh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCTDDH;
        private System.Windows.Forms.ToolStripMenuItem btnGhiCTDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn masoDDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboVattu;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoiDDH;
        private DevExpress.XtraBars.BarButtonItem btnTailaiDDH;
        private System.Windows.Forms.BindingSource hoTenNVBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private System.Windows.Forms.ComboBox cboNhanvien;
        private System.Windows.Forms.TextBox txtMakho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNhaCC;
    }
}