using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG_PT
{
    public partial class frmDangky : DevExpress.XtraEditors.XtraForm
    {
        private int flag;
        public frmDangky()
        {
            InitializeComponent();
        }
        
        private void frmDangky_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.HoTenNV' table. You can move, or remove it, as needed.
            this.QLVTDataset.EnforceConstraints = false;
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoTenNVTableAdapter.Fill(this.QLVTDataset.HoTenNV);
            this.grbTaikhoan.Enabled = false;
            this.txtMaNV.Visible = false;
        }
        

        private void cboHoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboHoten.Text.Length == 0)
            {
                return;
            }

            this.txtMaNV.Text = this.cboHoten.SelectedValue.ToString();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (this.flag == 0)
            {
                if (this.txtTenDN.Text.Trim() == "" || this.txtMK.Text.Trim() == "")
                {
                    MessageBox.Show("Thông tin đăng nhập không được thiếu !");
                    return;
                }

                string sql = "SELECT NAME FROM SYS.SYSUSERS WHERE NAME = '" + this.cboHoten.SelectedValue + "'";
                int KT = Program.KTTT(sql);
                if (KT == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                else
                {
                    try
                    {
                        this.sP_TAOTAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_TAOTAIKHOANTableAdapter.Fill(
                            this.QLVTDataset.SP_TAOTAIKHOAN,
                            this.txtTenDN.Text,
                            this.txtMK.Text,
                            this.cboHoten.SelectedValue.ToString(),
                            this.cboNhom.Text);
                        MessageBox.Show("Tạo tài khoản thành công !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tạo tài khoản.\n" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (Program.username.Trim().Equals(this.cboHoten.SelectedValue.ToString()))
                {
                    MessageBox.Show("Người dùng đang sử dụng. Không thể xóa");
                }
                else
                {
                    try
                    {
                        this.xoa_LoginTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.xoa_LoginTableAdapter.Fill(this.QLVTDataset.Xoa_Login, this.txtTenDN.Text, this.cboHoten.SelectedValue.ToString());
                        MessageBox.Show("Xóa tài khoản thành công !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa tài khoản thất bại." + ex.Message + MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grbTaikhoan.Enabled = true;
            this.flag = 0;
            this.txtMK.Enabled = true;
            this.cboNhom.Enabled = true;
            if (Program.mGroup == "CongTy")
            {
                this.cboNhom.SelectedValue = "CongTy";
                this.cboNhom.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grbTaikhoan.Enabled = true;
            this.flag = 1;
            this.txtMK.Enabled = false;
            this.cboNhom.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}