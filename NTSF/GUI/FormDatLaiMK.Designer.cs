
namespace NTSF.GUI
{
    partial class FormDatLaiMK
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
            this.panelDatlaiMK = new System.Windows.Forms.Panel();
            this.lblPassCheck = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacnhan = new NTSF.CTuserControl.CTButton();
            this.txtnewpass = new HotelManagement.CTControls.CTTextBox();
            this.txtcheckpass = new HotelManagement.CTControls.CTTextBox();
            this.panelDatlaiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatlaiMK
            // 
            this.panelDatlaiMK.Controls.Add(this.lblPassCheck);
            this.panelDatlaiMK.Controls.Add(this.btnXacnhan);
            this.panelDatlaiMK.Controls.Add(this.label4);
            this.panelDatlaiMK.Controls.Add(this.label20);
            this.panelDatlaiMK.Controls.Add(this.label2);
            this.panelDatlaiMK.Controls.Add(this.label1);
            this.panelDatlaiMK.Controls.Add(this.label3);
            this.panelDatlaiMK.Controls.Add(this.txtnewpass);
            this.panelDatlaiMK.Controls.Add(this.txtcheckpass);
            this.panelDatlaiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatlaiMK.Location = new System.Drawing.Point(0, 0);
            this.panelDatlaiMK.Name = "panelDatlaiMK";
            this.panelDatlaiMK.Size = new System.Drawing.Size(585, 624);
            this.panelDatlaiMK.TabIndex = 0;
            // 
            // lblPassCheck
            // 
            this.lblPassCheck.AutoSize = true;
            this.lblPassCheck.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassCheck.ForeColor = System.Drawing.Color.Red;
            this.lblPassCheck.Location = new System.Drawing.Point(198, 497);
            this.lblPassCheck.Name = "lblPassCheck";
            this.lblPassCheck.Size = new System.Drawing.Size(210, 21);
            this.lblPassCheck.TabIndex = 94;
            this.lblPassCheck.Text = "Mật khẩu không trùng khớp!";
            this.lblPassCheck.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(212, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(186, 209);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 25);
            this.label20.TabIndex = 91;
            this.label20.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 90;
            this.label2.Text = "KHỞI TẠO LẠI MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 89;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnXacnhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnXacnhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnXacnhan.BorderRadius = 5;
            this.btnXacnhan.BorderSize = 0;
            this.btnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacnhan.FlatAppearance.BorderSize = 0;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacnhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Location = new System.Drawing.Point(134, 521);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(324, 50);
            this.btnXacnhan.TabIndex = 93;
            this.btnXacnhan.Text = "Xác Nhận";
            this.btnXacnhan.TextColor = System.Drawing.Color.White;
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtnewpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtnewpass.BorderFocusColor = System.Drawing.Color.Black;
            this.txtnewpass.BorderRadius = 5;
            this.txtnewpass.BorderSize = 1;
            this.txtnewpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.IsFocused = false;
            this.txtnewpass.Location = new System.Drawing.Point(40, 243);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewpass.Multiline = false;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Padding = new System.Windows.Forms.Padding(10, 7, 33, 7);
            this.txtnewpass.PasswordChar = true;
            this.txtnewpass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnewpass.PlaceholderText = "";
            this.txtnewpass.ReadOnly = false;
            this.txtnewpass.Size = new System.Drawing.Size(504, 40);
            this.txtnewpass.TabIndex = 86;
            this.txtnewpass.Texts = "";
            this.txtnewpass.UnderlineedStyle = false;
            // 
            // txtcheckpass
            // 
            this.txtcheckpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtcheckpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtcheckpass.BorderFocusColor = System.Drawing.Color.Black;
            this.txtcheckpass.BorderRadius = 5;
            this.txtcheckpass.BorderSize = 1;
            this.txtcheckpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheckpass.IsFocused = false;
            this.txtcheckpass.Location = new System.Drawing.Point(40, 362);
            this.txtcheckpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtcheckpass.Multiline = false;
            this.txtcheckpass.Name = "txtcheckpass";
            this.txtcheckpass.Padding = new System.Windows.Forms.Padding(10, 7, 33, 7);
            this.txtcheckpass.PasswordChar = true;
            this.txtcheckpass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtcheckpass.PlaceholderText = "";
            this.txtcheckpass.ReadOnly = false;
            this.txtcheckpass.Size = new System.Drawing.Size(504, 40);
            this.txtcheckpass.TabIndex = 87;
            this.txtcheckpass.Texts = "";
            this.txtcheckpass.UnderlineedStyle = false;
            // 
            // FormDatLaiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 624);
            this.Controls.Add(this.panelDatlaiMK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatLaiMK";
            this.Text = "FormDatLaiMK";
            this.panelDatlaiMK.ResumeLayout(false);
            this.panelDatlaiMK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatlaiMK;
        private System.Windows.Forms.Label lblPassCheck;
        private CTuserControl.CTButton btnXacnhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private HotelManagement.CTControls.CTTextBox txtnewpass;
        private HotelManagement.CTControls.CTTextBox txtcheckpass;
    }
}