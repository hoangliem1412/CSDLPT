using System;
using System.Windows.Forms;

namespace QLVT_DATHANG_PT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DSPM);

            this.toolStrip1.Visible = false;
            this.ribbonControl.Visible = false;
            this.cboChinhanh_SelectedIndexChanged(null, null);
        }

        private void cboChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = this.cboChinhanh.SelectedValue + "";
            //or Program.servername = this.cboChinhanh.SelectedValue?.ToString() dấu ? là kiểm tra nếu null sẽ không làm phía sau (.tostring())
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (this.txtDangnhap.Text.Trim() == "" || this.txtMatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = this.txtDangnhap.Text;
            Program.password = this.txtMatkhau.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = this.cboChinhanh.SelectedIndex;
            Program.bds_dspm = this.v_DSPMBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_LAYTHONGTINDANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            this.MANV.Text = "Mã NV : " + Program.username;
            this.HOTEN.Text = "Họ tên : " + Program.mHoten;
            this.NHOM.Text = "Nhóm : " + Program.mGroup;
            this.toolStrip1.Visible = true;
            this.ribbonControl.Visible = true;
            this.grbDangnhap.Visible = false;
            if (Program.mGroup == "User")
            {
                this.btnTaoTK.Enabled = false;
            }
        }

        //button Nhanvien
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanvien f = new frmNhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVattu));
            if (frm != null) frm.Activate();
            else
            {
                frmVattu f = new frmVattu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.CheckExists(typeof(frmNHANVIEN));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    frmNHANVIEN f = new frmNHANVIEN();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }
        

        private void btnDondathang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDatHang));
            if (frm != null) frm.Activate();
            else
            {
                frmDatHang f = new frmDatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void T(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //Application.Restart();
            //Program.conn.Close();
            //if password true then send true           
            
                //MessageBox.Show("Thank you for activation!");
                //this.Hide();
                Application.Restart();
        
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangky));
            if (frm != null) frm.Activate();
            else
            {
                frmDangky f = new frmDangky();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieunhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Phieunhap));
            if (frm != null) frm.Activate();
            else
            {
                Phieunhap f = new Phieunhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuxuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuxuat f = new frmPhieuxuat();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
