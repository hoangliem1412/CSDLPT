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
    public partial class frmVattu : Form
    {
        int vitri = 0;
        public frmVattu()
        {
            InitializeComponent();
        }

        private void frmVattu_Load(object sender, EventArgs e)
        {
            this.QLVTDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVTDataSet.Vattu);

            this.grbVattu.Enabled = false;
            this.btnGhi.Enabled = this.btnPhuchoi.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.vattuBindingSource.Position;
            this.grbVattu.Enabled = true;
            this.vattuBindingSource.AddNew();
            this.gcVattu.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = false;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = this.btnThoat.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = null;
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mavt = ((DataRowView)this.vattuBindingSource[this.vattuBindingSource.Position])["MAVT"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    this.vattuBindingSource.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.QLVTDataSet.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.QLVTDataSet.Vattu);
                    this.vattuBindingSource.Position = this.vattuBindingSource.Find("MAVT", mavt);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.vattuBindingSource.Position;
            this.grbVattu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = true;
            this.gcVattu.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu!", "", MessageBoxButtons.OK);
                this.txtMaVT.Focus();
                return;
            }

            if (this.txtTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được thiếu!", "", MessageBoxButtons.OK);
                this.txtTenVT.Focus();
                return;
            }

            if (this.txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được thiếu!", "", MessageBoxButtons.OK);
                this.txtDVT.Focus();
                return;
            }

            if (this.txtSLTon.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được thiếu!", "", MessageBoxButtons.OK);
                this.txtSLTon.Focus();
                return;
            }

            if (Int32.Parse(this.txtSLTon.Text) < 0)
            {
                MessageBox.Show("Số lượng tồn phải lớn hơn hoặc bằng 0!", "", MessageBoxButtons.OK);
                this.txtSLTon.Focus();
                return;
            }

            try
            {
                this.vattuBindingSource.EndEdit();
                this.vattuBindingSource.ResetCurrentItem();
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.QLVTDataSet.Vattu);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAVT"))
                {
                    MessageBox.Show("Mã vật tư bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi vật tư.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            this.gcVattu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = this.btnTailai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = this.btnPhuchoi.Enabled = false;

            this.grbVattu.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuBindingSource.CancelEdit();
            this.gcVattu.Enabled = true;
            this.grbVattu.Enabled = false;
            this.btnThem.Enabled = this.btnGhi.Enabled = this.btnXoa.Enabled = this.btnTailai.Enabled = true;
        }

        private void btnTailai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.QLVTDataSet.Vattu);

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
