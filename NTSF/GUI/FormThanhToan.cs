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
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
            LoadTimeNow();
        }

        private void LoadTimeNow()
        {
            this.lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lblHour.Text = DateTime.Now.ToString("hh:mm");

        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                
            }
        }

        private void btnThanhtoanIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {

            }
        }
    }
}
