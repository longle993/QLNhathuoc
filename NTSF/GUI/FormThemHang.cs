using System;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormThemHang : Form
    {
        public FormThemHang()
        {
            InitializeComponent();
        }

        private void btnDongThemHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Luu(bool close)
        {
            if (txtHanghoa.Texts == "" || txtQCDG.Texts == "" || txtSolo.Texts == "" || txtGiaban.Texts == "" || txtSLNhap.Texts == "" || txtDongia.Texts == "" || txtTongGiamgia.Texts == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã lưu!");
                if (close == true)
                this.Close();
            }
        }
        private void ResetTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    ResetTextBoxes(c);
                }
            }
        }

        private void btnLuuThemHang_Click(object sender, EventArgs e)
        {
            Luu(true);
        }

        private void btnLuuThemmoi_Click(object sender, EventArgs e)
        {
            Luu(false);
            ResetTextBoxes(this);
        }
    }
}
