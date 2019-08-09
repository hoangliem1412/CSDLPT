namespace QLVT_DATHANG_PT
{
    partial class frmDangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangky));
            this.grbTaikhoan = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.hoTenNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLVTDataset = new QLVT_DATHANG_PT.QLVT_DATHANGDataSet();
            this.cboHoten = new System.Windows.Forms.ComboBox();
            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.hoTenNVTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.HoTenNVTableAdapter();
            this.sP_TAOTAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TAOTAIKHOANTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.SP_TAOTAIKHOANTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.xoa_LoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xoa_LoginTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.Xoa_LoginTableAdapter();
            this.grbTaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVTDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TAOTAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoa_LoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTaikhoan
            // 
            this.grbTaikhoan.Controls.Add(this.txtMaNV);
            this.grbTaikhoan.Controls.Add(this.cboHoten);
            this.grbTaikhoan.Controls.Add(this.cboNhom);
            this.grbTaikhoan.Controls.Add(this.btnThoat);
            this.grbTaikhoan.Controls.Add(this.btnDangky);
            this.grbTaikhoan.Controls.Add(this.txtMK);
            this.grbTaikhoan.Controls.Add(this.txtTenDN);
            this.grbTaikhoan.Controls.Add(this.label5);
            this.grbTaikhoan.Controls.Add(this.label4);
            this.grbTaikhoan.Controls.Add(this.label3);
            this.grbTaikhoan.Controls.Add(this.label2);
            this.grbTaikhoan.Controls.Add(this.label1);
            this.grbTaikhoan.Location = new System.Drawing.Point(45, 66);
            this.grbTaikhoan.Name = "grbTaikhoan";
            this.grbTaikhoan.Size = new System.Drawing.Size(619, 287);
            this.grbTaikhoan.TabIndex = 0;
            this.grbTaikhoan.TabStop = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoTenNVBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(513, 72);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(80, 21);
            this.txtMaNV.TabIndex = 12;
            // 
            // hoTenNVBindingSource
            // 
            this.hoTenNVBindingSource.DataMember = "HoTenNV";
            this.hoTenNVBindingSource.DataSource = this.QLVTDataset;
            // 
            // QLVTDataset
            // 
            this.QLVTDataset.DataSetName = "QLVT_DATHANGDataSet";
            this.QLVTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboHoten
            // 
            this.cboHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoTenNVBindingSource, "HOTEN", true));
            this.cboHoten.DataSource = this.hoTenNVBindingSource;
            this.cboHoten.DisplayMember = "HOTEN";
            this.cboHoten.FormattingEnabled = true;
            this.cboHoten.Location = new System.Drawing.Point(175, 72);
            this.cboHoten.Name = "cboHoten";
            this.cboHoten.Size = new System.Drawing.Size(319, 21);
            this.cboHoten.TabIndex = 11;
            this.cboHoten.ValueMember = "MANV";
            this.cboHoten.SelectedIndexChanged += new System.EventHandler(this.cboHoten_SelectedIndexChanged);
            // 
            // cboNhom
            // 
            this.cboNhom.FormattingEnabled = true;
            this.cboNhom.Items.AddRange(new object[] {
            "ChiNhanh",
            "User"});
            this.cboNhom.Location = new System.Drawing.Point(175, 200);
            this.cboNhom.Name = "cboNhom";
            this.cboNhom.Size = new System.Drawing.Size(319, 21);
            this.cboNhom.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThoat.Location = new System.Drawing.Point(351, 240);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDangky.Location = new System.Drawing.Point(239, 240);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(82, 30);
            this.btnDangky.TabIndex = 9;
            this.btnDangky.Text = "Đồng ý";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(175, 160);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(319, 21);
            this.txtMK.TabIndex = 8;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(175, 118);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(319, 21);
            this.txtTenDN.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(22, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.SP_TAOTAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            this.tableAdapterManager.Xoa_LoginTableAdapter = null;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // sP_TAOTAIKHOANBindingSource
            // 
            this.sP_TAOTAIKHOANBindingSource.DataMember = "SP_TAOTAIKHOAN";
            this.sP_TAOTAIKHOANBindingSource.DataSource = this.QLVTDataset;
            // 
            // sP_TAOTAIKHOANTableAdapter
            // 
            this.sP_TAOTAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(688, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 372);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(688, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 325);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(688, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 325);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm tài khoản";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa tài khoản";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thoát";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // xoa_LoginBindingSource
            // 
            this.xoa_LoginBindingSource.DataMember = "Xoa_Login";
            this.xoa_LoginBindingSource.DataSource = this.QLVTDataset;
            // 
            // xoa_LoginTableAdapter
            // 
            this.xoa_LoginTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 395);
            this.Controls.Add(this.grbTaikhoan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDangky";
            this.Text = "frmDangky";
            this.Load += new System.EventHandler(this.frmDangky_Load);
            this.grbTaikhoan.ResumeLayout(false);
            this.grbTaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVTDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TAOTAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoa_LoginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTaikhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLVT_DATHANGDataSet QLVTDataset;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.BindingSource hoTenNVBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cboHoten;
        private System.Windows.Forms.BindingSource sP_TAOTAIKHOANBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.SP_TAOTAIKHOANTableAdapter sP_TAOTAIKHOANTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.BindingSource xoa_LoginBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.Xoa_LoginTableAdapter xoa_LoginTableAdapter;
    }
}