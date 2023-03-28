
namespace NTSF.GUI
{
    partial class FormDMNCC
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
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataNCC = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masothue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.advancedPanel3 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnThemmoiNCC = new FontAwesome.Sharp.IconButton();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemNCC = new FontAwesome.Sharp.IconButton();
            this.txtSearchNCC = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNCC)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.advancedPanel3.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataNCC);
            this.advancedPanel5.Controls.Add(this.label8);
            this.advancedPanel5.Controls.Add(this.label7);
            this.advancedPanel5.Controls.Add(this.label9);
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
            this.advancedPanel5.TabIndex = 10;
            // 
            // dataNCC
            // 
            this.dataNCC.AllowUserToResizeColumns = false;
            this.dataNCC.AllowUserToResizeRows = false;
            this.dataNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.masothue,
            this.sdt,
            this.ghichu});
            this.dataNCC.Location = new System.Drawing.Point(33, 76);
            this.dataNCC.Name = "dataNCC";
            this.dataNCC.RowHeadersVisible = false;
            this.dataNCC.RowHeadersWidth = 62;
            this.dataNCC.RowTemplate.Height = 28;
            this.dataNCC.Size = new System.Drawing.Size(1559, 499);
            this.dataNCC.TabIndex = 53;
            // 
            // mancc
            // 
            this.mancc.HeaderText = "Mã Nhà Cung Cấp";
            this.mancc.MinimumWidth = 8;
            this.mancc.Name = "mancc";
            this.mancc.Width = 250;
            // 
            // tenncc
            // 
            this.tenncc.HeaderText = "Tên Nhà Cung Cấp";
            this.tenncc.MinimumWidth = 8;
            this.tenncc.Name = "tenncc";
            this.tenncc.Width = 516;
            // 
            // masothue
            // 
            this.masothue.HeaderText = "Mã Số Thuế";
            this.masothue.MinimumWidth = 8;
            this.masothue.Name = "masothue";
            this.masothue.Width = 280;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.Width = 250;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 260;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(378, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 30);
            this.label8.TabIndex = 52;
            this.label8.Text = "xx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(360, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "(       đơn vị)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(79, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 30);
            this.label9.TabIndex = 52;
            this.label9.Text = "Danh sách nhà cung cấp";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.iconPictureBox2);
            this.advancedPanel1.Controls.Add(this.label10);
            this.advancedPanel1.Controls.Add(this.advancedPanel3);
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.txtSearchNCC);
            this.advancedPanel1.Controls.Add(this.label4);
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
            this.advancedPanel1.TabIndex = 9;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(225, 31);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(35, 29);
            this.iconPictureBox2.TabIndex = 64;
            this.iconPictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(251, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 38);
            this.label10.TabIndex = 63;
            this.label10.Text = "NHÀ CUNG CẤP";
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackColor = System.Drawing.Color.White;
            this.advancedPanel3.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.btnThemmoiNCC);
            this.advancedPanel3.EdgeWidth = 2;
            this.advancedPanel3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(111)))), ((int)(((byte)(69)))));
            this.advancedPanel3.Location = new System.Drawing.Point(1444, 79);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 5;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 0;
            this.advancedPanel3.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel3.Size = new System.Drawing.Size(164, 43);
            this.advancedPanel3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.advancedPanel3.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 60;
            // 
            // btnThemmoiNCC
            // 
            this.btnThemmoiNCC.AutoSize = true;
            this.btnThemmoiNCC.BackColor = System.Drawing.Color.Transparent;
            this.btnThemmoiNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemmoiNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemmoiNCC.FlatAppearance.BorderSize = 0;
            this.btnThemmoiNCC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnThemmoiNCC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnThemmoiNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemmoiNCC.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnThemmoiNCC.ForeColor = System.Drawing.Color.White;
            this.btnThemmoiNCC.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnThemmoiNCC.IconColor = System.Drawing.Color.White;
            this.btnThemmoiNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemmoiNCC.IconSize = 30;
            this.btnThemmoiNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoiNCC.Location = new System.Drawing.Point(0, 0);
            this.btnThemmoiNCC.Name = "btnThemmoiNCC";
            this.btnThemmoiNCC.Size = new System.Drawing.Size(164, 43);
            this.btnThemmoiNCC.TabIndex = 64;
            this.btnThemmoiNCC.Text = "THÊM MỚI (F2)";
            this.btnThemmoiNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemmoiNCC.UseVisualStyleBackColor = false;
            this.btnThemmoiNCC.Click += new System.EventHandler(this.btnThemmoiNCC_Click);
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemNCC);
            this.advancedPanel2.EdgeWidth = 2;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel2.Location = new System.Drawing.Point(1444, 135);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 5;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 0;
            this.advancedPanel2.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel2.Size = new System.Drawing.Size(164, 43);
            this.advancedPanel2.StartColor = System.Drawing.Color.White;
            this.advancedPanel2.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 56;
            // 
            // btnTimKiemNCC
            // 
            this.btnTimKiemNCC.AutoSize = true;
            this.btnTimKiemNCC.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemNCC.FlatAppearance.BorderSize = 0;
            this.btnTimKiemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNCC.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemNCC.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemNCC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemNCC.IconSize = 30;
            this.btnTimKiemNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemNCC.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiemNCC.Name = "btnTimKiemNCC";
            this.btnTimKiemNCC.Size = new System.Drawing.Size(164, 43);
            this.btnTimKiemNCC.TabIndex = 63;
            this.btnTimKiemNCC.Text = "      TÌM KIẾM";
            this.btnTimKiemNCC.UseVisualStyleBackColor = false;
            // 
            // txtSearchNCC
            // 
            this.txtSearchNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchNCC.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearchNCC.BorderRadius = 5;
            this.txtSearchNCC.BorderSize = 1;
            this.txtSearchNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchNCC.IsFocused = false;
            this.txtSearchNCC.Location = new System.Drawing.Point(84, 135);
            this.txtSearchNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchNCC.Multiline = false;
            this.txtSearchNCC.Name = "txtSearchNCC";
            this.txtSearchNCC.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchNCC.PasswordChar = false;
            this.txtSearchNCC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchNCC.PlaceholderText = "Tìm kiếm theo mã, tên của hàng hoá";
            this.txtSearchNCC.ReadOnly = false;
            this.txtSearchNCC.Size = new System.Drawing.Size(1326, 43);
            this.txtSearchNCC.TabIndex = 54;
            this.txtSearchNCC.Texts = "";
            this.txtSearchNCC.UnderlineedStyle = false;
            this.txtSearchNCC._TextChanged += new System.EventHandler(this.txtSearchNCC__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(80, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tìm kiếm theo hàng hoá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "DANH MỤC";
            // 
            // FormDMNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1722, 929);
            this.Controls.Add(this.advancedPanel5);
            this.Controls.Add(this.advancedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDMNCC";
            this.Text = "FormDMNCC";
            this.Load += new System.EventHandler(this.FormDMNCC_Load);
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNCC)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemNCC;
        private HotelManagement.CTControls.CTTextBox txtSearchNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private CTuserControl.AdvancedPanel advancedPanel3;
        private FontAwesome.Sharp.IconButton btnThemmoiNCC;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn masothue;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}