using System;
using System.Windows.Forms;
using System.Data;

namespace QLVT_DATHANG_PT
{

    public partial class Phieunhap : Form
    {
        private int vitri = 0;
        string macn = "";
        public Phieunhap()
        {
            InitializeComponent();
        }

        private void Phieunhap_Load(object sender, EventArgs e)
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
                this.btnPhuchoiPN.Enabled = this.btnThemPN.Enabled = this.btnXoaPN.Enabled = this.btnGhiPN.Enabled = false;
                this.btnThemCTPN.Enabled = this.btnXoaCTPN.Enabled = this.btnGhiCTPN.Enabled = false;
            }
            else this.cboChinhanh.Enabled = false;

            this.dtpNgay.Enabled = this.cboNhanvien.Enabled = false;
            this.txtMaVT.Enabled = this.txtMakho.Enabled = this.txtMaNV.Enabled=  false;
            this.grbPhieunhap.Enabled = this.grbCTPN.Enabled = false;
            this.btnGhiCTPN.Enabled = this.btnGhiPN.Enabled = this.btnPhuchoiPN.Enabled = this.txtMaCTPN.Enabled = false;

        }
        private void LoadData()
        {
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.QLVTDataSet.CTPN);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVTDataSet.Vattu);
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.QLVTDataSet.Kho);
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoTenNVTableAdapter.Fill(this.QLVTDataSet.HoTenNV);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.QLVTDataSet.DatHang);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.QLVTDataSet.PhieuNhap);
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
                LoadData();
                macn = ((DataRowView)this.phieuNhapBindingSource[0])["MACN"].ToString();
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

        private void btnThemPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grbPhieunhap.Enabled = true;
            this.gcPhieunhap.Enabled = false;
            this.phieuNhapBindingSource.AddNew();
            this.txtMaPN.Focus();
            this.cboNhanvien.Text = "";
            this.cboKho.SelectedIndex = -1;
            this.dtpNgay.Text = DateTime.Now.ToString();
            this.cboNhanvien.SelectedText = Program.mHoten;
            this.txtMaNV.Text = Program.username;
            this.vitri = this.phieuNhapBindingSource.Position;
            this.gvCTPN.Enabled = false;
            this.btnThemPN.Enabled = this.btnXoaPN.Enabled = this.btnTailaiPN.Enabled = false;
            this.btnGhiPN.Enabled = this.btnPhuchoiPN.Enabled = true;
        }

        private void btnXoaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string phieunhap = null;
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    phieunhap = ((DataRowView)this.phieuNhapBindingSource[this.phieuNhapBindingSource.Position])["MAPN"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    this.phieuNhapBindingSource.RemoveCurrent();
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.QLVTDataSet.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Fill(this.QLVTDataSet.PhieuNhap);
                    this.phieuNhapBindingSource.Position = this.phieuNhapBindingSource.Find("MAPN", phieunhap);
                }
            }

            if (this.phieuNhapBindingSource.Count == 0) this.btnXoaPN.Enabled = false;
        }

        private void btnGhiPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaPN.Focus();
                return;
            }
            if (this.dtpNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày nhập phiếu không được thiếu!", "", MessageBoxButtons.OK);
                this.dtpNgay.Focus();
                return;
            }
            if (this.cboMaDDH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn đặt hàng!", "", MessageBoxButtons.OK);
                this.cboMaDDH.Focus();
                return;
            }
            if (this.txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "", MessageBoxButtons.OK);
                this.cboNhanvien.Focus();
                return;
            }
            if (this.txtMakho.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn kho!", "", MessageBoxButtons.OK);
                this.cboKho.Focus();
                return;
            }

            try
            {
                this.phieuNhapBindingSource.EndEdit();
                this.phieuNhapBindingSource.ResetCurrentItem();
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Update(this.QLVTDataSet.PhieuNhap);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAPN"))
                {
                    MessageBox.Show("Mã phiếu nhập bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi phiếu nhập.\n" + ex.Message, "", MessageBoxButtons.OK);
                }
                return;
            }
            this.gcPhieunhap.Enabled = true;
            this.btnThemPN.Enabled = this.btnXoaPN.Enabled = this.btnTailaiPN.Enabled = true;
            this.btnGhiPN.Enabled = this.btnPhuchoiPN.Enabled = false;
            this.phieuNhapBindingSource.Position = vitri;
            this.grbPhieunhap.Enabled = false;
        }

        private void btnPhuchoiPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuNhapBindingSource.CancelEdit();
            this.gcPhieunhap.Enabled = true;
            this.grbPhieunhap.Enabled = false;
            this.btnThemPN.Enabled = this.btnXoaPN.Enabled = this.btnTailaiPN.Enabled = true;
            this.btnPhuchoiPN.Enabled = this.btnGhiPN.Enabled = false;
        }

        private void btnTailaiPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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


        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            this.gvCTPN.Enabled = false;
            this.grbCTPN.Enabled = true;
            this.btnGhiCTPN.Enabled = true;
            this.btnXoaPN.Enabled = false;
            this.cTPNBindingSource.AddNew();
            this.txtMaCTPN.Text = this.txtMaPN.Text;
            this.cboVattu.SelectedIndex = -1;
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    this.cTPNBindingSource.RemoveCurrent();
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPNTableAdapter.Update(this.QLVTDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu nhập." + ex.Message, "",
                        MessageBoxButtons.OK);
                    return;
                }
            }

            if (this.cTPNBindingSource.Count == 0) this.btnXoaCTPN.Enabled = false;
        }

        private void btnGhiCTPN_Click(object sender, EventArgs e)
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
                this.cTPNBindingSource.EndEdit();
                this.cTPNBindingSource.ResetCurrentItem();
                if (this.QLVTDataSet.HasChanges())
                {
                    this.cTPNTableAdapter.Update(this.QLVTDataSet.CTPN);
                }
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Bạn đã ghi chi tiết 2 lần trên 1 phiếu nhập");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi chi tiết phiếu nhập. Bạn kiểm tra lại thông tin  trứơc khi ghi \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            this.grbCTPN.Enabled = this.btnGhiCTPN.Enabled = false;
            this.btnXoaCTPN.Enabled = true;
        }
    }
}
