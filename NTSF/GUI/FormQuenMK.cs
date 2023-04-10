using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using NTSF.BUS;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormQuenMK : Form
    {
        private Form currentChildForm;
        string OTP ="XYZ";
        FormLoginBackgr formLoginBackgr;
        public FormQuenMK(FormLoginBackgr formLoginBackgr)
        {
            InitializeComponent();
            this.formLoginBackgr = formLoginBackgr;
        }

        private void btnKTOTP_Click(object sender, EventArgs e)
        {
            if (checkOTP())
            {
                OpenChildForm(new FormDatLaiMK(this,formLoginBackgr,txtMailSend.Texts));
                
            }
            else
            {
                lblError.Visible = true;
            }
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
            panelQuenMK.Controls.Add(childForm);
            panelQuenMK.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        public void LoadOTP()
        {

            MailMessage mail = new MailMessage("medicalpharmacy.se@gmail.com", txtMailSend.Texts);
            string pass;
            Random rd = new Random();
            this.OTP = rd.Next(10000, 99999).ToString();
            pass = "fijkjzmsopbnlgxx";
            mail.Subject = "Đặt lại mật khẩu từ ứng dụng Quản lý nhà thuốc";
            // mail.From = new MailAddress(from);
            mail.IsBodyHtml = true;
            mail.Body = "<div style=\"font-family: Helvetica,Arial,sans-serif;min-width:1000px;overflow:auto;line-height:2\">\r\n  <div style=\"margin:50px auto;width:70%;padding:20px 0\">\r\n    <div style=\"border-bottom:1px solid #eee\">\r\n      <a href=\"\" style=\"font-size:1.4em;color: #00466a;text-decoration:none;font-weight:600\">Medical Pharmacy Management</a>\r\n    </div>\r\n    <p style=\"font-size:1.1em\">Xin chào,</p>\r\n    <p>Đây là thư tự động gửi vào email. Vui lòng không trả lời thư này.<br> Dưới đây là mã OTP của bạn!</p>\r\n    <h2 style=\"background: #00466a;margin: 0 auto;width: max-content;padding: 0 10px;color: #fff;border-radius: 4px;\">" + OTP + "</h2>\r\n    <p style=\"font-size:0.9em;\">Xin cảm ơn,<br />Medical Pharmacy Management</p>\r\n    <hr style=\"border:none;border-top:1px solid #eee\" />\r\n    <div style=\"float:right;padding:8px 0;color:#aaa;font-size:0.8em;line-height:1;font-weight:300\">\r\n    </div>\r\n  </div>\r\n</div>";


            mail.To.Add(txtMailSend.Texts);
            // Cấu hình gửi
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("medicalpharmacy.se@gmail.com", pass);
            try
            {
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkOTP()
        {
            if (this.txtOTP.Texts == OTP)
            {
                return true;
            }
            return false;
        }

        private void btnCreateOTP_Click(object sender, EventArgs e)
        {
            if (TAI_KHOAN_BUS.Instance.checkEmail(txtMailSend.Texts) ==  null)
            {
                lblEmailCheck.Visible = true;
                return;
            }
            LoadOTP();
        }


    }
}
