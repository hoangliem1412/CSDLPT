using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG_PT
{
    public partial class frmPhieuxuat : Form
    {
        int vitri = 0;
        string macn = "";
        public frmPhieuxuat()
        {
            InitializeComponent();
        }
        
        private void frmPhieuxuat_Load(object sender, EventArgs e)
        {

            this.QLVTDataSet.EnforceConstraints = false;
            this.LoadData();                                                                                                                                                      
            this.cboChinhanh.DataSource = Program.bds_dspm;
            this.cboChinhanh.DisplayMember = "TENPM";
            this.cboChinhanh.ValueMember = "TENSERVER";
            this.cboChinhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CongTy")
            {
                this.cboChinhanh.Enabled = true; // bật tắt theo phân quyền
                this.btnPhuchoiPX.Enabled = this.btnThemPX.Enabled = this.btnXoaPX.Enabled = this.btnGhiPX.Enabled = false;
                this.btnThemCTPX.Enabled = this.btnXoaCTPX.Enabled = this.btnGhiCTPX.Enabled = false;
            }
            else this.cboChinhanh.Enabled = false;

            this.dtpNgay.Enabled = false;
            this.txtMaVT.Enabled = this.txtMakho.Enabled = this.txtMaNV.Enabled = this.cboNhanvien.Enabled = false;
            this.grbPhieuxuat.Enabled = this.grbCTPX.Enabled = false;
            this.btnGhiCTPX.Enabled = this.btnGhiPX.Enabled = this.btnPhuchoiPX.Enabled = this.txtMaCTPX.Enabled = false;
        }

        void LoadData()
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVTDataSet.Vattu);
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.QLVTDataSet.CTPX);
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.QLVTDataSet.Kho);
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoTenNVTableAdapter.Fill(this.QLVTDataSet.HoTenNV);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.QLVTDataSet.PhieuXuat);
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
                this.LoadData();
                macn = ((DataRowView)this.phieuXuatBindingSource[0])["MACN"].ToString();
            }
        }


        private void cboNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cboNhanvien.Text.Length == 0)
            //{
            //    return;
            //}

            //this.txtMaNV.Text = this.cboNhanvien.SelectedValue.ToString();
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboKho.Text.Length == 0)
            {
                return;
            }

            this.txtMakho.Text = this.cboKho.SelectedValue.ToString();
        }

        private void cboVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboVattu.Text.Length == 0)
            {
                return;
            }

            this.txtMaVT.Text = this.cboVattu.SelectedValue.ToString();
        }

        private void btnThemPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grbPhieuxuat.Enabled = true;
            this.gcPhieuxuat.Enabled = false;
            this.phieuXuatBindingSource.AddNew();
            this.txtMaPX.Focus();
            this.cboNhanvien.SelectedIndex = -1;
            this.cboKho.SelectedIndex = -1;
            this.dtpNgay.Text = DateTime.Now.ToString();
            this.cboNhanvien.SelectedText = Program.mHoten;
            this.txtMaNV.Text = Program.username;
            this.vitri = this.phieuXuatBindingSource.Position;
            this.btnThemPX.Enabled = this.btnXoaPX.Enabled = this.btnTailaiPX.Enabled = false;
            this.btnGhiPX.Enabled = this.btnPhuchoiPX.Enabled = true;
            this.gvCTPX.Enabled = false;
        }

        private void btnXoaPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string phieuxuat = null;
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    phieuxuat = ((DataRowView)this.phieuXuatBindingSource[this.phieuXuatBindingSource.Position])["MAPX"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    this.phieuXuatBindingSource.RemoveCurrent();
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.QLVTDataSet.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.QLVTDataSet.PhieuXuat);
                    this.phieuXuatBindingSource.Position = this.phieuXuatBindingSource.Find("MAPX", phieuxuat);
                }
            }
            if (this.phieuXuatBindingSource.Count == 0) this.btnXoaPX.Enabled = false;
        }

        private void btnGhiPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMaPX.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu xuất không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaPX.Focus();
                return;
            }
            if (this.dtpNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày lập phiếu không được thiếu!", "", MessageBoxButtons.OK);
                this.dtpNgay.Focus();
                return;
            }
            if (this.txtHotenKH.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                this.txtHotenKH.Focus();
                return;
            }
            if (this.txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                this.cboNhanvien.Focus();
                return;
            }
            if (this.txtMakho.Text.Trim() == "")
            {
                MessageBox.Show("Kho không được thiếu!", "", MessageBoxButtons.OK);
                this.cboKho.Focus();
                return;
            }
            try
            {
                this.phieuXuatBindingSource.EndEdit();
                this.phieuXuatBindingSource.ResetCurrentItem();
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Update(this.QLVTDataSet.PhieuXuat);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAPX"))
                {
                    MessageBox.Show("Mã phiếu xuất bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi phiếu xuất.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            this.gcPhieuxuat.Enabled = true;
            btnThemPX.Enabled = btnXoaPX.Enabled = this.btnTailaiPX.Enabled = true;
            this.btnGhiPX.Enabled = this.btnPhuchoiPX.Enabled = false;
            this.phieuXuatBindingSource.Position = vitri;
            this.grbPhieuxuat.Enabled = false;
        }

        private void btnPhuchoiPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuXuatBindingSource.CancelEdit();
            this.gcPhieuxuat.Enabled = true;
            this.grbPhieuxuat.Enabled = false;
            this.btnThemPX.Enabled = this.btnXoaPX.Enabled = this.btnTailaiPX.Enabled = true;
            this.btnPhuchoiPX.Enabled = this.btnGhiPX.Enabled = false;
        }

        private void btnTailaiPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            this.gvCTPX.Enabled = false;
            this.grbCTPX.Enabled = true;
            this.btnGhiCTPX.Enabled = true;
            this.btnXoaCTPX.Enabled = false;
            this.cTPXBindingSource.AddNew();
            this.txtMaCTPX.Text = this.txtMaPX.Text;
            this.cboVattu.SelectedIndex = -1;
        }

        private void btnXoaCTPX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    this.cTPXBindingSource.RemoveCurrent();
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPXTableAdapter.Update(this.QLVTDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu xuất." + ex.Message, "",
                        MessageBoxButtons.OK);
                    return;
                }
            }

            if (this.cTPXBindingSource.Count == 0) this.btnXoaCTPX.Enabled = false;
        }

        private void btnGhiCTPX_Click(object sender, EventArgs e)
        {
            if (this.txtMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn vật tư!", "", MessageBoxButtons.OK);
                this.cboVattu.Focus();
                return;
            }

            if (int.Parse(this.txtSoluong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "", MessageBoxButtons.OK);
                this.txtSoluong.Focus();
                return;
            }

            if (int.Parse(this.txtDongia.Text) <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "", MessageBoxButtons.OK);
                this.txtDongia.Focus();
                return;
            }
            try
            {
                this.cTPXBindingSource.EndEdit();
                this.cTPXBindingSource.ResetCurrentItem();
                if (this.QLVTDataSet.HasChanges())
                {
                    this.cTPXTableAdapter.Update(this.QLVTDataSet.CTPX);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Bạn đã thêm chi tiết 2 lần trên 1 phiếu!");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi chi tiết phiếu xuất. Bạn kiểm tra lại thông tin  trứơc khi ghi \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            this.grbCTPX.Enabled = this.btnGhiCTPX.Enabled = false;
            this.btnXoaCTPX.Enabled = true;
        }
    }
}
