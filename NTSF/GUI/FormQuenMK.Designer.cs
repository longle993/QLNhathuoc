
namespace NTSF.GUI
{
    partial class FormQuenMK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelQuenMK = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateOTP = new NTSF.CTuserControl.CTButton();
            this.btnKTOTP = new NTSF.CTuserControl.CTButton();
            this.txtOTP = new HotelManagement.CTControls.CTTextBox();
            this.txtMailSend = new HotelManagement.CTControls.CTTextBox();
            this.lblEmailCheck = new System.Windows.Forms.Label();
            this.panelQuenMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuenMK
            // 
            this.panelQuenMK.Controls.Add(this.label2);
            this.panelQuenMK.Controls.Add(this.lblEmailCheck);
            this.panelQuenMK.Controls.Add(this.lblError);
            this.panelQuenMK.Controls.Add(this.label3);
            this.panelQuenMK.Controls.Add(this.label9);
            this.panelQuenMK.Controls.Add(this.btnCreateOTP);
            this.panelQuenMK.Controls.Add(this.btnKTOTP);
            this.panelQuenMK.Controls.Add(this.txtOTP);
            this.panelQuenMK.Controls.Add(this.txtMailSend);
            this.panelQuenMK.Controls.Add(this.label1);
            this.panelQuenMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuenMK.Location = new System.Drawing.Point(0, 0);
            this.panelQuenMK.Name = "panelQuenMK";
            this.panelQuenMK.Size = new System.Drawing.Size(585, 624);
            this.panelQuenMK.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "của bạn và chúng tôi sẽ gửi cho bạn mã xác nhận để bạn đặt lại mật khẩu";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(39, 412);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(170, 21);
            this.lblError.TabIndex = 26;
            this.lblError.Text = "Mã OTP không hợp lệ!!";
            this.lblError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nhập mã xác nhận";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(452, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nhập địa chỉ email đã được xác minh của tài khoản người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUÊN MẬT KHẨU";
            // 
            // btnCreateOTP
            // 
            this.btnCreateOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnCreateOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnCreateOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnCreateOTP.BorderRadius = 5;
            this.btnCreateOTP.BorderSize = 0;
            this.btnCreateOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOTP.FlatAppearance.BorderSize = 0;
            this.btnCreateOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOTP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCreateOTP.ForeColor = System.Drawing.Color.White;
            this.btnCreateOTP.Location = new System.Drawing.Point(432, 268);
            this.btnCreateOTP.Name = "btnCreateOTP";
            this.btnCreateOTP.Size = new System.Drawing.Size(107, 40);
            this.btnCreateOTP.TabIndex = 23;
            this.btnCreateOTP.Text = "Gửi Mã";
            this.btnCreateOTP.TextColor = System.Drawing.Color.White;
            this.btnCreateOTP.UseVisualStyleBackColor = false;
            this.btnCreateOTP.Click += new System.EventHandler(this.btnCreateOTP_Click);
            // 
            // btnKTOTP
            // 
            this.btnKTOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnKTOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnKTOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnKTOTP.BorderRadius = 5;
            this.btnKTOTP.BorderSize = 0;
            this.btnKTOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKTOTP.FlatAppearance.BorderSize = 0;
            this.btnKTOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKTOTP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKTOTP.ForeColor = System.Drawing.Color.White;
            this.btnKTOTP.Location = new System.Drawing.Point(35, 469);
            this.btnKTOTP.Name = "btnKTOTP";
            this.btnKTOTP.Size = new System.Drawing.Size(504, 50);
            this.btnKTOTP.TabIndex = 24;
            this.btnKTOTP.Text = "Xác Nhận";
            this.btnKTOTP.TextColor = System.Drawing.Color.White;
            this.btnKTOTP.UseVisualStyleBackColor = false;
            this.btnKTOTP.Click += new System.EventHandler(this.btnKTOTP_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtOTP.BorderFocusColor = System.Drawing.Color.Black;
            this.txtOTP.BorderRadius = 5;
            this.txtOTP.BorderSize = 1;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.IsFocused = false;
            this.txtOTP.Location = new System.Drawing.Point(35, 368);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTP.Multiline = false;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Padding = new System.Windows.Forms.Padding(10, 7, 33, 7);
            this.txtOTP.PasswordChar = false;
            this.txtOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOTP.PlaceholderText = "";
            this.txtOTP.ReadOnly = false;
            this.txtOTP.Size = new System.Drawing.Size(504, 40);
            this.txtOTP.TabIndex = 21;
            this.txtOTP.Texts = "";
            this.txtOTP.UnderlineedStyle = false;
            // 
            // txtMailSend
            // 
            this.txtMailSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtMailSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtMailSend.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMailSend.BorderRadius = 5;
            this.txtMailSend.BorderSize = 1;
            this.txtMailSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailSend.IsFocused = false;
            this.txtMailSend.Location = new System.Drawing.Point(35, 268);
            this.txtMailSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailSend.Multiline = false;
            this.txtMailSend.Name = "txtMailSend";
            this.txtMailSend.Padding = new System.Windows.Forms.Padding(10, 7, 33, 7);
            this.txtMailSend.PasswordChar = false;
            this.txtMailSend.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMailSend.PlaceholderText = "Nhập Email của bạn tại đây";
            this.txtMailSend.ReadOnly = false;
            this.txtMailSend.Size = new System.Drawing.Size(504, 40);
            this.txtMailSend.TabIndex = 22;
            this.txtMailSend.Texts = "";
            this.txtMailSend.UnderlineedStyle = false;
            // 
            // lblEmailCheck
            // 
            this.lblEmailCheck.AutoSize = true;
            this.lblEmailCheck.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCheck.ForeColor = System.Drawing.Color.Red;
            this.lblEmailCheck.Location = new System.Drawing.Point(39, 312);
            this.lblEmailCheck.Name = "lblEmailCheck";
            this.lblEmailCheck.Size = new System.Drawing.Size(151, 21);
            this.lblEmailCheck.TabIndex = 26;
            this.lblEmailCheck.Text = "Email không tồn tại!";
            this.lblEmailCheck.Visible = false;
            // 
            // FormQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 624);
            this.Controls.Add(this.panelQuenMK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQuenMK";
            this.panelQuenMK.ResumeLayout(false);
            this.panelQuenMK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuenMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private CTuserControl.CTButton btnCreateOTP;
        private CTuserControl.CTButton btnKTOTP;
        private HotelManagement.CTControls.CTTextBox txtOTP;
        private HotelManagement.CTControls.CTTextBox txtMailSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblEmailCheck;
    }
}