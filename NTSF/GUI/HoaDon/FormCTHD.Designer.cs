
namespace NTSF.GUI.HoaDon
{
    partial class FormCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataCTHD = new System.Windows.Forms.DataGridView();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.advancedPanel14 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnDongCTHD = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhutban = new HotelManagement.CTControls.CTTextBox();
            this.txtGioban = new HotelManagement.CTControls.CTTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new HotelManagement.CTControls.CTTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenKH = new HotelManagement.CTControls.CTTextBox();
            this.ctDateHD = new NTSF.CTuserControl.CTDatePicker();
            this.advancedPanel13 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnLuuKH = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).BeginInit();
            this.advancedPanel14.SuspendLayout();
            this.advancedPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 30);
            this.label3.TabIndex = 107;
            this.label3.Text = "CHI TIẾT HOÁ ĐƠN     #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1081, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataCTHD
            // 
            this.dataCTHD.AllowUserToAddRows = false;
            this.dataCTHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanpham,
            this.dvt,
            this.soluong,
            this.chietkhau});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCTHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataCTHD.GridColor = System.Drawing.Color.Silver;
            this.dataCTHD.Location = new System.Drawing.Point(33, 245);
            this.dataCTHD.Name = "dataCTHD";
            this.dataCTHD.RowHeadersVisible = false;
            this.dataCTHD.RowHeadersWidth = 62;
            this.dataCTHD.RowTemplate.Height = 50;
            this.dataCTHD.Size = new System.Drawing.Size(1072, 395);
            this.dataCTHD.TabIndex = 108;
            // 
            // sanpham
            // 
            this.sanpham.HeaderText = "Mã Sản phẩm";
            this.sanpham.MinimumWidth = 8;
            this.sanpham.Name = "sanpham";
            this.sanpham.Width = 300;
            // 
            // dvt
            // 
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.MinimumWidth = 8;
            this.dvt.Name = "dvt";
            this.dvt.Width = 280;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            this.soluong.Width = 280;
            // 
            // chietkhau
            // 
            this.chietkhau.HeaderText = "Chiết khấu";
            this.chietkhau.MinimumWidth = 8;
            this.chietkhau.Name = "chietkhau";
            this.chietkhau.Width = 200;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMaHD.Location = new System.Drawing.Point(278, 40);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(123, 30);
            this.lblMaHD.TabIndex = 107;
            this.lblMaHD.Text = "mahoadon";
            // 
            // advancedPanel14
            // 
            this.advancedPanel14.BackColor = System.Drawing.Color.White;
            this.advancedPanel14.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel14.Controls.Add(this.btnDongCTHD);
            this.advancedPanel14.EdgeWidth = 2;
            this.advancedPanel14.EndColor = System.Drawing.Color.White;
            this.advancedPanel14.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel14.Location = new System.Drawing.Point(964, 703);
            this.advancedPanel14.Name = "advancedPanel14";
            this.advancedPanel14.RectRadius = 5;
            this.advancedPanel14.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel14.ShadowShift = 0;
            this.advancedPanel14.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel14.Size = new System.Drawing.Size(141, 43);
            this.advancedPanel14.StartColor = System.Drawing.Color.White;
            this.advancedPanel14.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel14.TabIndex = 109;
            // 
            // btnDongCTHD
            // 
            this.btnDongCTHD.AutoSize = true;
            this.btnDongCTHD.BackColor = System.Drawing.Color.Transparent;
            this.btnDongCTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDongCTHD.FlatAppearance.BorderSize = 0;
            this.btnDongCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongCTHD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnDongCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnDongCTHD.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnDongCTHD.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnDongCTHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDongCTHD.IconSize = 30;
            this.btnDongCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongCTHD.Location = new System.Drawing.Point(0, 0);
            this.btnDongCTHD.Name = "btnDongCTHD";
            this.btnDongCTHD.Size = new System.Drawing.Size(141, 43);
            this.btnDongCTHD.TabIndex = 61;
            this.btnDongCTHD.Text = "      ĐÓNG (F10)";
            this.btnDongCTHD.UseVisualStyleBackColor = false;
            this.btnDongCTHD.Click += new System.EventHandler(this.btnDongCTHD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 114;
            this.label5.Text = "Ngày Hoá đơn";
            // 
            // txtPhutban
            // 
            this.txtPhutban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtPhutban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtPhutban.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPhutban.BorderRadius = 5;
            this.txtPhutban.BorderSize = 1;
            this.txtPhutban.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhutban.IsFocused = false;
            this.txtPhutban.Location = new System.Drawing.Point(425, 146);
            this.txtPhutban.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhutban.Multiline = false;
            this.txtPhutban.Name = "txtPhutban";
            this.txtPhutban.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPhutban.PasswordChar = false;
            this.txtPhutban.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhutban.PlaceholderText = "";
            this.txtPhutban.ReadOnly = false;
            this.txtPhutban.Size = new System.Drawing.Size(53, 43);
            this.txtPhutban.TabIndex = 118;
            this.txtPhutban.Texts = "";
            this.txtPhutban.UnderlineedStyle = false;
            // 
            // txtGioban
            // 
            this.txtGioban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtGioban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtGioban.BorderFocusColor = System.Drawing.Color.Black;
            this.txtGioban.BorderRadius = 5;
            this.txtGioban.BorderSize = 1;
            this.txtGioban.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGioban.IsFocused = false;
            this.txtGioban.Location = new System.Drawing.Point(348, 146);
            this.txtGioban.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioban.Multiline = false;
            this.txtGioban.Name = "txtGioban";
            this.txtGioban.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGioban.PasswordChar = false;
            this.txtGioban.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGioban.PlaceholderText = "";
            this.txtGioban.ReadOnly = false;
            this.txtGioban.Size = new System.Drawing.Size(53, 43);
            this.txtGioban.TabIndex = 119;
            this.txtGioban.Texts = "";
            this.txtGioban.UnderlineedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(407, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 21);
            this.label7.TabIndex = 116;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(348, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 117;
            this.label6.Text = "Giờ bán";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTenNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTenNV.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTenNV.BorderRadius = 5;
            this.txtTenNV.BorderSize = 1;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNV.IsFocused = false;
            this.txtTenNV.Location = new System.Drawing.Point(848, 146);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Multiline = false;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTenNV.PasswordChar = false;
            this.txtTenNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.ReadOnly = false;
            this.txtTenNV.Size = new System.Drawing.Size(257, 43);
            this.txtTenNV.TabIndex = 121;
            this.txtTenNV.Texts = "";
            this.txtTenNV.UnderlineedStyle = false;
            this.txtTenNV._TextChanged += new System.EventHandler(this.txtTenNV__TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(844, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 21);
            this.label8.TabIndex = 120;
            this.label8.Text = "Nhân viên bán hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(540, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
            this.label9.TabIndex = 122;
            this.label9.Text = "Họ tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTenKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTenKH.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTenKH.BorderRadius = 5;
            this.txtTenKH.BorderSize = 1;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenKH.IsFocused = false;
            this.txtTenKH.Location = new System.Drawing.Point(544, 146);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Multiline = false;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTenKH.PasswordChar = false;
            this.txtTenKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.ReadOnly = false;
            this.txtTenKH.Size = new System.Drawing.Size(257, 43);
            this.txtTenKH.TabIndex = 121;
            this.txtTenKH.Texts = "";
            this.txtTenKH.UnderlineedStyle = false;
            this.txtTenKH._TextChanged += new System.EventHandler(this.txtTenKH__TextChanged);
            // 
            // ctDateHD
            // 
            this.ctDateHD.BackColor = System.Drawing.Color.White;
            this.ctDateHD.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctDateHD.BorderRadius = 15;
            this.ctDateHD.BorderSize = 0;
            this.ctDateHD.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDateHD.CustomFormat = "dd/MM/yyyy";
            this.ctDateHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDateHD.ForeColor = System.Drawing.Color.Black;
            this.ctDateHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDateHD.Location = new System.Drawing.Point(37, 146);
            this.ctDateHD.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctDateHD.Name = "ctDateHD";
            this.ctDateHD.Size = new System.Drawing.Size(258, 43);
            this.ctDateHD.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctDateHD.TabIndex = 123;
            this.ctDateHD.TextColor = System.Drawing.Color.Black;
            // 
            // advancedPanel13
            // 
            this.advancedPanel13.BackColor = System.Drawing.Color.White;
            this.advancedPanel13.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel13.Controls.Add(this.btnLuuKH);
            this.advancedPanel13.EdgeWidth = 2;
            this.advancedPanel13.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.advancedPanel13.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(111)))), ((int)(((byte)(69)))));
            this.advancedPanel13.Location = new System.Drawing.Point(810, 703);
            this.advancedPanel13.Margin = new System.Windows.Forms.Padding(2);
            this.advancedPanel13.Name = "advancedPanel13";
            this.advancedPanel13.RectRadius = 5;
            this.advancedPanel13.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel13.ShadowShift = 0;
            this.advancedPanel13.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel13.Size = new System.Drawing.Size(127, 42);
            this.advancedPanel13.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.advancedPanel13.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel13.TabIndex = 124;
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.AutoSize = true;
            this.btnLuuKH.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuuKH.FlatAppearance.BorderSize = 0;
            this.btnLuuKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnLuuKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnLuuKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKH.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnLuuKH.ForeColor = System.Drawing.Color.White;
            this.btnLuuKH.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuuKH.IconColor = System.Drawing.Color.White;
            this.btnLuuKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuKH.IconSize = 30;
            this.btnLuuKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuKH.Location = new System.Drawing.Point(0, 0);
            this.btnLuuKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(127, 42);
            this.btnLuuKH.TabIndex = 67;
            this.btnLuuKH.Text = "       LƯU (F9)";
            this.btnLuuKH.UseVisualStyleBackColor = false;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 798);
            this.ControlBox = false;
            this.Controls.Add(this.advancedPanel13);
            this.Controls.Add(this.ctDateHD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhutban);
            this.Controls.Add(this.txtGioban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.advancedPanel14);
            this.Controls.Add(this.dataCTHD);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).EndInit();
            this.advancedPanel14.ResumeLayout(false);
            this.advancedPanel14.PerformLayout();
            this.advancedPanel13.ResumeLayout(false);
            this.advancedPanel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietkhau;
        private System.Windows.Forms.Label lblMaHD;
        private CTuserControl.AdvancedPanel advancedPanel14;
        private FontAwesome.Sharp.IconButton btnDongCTHD;
        private System.Windows.Forms.Label label5;
        private HotelManagement.CTControls.CTTextBox txtPhutban;
        private HotelManagement.CTControls.CTTextBox txtGioban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private HotelManagement.CTControls.CTTextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private HotelManagement.CTControls.CTTextBox txtTenKH;
        private CTuserControl.CTDatePicker ctDateHD;
        private CTuserControl.AdvancedPanel advancedPanel13;
        private FontAwesome.Sharp.IconButton btnLuuKH;
    }
}