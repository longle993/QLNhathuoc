using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormThemMoiNCC : Form
    {
        public FormThemMoiNCC()
        {
            InitializeComponent();
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

        private void Luu(bool close)
        {
            if (txtTenNCC.Texts == "" || txtMST.Texts == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin bắt buộc", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã lưu!");
                if (close == true)
                {
                    this.Close();
                }
            }
        }
        private void btnDongNCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            Luu(true);
        }

        private void btnLuuThemncc_Click(object sender, EventArgs e)
        {
            Luu(false);
            ResetTextBoxes(this);
        }

    }
}
