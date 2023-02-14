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


        private void btnDongNCC_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu!");
        }
    }
}
