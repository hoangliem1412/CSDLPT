using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG_PT
{
    public partial class frmDatHang : Form
    {
        int vitri = 0;
        string macn = "";
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            this.DatHangDataSet.EnforceConstraints = false;
            this.LoadData();
            this.cboChinhanh.DataSource = Program.bds_dspm;
            this.cboChinhanh.DisplayMember = "TENPM";
            this.cboChinhanh.ValueMember = "TENSERVER";
            this.cboChinhanh.SelectedIndex = Program.mChinhanh;
            
            if (Program.mGroup == "CongTy")
            {
                this.cboChinhanh.Enabled = true; // bật tắt theo phân quyền
                this.btnPhuchoiDDH.Enabled = this.btnThemDDH.Enabled = this.btnXoaDDH.Enabled = this.btnGhiDDH.Enabled = false;
                this.btnThemCTDDH.Enabled = this.btnXoaCTDDH.Enabled = this.btnGhiCTDDH.Enabled = false;
            }
            else this.cboChinhanh.Enabled = false;

            this.dtpNgay.Enabled = false;
            this.txtMaVT.Enabled = this.txtMakho.Enabled = this.txtMaNV.Enabled= this.cboNhanvien.Enabled = false;
            this.grbDDH.Enabled = this.grbCTDDH.Enabled = false;
            this.btnGhiCTDDH.Enabled = this.btnGhiDDH.Enabled = this.btnPhuchoiDDH.Enabled = this.txtMaDDH_CT.Enabled = false;
        }

        void LoadData()
        {
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoTenNVTableAdapter.Fill(this.DatHangDataSet.HoTenNV);
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DatHangDataSet.Kho);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DatHangDataSet.Vattu);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DatHangDataSet.CTDDH);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DatHangDataSet.DatHang);
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
                macn = ((DataRowView)this.datHangBindingSource[0])["MACN"].ToString();
            }
        }
        
        private void txtMaVT_EditValueChanged(object sender, EventArgs e)
        {
            //this.txtMaVT.Enabled = false;
        }
        

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboKho.Text.Length == 0)
            {
                return;
            }

            this.txtMakho.Text = this.cboKho.SelectedValue.ToString();
        }

        private void cboNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cboNhanvien.Text.Length == 0)
            //{
            //    return;
            //}

            //this.txtMaNV.Text = this.cboNhanvien.SelectedValue.ToString();
        }

        private void cboVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaVT.Text = this.cboVattu.SelectedValue.ToString();
            }
            catch (Exception exception)
            {
                this.txtMaVT.Text = "";
            }
        }

        private void btnThemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grbDDH.Enabled = true;
            this.gcDDH.Enabled = false;
            this.datHangBindingSource.AddNew();
            this.txtMaDDH.Focus();
            this.cboNhanvien.Text = "";
            this.cboKho.SelectedIndex = -1;
            this.dtpNgay.Text = DateTime.Now.ToString();
            this.cboNhanvien.SelectedText = Program.mHoten;
            this.txtMaNV.Text = Program.username;
            this.vitri = this.datHangBindingSource.Position;
            this.gvCTDDH.Enabled = false;
            this.btnThemDDH.Enabled = this.btnXoaDDH.Enabled = this.btnTailaiDDH.Enabled = false;
            this.btnGhiDDH.Enabled = this.btnPhuchoiDDH.Enabled = true;
        }

        private void btnXoaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ddh = null;
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn hàng này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    ddh = ((DataRowView)this.datHangBindingSource[this.datHangBindingSource.Position])["MasoDDH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    this.datHangBindingSource.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DatHangDataSet.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn hàng. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.DatHangDataSet.DatHang);
                    this.datHangBindingSource.Position = this.datHangBindingSource.Find("MasoDDH", ddh);
                }
            }

            if (this.datHangBindingSource.Count == 0) this.btnXoaDDH.Enabled = false;
        }

        private void btnGhiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMaDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaDDH.Focus();
                return;
            }
            if (this.dtpNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày đặt hàng không được thiếu!", "", MessageBoxButtons.OK);
                this.dtpNgay.Focus();
                return;
            }
            if (this.txtNhaCC.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp!", "", MessageBoxButtons.OK);
                this.txtNhaCC.Focus();
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
                this.datHangBindingSource.EndEdit();
                this.datHangBindingSource.ResetCurrentItem();
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Update(this.DatHangDataSet.DatHang);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MasoDDH"))
                {
                    MessageBox.Show("Mã đơn đặt hàng bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi đơn đặt hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            this.gcDDH.Enabled = true;
            this.btnThemDDH.Enabled = this.btnXoaDDH.Enabled = this.btnTailaiDDH.Enabled = true;
            this.btnGhiDDH.Enabled = this.btnPhuchoiDDH.Enabled = false;
            this.datHangBindingSource.Position = vitri;
            this.grbDDH.Enabled = false;
        }

        private void btnPhuchoiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.datHangBindingSource.CancelEdit();
            this.gcDDH.Enabled = true;
            this.grbDDH.Enabled = false;
            this.btnThemDDH.Enabled = this.btnXoaDDH.Enabled = this.btnTailaiDDH.Enabled = true;
            this.btnPhuchoiDDH.Enabled = this.btnGhiDDH.Enabled = false;
        }

        private void btnTailaiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        
        private void btnThemCTDDH_Click(object sender, EventArgs e)
        {
            this.gvCTDDH.Enabled = false;
            this.grbCTDDH.Enabled = true;
            this.btnGhiCTDDH.Enabled = true;
            this.btnXoaCTDDH.Enabled = false;
            this.cTDDHBindingSource.AddNew();
            this.txtMaDDH_CT.Text = this.txtMaDDH.Text;
            this.cboVattu.SelectedIndex = -1;
        }

        private void btnXoaCTDDH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn hàng này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    this.cTDDHBindingSource.RemoveCurrent();
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Update(this.DatHangDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn hàng." + ex.Message, "",
                        MessageBoxButtons.OK);
                    return;
                }
            }

            if (this.cTDDHBindingSource.Count == 0) this.btnXoaCTDDH.Enabled = false;
        }

        private void btnGhiCTDDH_Click(object sender, EventArgs e)
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
                this.cTDDHBindingSource.EndEdit();
                this.cTDDHBindingSource.ResetCurrentItem();
                if (this.DatHangDataSet.HasChanges())
                {
                    this.cTDDHTableAdapter.Update(this.DatHangDataSet.CTDDH);
                }
            }

            catch (Exception ex)
            {
                if(ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Bạn đã thêm chi tiết 2 lần trên 1 đơn đặt hàng");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi chi tiết đơn đặt hàng. Bạn kiểm tra lại thông tin  trứơc khi ghi \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            this.grbCTDDH.Enabled = this.btnGhiCTDDH.Enabled = false;
            this.btnXoaCTDDH.Enabled = true;
        }
    }
}
