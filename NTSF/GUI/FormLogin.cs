using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTSF.DTO;
using NTSF.BUS;

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
            string encodedPass = this.ConvertToMD5(this.txtPassword.Texts);
            if (TAI_KHOAN_BUS.Instance.checkTaiKhoan(txtEmail.Texts, encodedPass)==null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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

        private string ConvertToMD5(string s)
        {
            StringBuilder sb = new StringBuilder();

            // Initialize a MD5 hash object
            using (MD5 md5 = MD5.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = md5.ComputeHash(Encoding.UTF8.GetBytes(s));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    sb.Append($"{b:X2}");
                }
            }

            return sb.ToString();
        }
    }
}
