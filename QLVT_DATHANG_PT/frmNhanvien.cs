using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG_PT
{
    public partial class frmNhanvien : Form
    {
        int vitri = 0;
        string macn = "";

        public frmNhanvien()
        {
            InitializeComponent();
        }


        private void frmNhanvien_Load_1(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            

            macn = ((DataRowView)this.bdsNhanvien[0])["MACN"].ToString();
            this.cboChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            this.cboChinhanh.DisplayMember = "TENPM";
            this.cboChinhanh.ValueMember = "TENSERVER";
            this.cboChinhanh.SelectedIndex = Program.mChinhanh;
            
            if (Program.mGroup == "CongTy")
            {
                this.cboChinhanh.Enabled = true; // bật tắt theo phân quyền
                this.btnPhuchoi.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnSua.Enabled = this.btnGhi.Enabled = false;
            }
            else this.cboChinhanh.Enabled = false;
            this.grbNhanvien.Enabled = false;
            this.txtMaCN.Enabled = false;
            this.btnGhi.Enabled = this.btnPhuchoi.Enabled = false;
        }

        private void cboChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboChinhanh.SelectedValue?.ToString() == "System.Data.DataRowView") return;
            Program.servername = this.cboChinhanh.SelectedValue?.ToString();

            if (this.cboChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                macn = ((DataRowView)this.bdsNhanvien[0])["MACN"].ToString();
            }
        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.bdsNhanvien.Position;
            grbNhanvien.Enabled = true;
            this.bdsNhanvien.AddNew();
            this.txtMaCN.Text = macn;
            this.cboTrangthaixoa.SelectedValue = 0;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled  = false;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = this.btnThoat.Enabled = true;
            gcNhanvien.Enabled = false;
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            //if (this.phieuXuatBindingSource. > 0 || this.phieuNhapBindingSource.Count > 0 || this.datHangBindingSource.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "",
            //        MessageBoxButtons.OK);
            //    return;
            //}
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)this.bdsNhanvien[this.bdsNhanvien.Position])["MANV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    this.bdsNhanvien.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    this.bdsNhanvien.Position = this.bdsNhanvien.Find("MANV", manv);
                    return;
                }
            }

            if (this.bdsNhanvien.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.bdsNhanvien.Position;
            grbNhanvien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = true;
            gcNhanvien.Enabled = false;
        }

        private void btnGhi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaNV.Focus();
                return;
            }

            if (this.txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                this.txtHo.Focus();
                return;
            }

            if (this.txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                this.txtTen.Focus();
                return;
            }

            if (this.txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                this.txtDiachi.Focus();
                return;
            }

            if (this.txtMaCN.Text.Trim() == "")
            {
                MessageBox.Show("Mã chi nhánh không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaCN.Focus();
                return;
            }

            //if (this.cboTrangthaixoa.Text.Trim() == "")
            //{
            //    MessageBox.Show("Trạng thái xóa không được thiếu!", "", MessageBoxButtons.OK);
            //    this.cboTrangthaixoa.Focus();
            //    return;
            //}

            if (Int32.Parse(this.txtLuong.Text) < 4000000)
            {
                MessageBox.Show("Lương phải lớn hơn hoặc bằng 4000000!", "", MessageBoxButtons.OK);
                this.txtLuong.Focus();
                return;
            }
            
            try
            {
                this.bdsNhanvien.EndEdit();
                this.bdsNhanvien.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhanvien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = false;

            grbNhanvien.Enabled = false;
        }
        
        private void btnTailai_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cboTrangthaixoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtTrangthaixoa.Text = this.cboTrangthaixoa.SelectedIndex.ToString();
            }
            catch (Exception) { this.txtTrangthaixoa.Text = ""; }
        }

        private void txtTrangthaixoa_TextChanged(object sender, EventArgs e)
        {
            this.txtTrangthaixoa.Visible = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsNhanvien.CancelEdit();
            this.gcNhanvien.Enabled = true;
            this.grbNhanvien.Enabled = false;
            this.btnThem.Enabled = this.btnGhi.Enabled = this.btnXoa.Enabled = this.btnTailai.Enabled = true;
        }
    }
}
