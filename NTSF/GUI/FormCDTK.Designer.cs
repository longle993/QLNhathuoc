
namespace NTSF.GUI
{
    partial class FormCDTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picAvatar = new NTSF.CTuserControl.CTCirclePictureBox();
            this.txtMKCDTK = new NTSF.CTuserControl.TextboxLine();
            this.txtEmailCDTK = new NTSF.CTuserControl.TextboxLine();
            this.txtTenNT = new NTSF.CTuserControl.TextboxLine();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThaydoiCDTK = new NTSF.CTuserControl.CTButton();
            this.btnThaydoiLuu = new NTSF.CTuserControl.CTButton();
            this.btnThaydoiHuy = new NTSF.CTuserControl.CTButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên nhà thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 30);
            this.label5.TabIndex = 59;
            this.label5.Text = "Thông tin nhà thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(892, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "Avatar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(60, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(60, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 58;
            this.label6.Text = "Mật khẩu";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Silver;
            this.picAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAvatar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAvatar.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAvatar.BorderSize = 0;
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar.GradientAngle = 50F;
            this.picAvatar.Location = new System.Drawing.Point(382, 313);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(90, 90);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 62;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // txtMKCDTK
            // 
            this.txtMKCDTK.BackColor = System.Drawing.SystemColors.Window;
            this.txtMKCDTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMKCDTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMKCDTK.BorderSize = 1;
            this.txtMKCDTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCDTK.ForeColor = System.Drawing.Color.Black;
            this.txtMKCDTK.Location = new System.Drawing.Point(60, 626);
            this.txtMKCDTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKCDTK.Multiline = false;
            this.txtMKCDTK.Name = "txtMKCDTK";
            this.txtMKCDTK.Padding = new System.Windows.Forms.Padding(7);
            this.txtMKCDTK.Size = new System.Drawing.Size(497, 40);
            this.txtMKCDTK.TabIndex = 60;
            this.txtMKCDTK.Texts = "";
            this.txtMKCDTK.UnderlinedStyle = true;
            // 
            // txtEmailCDTK
            // 
            this.txtEmailCDTK.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmailCDTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmailCDTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmailCDTK.BorderSize = 1;
            this.txtEmailCDTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCDTK.ForeColor = System.Drawing.Color.Black;
            this.txtEmailCDTK.Location = new System.Drawing.Point(60, 507);
            this.txtEmailCDTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailCDTK.Multiline = false;
            this.txtEmailCDTK.Name = "txtEmailCDTK";
            this.txtEmailCDTK.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmailCDTK.Size = new System.Drawing.Size(497, 40);
            this.txtEmailCDTK.TabIndex = 60;
            this.txtEmailCDTK.Texts = "";
            this.txtEmailCDTK.UnderlinedStyle = true;
            // 
            // txtTenNT
            // 
            this.txtTenNT.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTenNT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenNT.BorderSize = 1;
            this.txtTenNT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNT.ForeColor = System.Drawing.Color.Black;
            this.txtTenNT.Location = new System.Drawing.Point(60, 216);
            this.txtTenNT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNT.Multiline = false;
            this.txtTenNT.Name = "txtTenNT";
            this.txtTenNT.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNT.Size = new System.Drawing.Size(497, 40);
            this.txtTenNT.TabIndex = 60;
            this.txtTenNT.Texts = "";
            this.txtTenNT.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(60, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Chấp nhận các tệp: PNG, JPG";
            // 
            // btnThaydoiCDTK
            // 
            this.btnThaydoiCDTK.BackColor = System.Drawing.Color.White;
            this.btnThaydoiCDTK.BackgroundColor = System.Drawing.Color.White;
            this.btnThaydoiCDTK.BorderColor = System.Drawing.Color.Silver;
            this.btnThaydoiCDTK.BorderRadius = 20;
            this.btnThaydoiCDTK.BorderSize = 1;
            this.btnThaydoiCDTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThaydoiCDTK.FlatAppearance.BorderSize = 0;
            this.btnThaydoiCDTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThaydoiCDTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThaydoiCDTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThaydoiCDTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThaydoiCDTK.ForeColor = System.Drawing.Color.DimGray;
            this.btnThaydoiCDTK.Location = new System.Drawing.Point(825, 200);
            this.btnThaydoiCDTK.Name = "btnThaydoiCDTK";
            this.btnThaydoiCDTK.Size = new System.Drawing.Size(127, 45);
            this.btnThaydoiCDTK.TabIndex = 63;
            this.btnThaydoiCDTK.Text = "Thay đổi";
            this.btnThaydoiCDTK.TextColor = System.Drawing.Color.DimGray;
            this.btnThaydoiCDTK.UseVisualStyleBackColor = false;
            this.btnThaydoiCDTK.Click += new System.EventHandler(this.btnThaydoiCDTK_Click);
            this.btnThaydoiCDTK.MouseLeave += new System.EventHandler(this.btnThaydoiCDTK_MouseLeave);
            this.btnThaydoiCDTK.MouseHover += new System.EventHandler(this.btnThaydoiCDTK_MouseHover);
            // 
            // btnThaydoiLuu
            // 
            this.btnThaydoiLuu.BackColor = System.Drawing.Color.White;
            this.btnThaydoiLuu.BackgroundColor = System.Drawing.Color.White;
            this.btnThaydoiLuu.BorderColor = System.Drawing.Color.Silver;
            this.btnThaydoiLuu.BorderRadius = 20;
            this.btnThaydoiLuu.BorderSize = 1;
            this.btnThaydoiLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThaydoiLuu.FlatAppearance.BorderSize = 0;
            this.btnThaydoiLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThaydoiLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThaydoiLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThaydoiLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThaydoiLuu.ForeColor = System.Drawing.Color.DimGray;
            this.btnThaydoiLuu.Location = new System.Drawing.Point(775, 274);
            this.btnThaydoiLuu.Name = "btnThaydoiLuu";
            this.btnThaydoiLuu.Size = new System.Drawing.Size(93, 45);
            this.btnThaydoiLuu.TabIndex = 63;
            this.btnThaydoiLuu.Text = "Lưu";
            this.btnThaydoiLuu.TextColor = System.Drawing.Color.DimGray;
            this.btnThaydoiLuu.UseVisualStyleBackColor = false;
            this.btnThaydoiLuu.Click += new System.EventHandler(this.btnThaydoiLuu_Click);
            this.btnThaydoiLuu.MouseLeave += new System.EventHandler(this.btnThaydoiLuu_MouseLeave);
            this.btnThaydoiLuu.MouseHover += new System.EventHandler(this.btnThaydoiLuu_MouseHover);
            // 
            // btnThaydoiHuy
            // 
            this.btnThaydoiHuy.BackColor = System.Drawing.Color.White;
            this.btnThaydoiHuy.BackgroundColor = System.Drawing.Color.White;
            this.btnThaydoiHuy.BorderColor = System.Drawing.Color.Silver;
            this.btnThaydoiHuy.BorderRadius = 20;
            this.btnThaydoiHuy.BorderSize = 1;
            this.btnThaydoiHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThaydoiHuy.FlatAppearance.BorderSize = 0;
            this.btnThaydoiHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThaydoiHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThaydoiHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThaydoiHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThaydoiHuy.ForeColor = System.Drawing.Color.DimGray;
            this.btnThaydoiHuy.Location = new System.Drawing.Point(915, 274);
            this.btnThaydoiHuy.Name = "btnThaydoiHuy";
            this.btnThaydoiHuy.Size = new System.Drawing.Size(93, 45);
            this.btnThaydoiHuy.TabIndex = 63;
            this.btnThaydoiHuy.Text = "Huỷ";
            this.btnThaydoiHuy.TextColor = System.Drawing.Color.DimGray;
            this.btnThaydoiHuy.UseVisualStyleBackColor = false;
            this.btnThaydoiHuy.Click += new System.EventHandler(this.btnThaydoiHuy_Click);
            this.btnThaydoiHuy.MouseLeave += new System.EventHandler(this.btnThaydoiHuy_MouseLeave);
            this.btnThaydoiHuy.MouseHover += new System.EventHandler(this.btnThaydoiHuy_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(61, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 21);
            this.label8.TabIndex = 58;
            this.label8.Text = "Kích thước tệp yêu cầu: 100x100";
            // 
            // FormCDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 900);
            this.Controls.Add(this.btnThaydoiHuy);
            this.Controls.Add(this.btnThaydoiLuu);
            this.Controls.Add(this.btnThaydoiCDTK);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.txtMKCDTK);
            this.Controls.Add(this.txtEmailCDTK);
            this.Controls.Add(this.txtTenNT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCDTK";
            this.Text = "CDTK";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTuserControl.TextboxLine txtTenNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private CTuserControl.TextboxLine txtEmailCDTK;
        private CTuserControl.TextboxLine txtMKCDTK;
        private CTuserControl.CTCirclePictureBox picAvatar;
        private System.Windows.Forms.Label label7;
        private CTuserControl.CTButton btnThaydoiCDTK;
        private CTuserControl.CTButton btnThaydoiLuu;
        private CTuserControl.CTButton btnThaydoiHuy;
        private System.Windows.Forms.Label label8;
    }
}