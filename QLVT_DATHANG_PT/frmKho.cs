using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG_PT
{
    public partial class frmKho : Form
    {
        int vitri = 0;
        string macn = "";
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            this.QLVTDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.QLVTDataSet.Kho);

            macn = ((DataRowView)this.khoBindingSource[0])["MACN"].ToString();
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

            this.txtMaCN.Enabled = false;
            this.grbKho.Enabled = false;

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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.QLVTDataSet.Kho);
                macn = ((DataRowView)this.khoBindingSource[0])["MACN"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.khoBindingSource.Position;
            this.grbKho.Enabled = true;
            this.khoBindingSource.AddNew();
            this.gcKho.Enabled = false;
            this.txtMaCN.Text = macn;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = false;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = this.btnThoat.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makho = null;
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makho = ((DataRowView)this.khoBindingSource[this.khoBindingSource.Position])["MAKHO"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    this.khoBindingSource.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.QLVTDataSet.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.QLVTDataSet.Kho);
                    this.khoBindingSource.Position = this.khoBindingSource.Find("MAKHO", makho);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.khoBindingSource.Position;
            this.grbKho.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = true;
            this.gcKho.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMakho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMakho.Focus();
                return;
            }

            if (this.txtTenkho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được thiếu!", "", MessageBoxButtons.OK);
                this.txtTenkho.Focus();
                return;
            }

            if (this.txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được thiếu!", "", MessageBoxButtons.OK);
                this.txtDiachi.Focus();
                return;
            }

            if (this.txtMaCN.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaCN.Focus();
                return;
            }
            
            try
            {
                this.khoBindingSource.EndEdit();
                this.khoBindingSource.ResetCurrentItem();
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Update(this.QLVTDataSet.Kho);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAKHO"))
                {
                    MessageBox.Show("Mã kho bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            this.gcKho.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = false;

            this.grbKho.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khoBindingSource.CancelEdit();
            this.gcKho.Enabled = true;
            this.grbKho.Enabled = false;
            this.btnThem.Enabled = this.btnGhi.Enabled = this.btnXoa.Enabled = this.btnTailai.Enabled = true;
        }

        private void btnTailai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.QLVTDataSet.Kho);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
