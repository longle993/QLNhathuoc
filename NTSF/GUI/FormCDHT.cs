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
    public partial class FormCDHT : Form
    {
        public FormCDHT()
        {
            InitializeComponent();
            btnThaydoiHuyCDHT.Hide();
            btnThaydoiLuuCDHT.Hide();
        }



        private void Inmouse(CTuserControl.CTButton buttonhere )
        {

            buttonhere.BorderColor = Color.FromArgb(170, 139, 86);
            buttonhere.ForeColor = Color.FromArgb(170, 139, 86);
            buttonhere.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Outmouse(CTuserControl.CTButton buttonhere)
        {
            buttonhere.BorderColor = Color.Silver;
            buttonhere.ForeColor = Color.DimGray;
            buttonhere.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnThaydoiLuuCDHT_Click(object sender, EventArgs e)
        {
            btnThaydoiHuyCDHT.Hide();
            btnThaydoiLuuCDHT.Hide();
            btnThaydoiCDHT.Show();

        }

        private void btnThaydoiHuyCDHT_Click(object sender, EventArgs e)
        {
            btnThaydoiHuyCDHT.Hide();
            btnThaydoiLuuCDHT.Hide();
            btnThaydoiCDHT.Show();

        }

        private void btnThaydoiCDHT_Click(object sender, EventArgs e)
        {
            btnThaydoiHuyCDHT.Show();
            btnThaydoiLuuCDHT.Show();
            btnThaydoiCDHT.Hide();
        }

        private void btnThaydoiCDHT_MouseHover(object sender, EventArgs e)
        {
            Inmouse(btnThaydoiCDHT);
        }

        private void btnThaydoiCDHT_MouseLeave(object sender, EventArgs e)
        {
            Outmouse(btnThaydoiCDHT);
        }

        private void btnThaydoiLuuCDHT_MouseHover(object sender, EventArgs e)
        {
            Inmouse(btnThaydoiLuuCDHT);
        }

        private void btnThaydoiLuuCDHT_MouseLeave(object sender, EventArgs e)
        {
            Outmouse(btnThaydoiLuuCDHT);
        }

        private void btnThaydoiHuyCDHT_MouseHover(object sender, EventArgs e)
        {
            Inmouse(btnThaydoiHuyCDHT);
        }

        private void btnThaydoiHuyCDHT_MouseLeave(object sender, EventArgs e)
        {
            Outmouse(btnThaydoiHuyCDHT);
        }
    }
}
