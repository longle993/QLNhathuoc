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

namespace NTSF.GUI
{
    public partial class FormThemKH : Form
    {
        KHACH_HANG kh = new KHACH_HANG();
        public FormThemKH()
        {
            InitializeComponent();
        }
        private void ResetTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    ResetTextBox(c);
                }
            }
        }

        private void btnDongKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            ThemKH();
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        private void btnLuuThemKH_Click(object sender, EventArgs e)
        {
            ThemKH();
            MessageBox.Show("Đã lưu");
            ResetTextBox(this);
        }

        private void ThemKH()
        {
            kh.TEN_KH = txtTenKH.Texts;
            kh.GIOI_TINH = cbGioitinh.Text;
            kh.SDT = txtSDTKH.Texts;
            KHACH_HANG_BUS.Instance.AddUpdateKH(kh);
        }
    }
}
