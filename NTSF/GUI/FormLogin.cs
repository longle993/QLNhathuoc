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
    public partial class FormLogin : Form
    {
        private FormLoginBackgr formbackgr;
        public FormLogin(FormLoginBackgr formbackgr)
        {
            InitializeComponent();
            this.formbackgr = formbackgr;
        }


        private void ctButton1_Click(object sender, EventArgs e)
        {
            FormMain formmain = new FormMain();
            this.formbackgr.Hide();
            formmain.ShowDialog();
            this.formbackgr.Close();
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        }

        private void btnHidepass_Click(object sender, EventArgs e)
        {
            if (btnHidepass.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                btnHidepass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.PasswordChar = true;

            }
            else
            {
                btnHidepass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.PasswordChar = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormQuenMK form = new FormQuenMK();
            this.Hide();
            form.ShowDialog();
        }
    }
}
