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
    public partial class FormTaoPhieu : Form
    {
        public FormTaoPhieu()
        {
            InitializeComponent();
            LoadTimeNow();
        }

        private void LoadTimeNow()
        {
            this.lblHour.Text = DateTime.Now.ToString("hh:mm");
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            FormThemHang formThemHang = new FormThemHang();
            formThemHang.ShowDialog();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

