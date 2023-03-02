
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNT = new HotelManagement.CTControls.CTTextBox();
            this.btnTaotk = new NTSF.CTuserControl.CTButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHỞI TẠO LẠI MẬT KHẨU";
            // 
            // txtTenNT
            // 
            this.txtTenNT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtTenNT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtTenNT.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTenNT.BorderRadius = 5;
            this.txtTenNT.BorderSize = 1;
            this.txtTenNT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNT.IsFocused = false;
            this.txtTenNT.Location = new System.Drawing.Point(42, 304);
            this.txtTenNT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNT.Multiline = false;
            this.txtTenNT.Name = "txtTenNT";
            this.txtTenNT.Padding = new System.Windows.Forms.Padding(10, 7, 33, 7);
            this.txtTenNT.PasswordChar = false;
            this.txtTenNT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNT.PlaceholderText = "Nhập Email của bạn tại đây";
            this.txtTenNT.ReadOnly = false;
            this.txtTenNT.Size = new System.Drawing.Size(504, 40);
            this.txtTenNT.TabIndex = 9;
            this.txtTenNT.Texts = "";
            this.txtTenNT.UnderlineedStyle = false;
            // 
            // btnTaotk
            // 
            this.btnTaotk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTaotk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTaotk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTaotk.BorderRadius = 5;
            this.btnTaotk.BorderSize = 0;
            this.btnTaotk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaotk.FlatAppearance.BorderSize = 0;
            this.btnTaotk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaotk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaotk.ForeColor = System.Drawing.Color.White;
            this.btnTaotk.Location = new System.Drawing.Point(42, 505);
            this.btnTaotk.Name = "btnTaotk";
            this.btnTaotk.Size = new System.Drawing.Size(504, 50);
            this.btnTaotk.TabIndex = 18;
            this.btnTaotk.Text = "Gửi OTP";
            this.btnTaotk.TextColor = System.Drawing.Color.White;
            this.btnTaotk.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(452, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nhập địa chỉ email đã được xác minh của tài khoản người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "của bạn và chúng tôi sẽ gửi cho bạn mã OTP để bạn đặt lại mật khẩu";
            // 
            // FormQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTaotk);
            this.Controls.Add(this.txtTenNT);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQuenMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HotelManagement.CTControls.CTTextBox txtTenNT;
        private CTuserControl.CTButton btnTaotk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}