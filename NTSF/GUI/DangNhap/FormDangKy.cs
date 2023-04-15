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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            lblThongbao.Hide();
        }

        private void btnTaotk_Click(object sender, EventArgs e)
        {
            foreach (Control textBox in Controls)
            {
                if (textBox.Text == "" && textBox is TextBox)
                {
                    lblThongbao.Show();
                }
            }
        }
    }
}
