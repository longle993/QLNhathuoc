using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTSF.DTO;
using NTSF.BUS;

namespace NTSF.GUI.KhachHang
{
    public partial class FormSuaKH : Form
    {
        KHACH_HANG khachhang = new KHACH_HANG();
        public FormSuaKH()
        {
            InitializeComponent();
        }

        public FormSuaKH(KHACH_HANG kh)
        {
            this.DoubleBuffered = true;
            this.khachhang = kh;
            InitializeComponent();

        }

        private void FormSuaKH_Load(object sender, EventArgs e)
        {

            this.lblSDT.Text = khachhang.SDT;
            this.txtTenKH.Texts = khachhang.TEN_KH;
            this.cbGioitinh.Text = khachhang.GIOI_TINH;
        }

        private void lblSDT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không được thay đổi số điện thoại!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnDongKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            ThemKH();
            MessageBox.Show("Đã lưu!");
            this.Close();
        }

        private void ThemKH()
        {
            this.khachhang.TEN_KH = txtTenKH.Texts;
            this.khachhang.SDT = lblSDT.Text;
            this.khachhang.GIOI_TINH = cbGioitinh.Text;
            KHACH_HANG_BUS.Instance.AddUpdateKH(this.khachhang);
        }

        private void txtTenKH__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
