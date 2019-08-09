namespace QLVT_DATHANG_PT
{
    partial class frmMain
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
            System.Windows.Forms.Label tENPMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnVattu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuN = new DevExpress.XtraBars.BarButtonItem();
            this.btnDondathang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.Kho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.Tao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuX = new DevExpress.XtraBars.BarButtonItem();
            this.ribDanhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG_PT.QLVT_DATHANGDataSet();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG_PT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.grbDangnhap = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.cboChinhanh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtDangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MANV = new System.Windows.Forms.ToolStripLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripLabel();
            this.NHOM = new System.Windows.Forms.ToolStripLabel();
            tENPMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.grbDangnhap.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tENPMLabel
            // 
            tENPMLabel.AutoSize = true;
            tENPMLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            tENPMLabel.Location = new System.Drawing.Point(65, 98);
            tENPMLabel.Name = "tENPMLabel";
            tENPMLabel.Size = new System.Drawing.Size(81, 19);
            tENPMLabel.TabIndex = 5;
            tENPMLabel.Text = "Chi nhánh";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnNhanvien,
            this.btnVattu,
            this.btnKho,
            this.btnPhieuN,
            this.btnDondathang,
            this.barButtonItem1,
            this.Kho,
            this.btnDangxuat,
            this.Tao,
            this.btnTaoTK,
            this.btnPhieuxuat,
            this.btnPhieuX});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 13;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribDanhmuc,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1133, 143);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Caption = "Nhân viên";
            this.btnNhanvien.Id = 1;
            this.btnNhanvien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanvien.ImageOptions.SvgImage")));
            this.btnNhanvien.LargeWidth = 100;
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnVattu
            // 
            this.btnVattu.Caption = "Vật tư";
            this.btnVattu.Id = 2;
            this.btnVattu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVattu.ImageOptions.SvgImage")));
            this.btnVattu.LargeWidth = 100;
            this.btnVattu.Name = "btnVattu";
            this.btnVattu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVattu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 3;
            this.btnKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKho.ImageOptions.SvgImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnPhieuN
            // 
            this.btnPhieuN.Caption = "Phiếu nhập ";
            this.btnPhieuN.Id = 4;
            this.btnPhieuN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuN.ImageOptions.SvgImage")));
            this.btnPhieuN.LargeWidth = 100;
            this.btnPhieuN.Name = "btnPhieuN";
            this.btnPhieuN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieunhap_ItemClick);
            // 
            // btnDondathang
            // 
            this.btnDondathang.Caption = "Đơn đặt hàng";
            this.btnDondathang.Id = 5;
            this.btnDondathang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDondathang.ImageOptions.SvgImage")));
            this.btnDondathang.LargeWidth = 100;
            this.btnDondathang.Name = "btnDondathang";
            this.btnDondathang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDondathang_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.T);
            // 
            // Kho
            // 
            this.Kho.Caption = "Kho";
            this.Kho.Id = 7;
            this.Kho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Kho.ImageOptions.SvgImage")));
            this.Kho.LargeWidth = 100;
            this.Kho.Name = "Kho";
            this.Kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Kho_ItemClick);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Id = 8;
            this.btnDangxuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangxuat.ImageOptions.SvgImage")));
            this.btnDangxuat.LargeWidth = 100;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // Tao
            // 
            this.Tao.Caption = "barButtonItem2";
            this.Tao.Id = 9;
            this.Tao.Name = "Tao";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tài khoản";
            this.btnTaoTK.Id = 10;
            this.btnTaoTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTK.ImageOptions.SvgImage")));
            this.btnTaoTK.LargeWidth = 100;
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // btnPhieuxuat
            // 
            this.btnPhieuxuat.Caption = "Phiếu xuất";
            this.btnPhieuxuat.Id = 11;
            this.btnPhieuxuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuxuat.ImageOptions.SvgImage")));
            this.btnPhieuxuat.LargeWidth = 100;
            this.btnPhieuxuat.Name = "btnPhieuxuat";
            // 
            // btnPhieuX
            // 
            this.btnPhieuX.Caption = "Phiếu xuất";
            this.btnPhieuX.Id = 12;
            this.btnPhieuX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuX.ImageOptions.SvgImage")));
            this.btnPhieuX.LargeWidth = 100;
            this.btnPhieuX.Name = "btnPhieuX";
            this.btnPhieuX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuX_ItemClick);
            // 
            // ribDanhmuc
            // 
            this.ribDanhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribDanhmuc.Name = "ribDanhmuc";
            this.ribDanhmuc.Text = "Danh mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanvien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVattu);
            this.ribbonPageGroup1.ItemLinks.Add(this.Kho);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhieuN);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDondathang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhieuX);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tài khoản";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDangxuat);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
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
            // grbDangnhap
            // 
            this.grbDangnhap.Controls.Add(this.btnThoat);
            this.grbDangnhap.Controls.Add(this.btnDangnhap);
            this.grbDangnhap.Controls.Add(tENPMLabel);
            this.grbDangnhap.Controls.Add(this.cboChinhanh);
            this.grbDangnhap.Controls.Add(this.label3);
            this.grbDangnhap.Controls.Add(this.txtMatkhau);
            this.grbDangnhap.Controls.Add(this.txtDangnhap);
            this.grbDangnhap.Controls.Add(this.label2);
            this.grbDangnhap.Controls.Add(this.label1);
            this.grbDangnhap.Location = new System.Drawing.Point(306, 212);
            this.grbDangnhap.Name = "grbDangnhap";
            this.grbDangnhap.Size = new System.Drawing.Size(695, 289);
            this.grbDangnhap.TabIndex = 3;
            this.grbDangnhap.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThoat.Location = new System.Drawing.Point(415, 238);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 27);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDangnhap.Location = new System.Drawing.Point(285, 238);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(87, 27);
            this.btnDangnhap.TabIndex = 7;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // cboChinhanh
            // 
            this.cboChinhanh.DataSource = this.v_DSPMBindingSource;
            this.cboChinhanh.DisplayMember = "TENPM";
            this.cboChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChinhanh.FormattingEnabled = true;
            this.cboChinhanh.Location = new System.Drawing.Point(213, 96);
            this.cboChinhanh.Name = "cboChinhanh";
            this.cboChinhanh.Size = new System.Drawing.Size(356, 21);
            this.cboChinhanh.TabIndex = 6;
            this.cboChinhanh.ValueMember = "TENSERVER";
            this.cboChinhanh.SelectedIndexChanged += new System.EventHandler(this.cboChinhanh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(65, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(213, 189);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(356, 21);
            this.txtMatkhau.TabIndex = 4;
            // 
            // txtDangnhap
            // 
            this.txtDangnhap.Location = new System.Drawing.Point(213, 143);
            this.txtDangnhap.Name = "txtDangnhap";
            this.txtDangnhap.Size = new System.Drawing.Size(356, 21);
            this.txtDangnhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(65, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(279, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.toolStrip1.Location = new System.Drawing.Point(0, 619);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1133, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(42, 22);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(46, 22);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 22);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 644);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbDangnhap);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "Form Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.grbDangnhap.ResumeLayout(false);
            this.grbDangnhap.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDanhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox grbDangnhap;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.ComboBox cboChinhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtDangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStripLabel MANV;
        private System.Windows.Forms.ToolStripLabel HOTEN;
        private System.Windows.Forms.ToolStripLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnNhanvien;
        private DevExpress.XtraBars.BarButtonItem btnVattu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnPhieuN;
        private DevExpress.XtraBars.BarButtonItem btnDondathang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem Kho;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarButtonItem Tao;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem btnPhieuxuat;
        private DevExpress.XtraBars.BarButtonItem btnPhieuX;
    }
}

