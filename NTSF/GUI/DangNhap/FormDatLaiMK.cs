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
using NTSF.BUS;

namespace NTSF.GUI
{
    public partial class FormDatLaiMK : Form
    {
        private Form currentChildForm;
        string email;
        FormQuenMK formQuenMK;
        FormLoginBackgr formLoginBackgr;
        public FormDatLaiMK(FormQuenMK formQuenMK, FormLoginBackgr formLoginBackgr,string email)
        {
            InitializeComponent();
            this.email = email;
            this.formLoginBackgr = formLoginBackgr;
            this.formQuenMK = formQuenMK;
        }


        public FormDatLaiMK()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDatlaiMK.Controls.Add(childForm);
            panelDatlaiMK.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtcheckpass.Texts != txtnewpass.Texts)
            {
                lblPassCheck.Visible = true;
                return;
            }
            TAI_KHOAN_BUS.Instance.AddOrUpdate(email, ConvertToMD5(txtnewpass.Texts));
            MessageBox.Show("Thay đổi mật khẩu thành công!");
            this.formLoginBackgr.Hide();
            this.Close();
            this.formQuenMK.Hide();
            FormLoginBackgr formLoginBackgr1 = new FormLoginBackgr();
            formLoginBackgr1.ShowDialog();

            //formLoginBackgr.ShowDialog();

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
