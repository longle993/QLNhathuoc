
using System.Windows.Forms;

namespace NTSF.GUI
{
    partial class FormHoaDon
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

        public class DoubleBufferPanel : Panel

        {

            public DoubleBufferPanel()

            {

                // Set the value of the double-buffering style bits to true.

                this.DoubleBuffered = true;

                this.SetStyle(ControlStyles.AllPaintingInWmPaint |

                ControlStyles.UserPaint |

                ControlStyles.OptimizedDoubleBuffer, true);

                UpdateStyles();

            }

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemHoadon = new FontAwesome.Sharp.IconButton();
            this.ctDatePicker1 = new NTSF.CTuserControl.CTDatePicker();
            this.ctDatePicker3 = new NTSF.CTuserControl.CTDatePicker();
            this.txtTKHDHoadon = new HotelManagement.CTControls.CTTextBox();
            this.txtTKHHHoadon = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.advancedPanel1.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.advancedPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.ctDatePicker1);
            this.advancedPanel1.Controls.Add(this.ctDatePicker3);
            this.advancedPanel1.Controls.Add(this.txtTKHDHoadon);
            this.advancedPanel1.Controls.Add(this.txtTKHHHoadon);
            this.advancedPanel1.Controls.Add(this.label4);
            this.advancedPanel1.Controls.Add(this.label3);
            this.advancedPanel1.Controls.Add(this.label2);
            this.advancedPanel1.Controls.Add(this.label1);
            this.advancedPanel1.Controls.Add(this.label6);
            this.advancedPanel1.EdgeWidth = 0;
            this.advancedPanel1.EndColor = System.Drawing.Color.White;
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel1.Location = new System.Drawing.Point(41, 21);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 5;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 0;
            this.advancedPanel1.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(1654, 210);
            this.advancedPanel1.StartColor = System.Drawing.Color.White;
            this.advancedPanel1.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 0;
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemHoadon);
            this.advancedPanel2.EdgeWidth = 0;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Transparent;
            this.advancedPanel2.Location = new System.Drawing.Point(1485, 135);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 5;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 3;
            this.advancedPanel2.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(141, 40);
            this.advancedPanel2.StartColor = System.Drawing.Color.White;
            this.advancedPanel2.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 56;
            // 
            // btnTimKiemHoadon
            // 
            this.btnTimKiemHoadon.AutoSize = true;
            this.btnTimKiemHoadon.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemHoadon.FlatAppearance.BorderSize = 0;
            this.btnTimKiemHoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemHoadon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemHoadon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemHoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemHoadon.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemHoadon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemHoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemHoadon.IconSize = 30;
            this.btnTimKiemHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemHoadon.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiemHoadon.Name = "btnTimKiemHoadon";
            this.btnTimKiemHoadon.Size = new System.Drawing.Size(133, 36);
            this.btnTimKiemHoadon.TabIndex = 58;
            this.btnTimKiemHoadon.Text = "TÌM KIẾM";
            this.btnTimKiemHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemHoadon.UseVisualStyleBackColor = false;
            // 
            // ctDatePicker1
            // 
            this.ctDatePicker1.BackColor = System.Drawing.Color.White;
            this.ctDatePicker1.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctDatePicker1.BorderRadius = 15;
            this.ctDatePicker1.BorderSize = 0;
            this.ctDatePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDatePicker1.CustomFormat = "dd/MM/yyyy";
            this.ctDatePicker1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ctDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.ctDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDatePicker1.Location = new System.Drawing.Point(375, 135);
            this.ctDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.ctDatePicker1.Name = "ctDatePicker1";
            this.ctDatePicker1.Size = new System.Drawing.Size(258, 37);
            this.ctDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctDatePicker1.TabIndex = 55;
            this.ctDatePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // ctDatePicker3
            // 
            this.ctDatePicker3.BackColor = System.Drawing.Color.White;
            this.ctDatePicker3.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctDatePicker3.BorderRadius = 15;
            this.ctDatePicker3.BorderSize = 0;
            this.ctDatePicker3.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDatePicker3.CustomFormat = "dd/MM/yyyy";
            this.ctDatePicker3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ctDatePicker3.ForeColor = System.Drawing.Color.Black;
            this.ctDatePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDatePicker3.Location = new System.Drawing.Point(76, 135);
            this.ctDatePicker3.MinimumSize = new System.Drawing.Size(4, 35);
            this.ctDatePicker3.Name = "ctDatePicker3";
            this.ctDatePicker3.Size = new System.Drawing.Size(258, 37);
            this.ctDatePicker3.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctDatePicker3.TabIndex = 55;
            this.ctDatePicker3.TextColor = System.Drawing.Color.Black;
            // 
            // txtTKHDHoadon
            // 
            this.txtTKHDHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHDHoadon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHDHoadon.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTKHDHoadon.BorderRadius = 5;
            this.txtTKHDHoadon.BorderSize = 0;
            this.txtTKHDHoadon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtTKHDHoadon.IsFocused = false;
            this.txtTKHDHoadon.Location = new System.Drawing.Point(1124, 135);
            this.txtTKHDHoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKHDHoadon.Multiline = false;
            this.txtTKHDHoadon.Name = "txtTKHDHoadon";
            this.txtTKHDHoadon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKHDHoadon.PasswordChar = false;
            this.txtTKHDHoadon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTKHDHoadon.PlaceholderText = "Tìm kiếm theo mã, tên của hàng hoá";
            this.txtTKHDHoadon.ReadOnly = false;
            this.txtTKHDHoadon.Size = new System.Drawing.Size(333, 36);
            this.txtTKHDHoadon.TabIndex = 54;
            this.txtTKHDHoadon.Texts = "";
            this.txtTKHDHoadon.UnderlineedStyle = false;
            // 
            // txtTKHHHoadon
            // 
            this.txtTKHHHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHHHoadon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHHHoadon.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTKHHHoadon.BorderRadius = 5;
            this.txtTKHHHoadon.BorderSize = 0;
            this.txtTKHHHoadon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtTKHHHoadon.IsFocused = false;
            this.txtTKHHHoadon.Location = new System.Drawing.Point(672, 135);
            this.txtTKHHHoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKHHHoadon.Multiline = false;
            this.txtTKHHHoadon.Name = "txtTKHHHoadon";
            this.txtTKHHHoadon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKHHHoadon.PasswordChar = false;
            this.txtTKHHHoadon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTKHHHoadon.PlaceholderText = "Tìm kiếm theo mã, tên của hàng hoá";
            this.txtTKHHHoadon.ReadOnly = false;
            this.txtTKHHHoadon.Size = new System.Drawing.Size(413, 36);
            this.txtTKHHHoadon.TabIndex = 54;
            this.txtTKHHHoadon.Texts = "";
            this.txtTKHHHoadon.UnderlineedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1118, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 32);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tìm kiếm theo hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 32);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tìm kiếm theo hàng hoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "Từ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "HOÁ ĐƠN";
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.label8);
            this.advancedPanel5.Controls.Add(this.label7);
            this.advancedPanel5.Controls.Add(this.label5);
            this.advancedPanel5.EdgeWidth = 0;
            this.advancedPanel5.EndColor = System.Drawing.Color.White;
            this.advancedPanel5.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel5.Location = new System.Drawing.Point(41, 252);
            this.advancedPanel5.Name = "advancedPanel5";
            this.advancedPanel5.RectRadius = 5;
            this.advancedPanel5.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel5.ShadowShift = 5;
            this.advancedPanel5.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel5.Size = new System.Drawing.Size(1654, 693);
            this.advancedPanel5.StartColor = System.Drawing.Color.White;
            this.advancedPanel5.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel5.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(300, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 28);
            this.label8.TabIndex = 52;
            this.label8.Text = "xx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(282, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 28);
            this.label7.TabIndex = 52;
            this.label7.Text = "(       hoá đơn)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 28);
            this.label5.TabIndex = 52;
            this.label5.Text = "Danh sách hoá đơn";
            // 
            // FormHoaDon
            // 
            this.DoubleBuffered = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 985);
            this.Controls.Add(this.advancedPanel5);
            this.Controls.Add(this.advancedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private HotelManagement.CTControls.CTTextBox txtTKHHHoadon;
        private CTuserControl.CTDatePicker ctDatePicker1;
        private CTuserControl.CTDatePicker ctDatePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private HotelManagement.CTControls.CTTextBox txtTKHDHoadon;
        private System.Windows.Forms.Label label4;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemHoadon;
        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}