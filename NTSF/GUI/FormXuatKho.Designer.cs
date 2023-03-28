
namespace NTSF.GUI
{
    partial class FormXuatKho
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
            this.panelXH = new System.Windows.Forms.Panel();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.lblPhieuNhapKho = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.advancedPanel3 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnXuatHuy = new FontAwesome.Sharp.IconButton();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemXuatKho = new FontAwesome.Sharp.IconButton();
            this.ctDatePicker1 = new NTSF.CTuserControl.CTDatePicker();
            this.ctDatePicker3 = new NTSF.CTuserControl.CTDatePicker();
            this.txtTKPNNhapKho = new HotelManagement.CTControls.CTTextBox();
            this.txtTKHHNhapKho = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataXuatHuy = new System.Windows.Forms.DataGridView();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelXH.SuspendLayout();
            this.advancedPanel5.SuspendLayout();
            this.advancedPanel1.SuspendLayout();
            this.advancedPanel3.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXuatHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelXH
            // 
            this.panelXH.Controls.Add(this.advancedPanel5);
            this.panelXH.Controls.Add(this.advancedPanel1);
            this.panelXH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXH.Location = new System.Drawing.Point(0, 0);
            this.panelXH.Name = "panelXH";
            this.panelXH.Size = new System.Drawing.Size(1722, 929);
            this.panelXH.TabIndex = 0;
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataXuatHuy);
            this.advancedPanel5.Controls.Add(this.lblPhieuNhapKho);
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
            this.advancedPanel5.TabIndex = 9;
            // 
            // lblPhieuNhapKho
            // 
            this.lblPhieuNhapKho.AutoSize = true;
            this.lblPhieuNhapKho.BackColor = System.Drawing.Color.White;
            this.lblPhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhieuNhapKho.ForeColor = System.Drawing.Color.Black;
            this.lblPhieuNhapKho.Location = new System.Drawing.Point(285, 20);
            this.lblPhieuNhapKho.Name = "lblPhieuNhapKho";
            this.lblPhieuNhapKho.Size = new System.Drawing.Size(37, 30);
            this.lblPhieuNhapKho.TabIndex = 52;
            this.lblPhieuNhapKho.Text = "xx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(270, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "(       phiếu)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 30);
            this.label5.TabIndex = 52;
            this.label5.Text = "Danh sách phiếu";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.advancedPanel3);
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.ctDatePicker1);
            this.advancedPanel1.Controls.Add(this.ctDatePicker3);
            this.advancedPanel1.Controls.Add(this.txtTKPNNhapKho);
            this.advancedPanel1.Controls.Add(this.txtTKHHNhapKho);
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
            this.advancedPanel1.TabIndex = 8;
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackColor = System.Drawing.Color.White;
            this.advancedPanel3.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.btnXuatHuy);
            this.advancedPanel3.EdgeWidth = 2;
            this.advancedPanel3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(111)))), ((int)(((byte)(69)))));
            this.advancedPanel3.Location = new System.Drawing.Point(1483, 79);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 5;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 0;
            this.advancedPanel3.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel3.Size = new System.Drawing.Size(141, 43);
            this.advancedPanel3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.advancedPanel3.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 59;
            // 
            // btnXuatHuy
            // 
            this.btnXuatHuy.AutoSize = true;
            this.btnXuatHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHuy.FlatAppearance.BorderSize = 0;
            this.btnXuatHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnXuatHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnXuatHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHuy.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnXuatHuy.ForeColor = System.Drawing.Color.White;
            this.btnXuatHuy.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnXuatHuy.IconColor = System.Drawing.Color.White;
            this.btnXuatHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatHuy.IconSize = 30;
            this.btnXuatHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatHuy.Location = new System.Drawing.Point(0, 1);
            this.btnXuatHuy.Name = "btnXuatHuy";
            this.btnXuatHuy.Size = new System.Drawing.Size(141, 40);
            this.btnXuatHuy.TabIndex = 64;
            this.btnXuatHuy.Text = "XUẤT HUỶ";
            this.btnXuatHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatHuy.UseVisualStyleBackColor = false;
            this.btnXuatHuy.Click += new System.EventHandler(this.btnXuatHuy_Click);
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemXuatKho);
            this.advancedPanel2.EdgeWidth = 2;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel2.Location = new System.Drawing.Point(1485, 135);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 5;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 0;
            this.advancedPanel2.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel2.Size = new System.Drawing.Size(141, 43);
            this.advancedPanel2.StartColor = System.Drawing.Color.White;
            this.advancedPanel2.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 56;
            // 
            // btnTimKiemXuatKho
            // 
            this.btnTimKiemXuatKho.AutoSize = true;
            this.btnTimKiemXuatKho.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemXuatKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemXuatKho.FlatAppearance.BorderSize = 0;
            this.btnTimKiemXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemXuatKho.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemXuatKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemXuatKho.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemXuatKho.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemXuatKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemXuatKho.IconSize = 30;
            this.btnTimKiemXuatKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemXuatKho.Location = new System.Drawing.Point(1, 3);
            this.btnTimKiemXuatKho.Name = "btnTimKiemXuatKho";
            this.btnTimKiemXuatKho.Size = new System.Drawing.Size(138, 36);
            this.btnTimKiemXuatKho.TabIndex = 61;
            this.btnTimKiemXuatKho.Text = "      TÌM KIẾM";
            this.btnTimKiemXuatKho.UseVisualStyleBackColor = false;
            // 
            // ctDatePicker1
            // 
            this.ctDatePicker1.BackColor = System.Drawing.Color.White;
            this.ctDatePicker1.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctDatePicker1.BorderRadius = 15;
            this.ctDatePicker1.BorderSize = 0;
            this.ctDatePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDatePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctDatePicker1.CustomFormat = "dd/MM/yyyy";
            this.ctDatePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.ctDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDatePicker1.Location = new System.Drawing.Point(351, 135);
            this.ctDatePicker1.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctDatePicker1.Name = "ctDatePicker1";
            this.ctDatePicker1.Size = new System.Drawing.Size(219, 43);
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
            this.ctDatePicker3.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDatePicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctDatePicker3.CustomFormat = "dd/MM/yyyy";
            this.ctDatePicker3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDatePicker3.ForeColor = System.Drawing.Color.Black;
            this.ctDatePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDatePicker3.Location = new System.Drawing.Point(84, 135);
            this.ctDatePicker3.MinimumSize = new System.Drawing.Size(4, 39);
            this.ctDatePicker3.Name = "ctDatePicker3";
            this.ctDatePicker3.Size = new System.Drawing.Size(219, 39);
            this.ctDatePicker3.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctDatePicker3.TabIndex = 55;
            this.ctDatePicker3.TextColor = System.Drawing.Color.Black;
            // 
            // txtTKPNNhapKho
            // 
            this.txtTKPNNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKPNNhapKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKPNNhapKho.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTKPNNhapKho.BorderRadius = 5;
            this.txtTKPNNhapKho.BorderSize = 1;
            this.txtTKPNNhapKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTKPNNhapKho.IsFocused = false;
            this.txtTKPNNhapKho.Location = new System.Drawing.Point(1107, 135);
            this.txtTKPNNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKPNNhapKho.Multiline = false;
            this.txtTKPNNhapKho.Name = "txtTKPNNhapKho";
            this.txtTKPNNhapKho.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKPNNhapKho.PasswordChar = false;
            this.txtTKPNNhapKho.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTKPNNhapKho.PlaceholderText = "Tìm kiếm theo mã phiếu";
            this.txtTKPNNhapKho.ReadOnly = false;
            this.txtTKPNNhapKho.Size = new System.Drawing.Size(333, 43);
            this.txtTKPNNhapKho.TabIndex = 54;
            this.txtTKPNNhapKho.Texts = "";
            this.txtTKPNNhapKho.UnderlineedStyle = false;
            // 
            // txtTKHHNhapKho
            // 
            this.txtTKHHNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHHNhapKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHHNhapKho.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTKHHNhapKho.BorderRadius = 5;
            this.txtTKHHNhapKho.BorderSize = 1;
            this.txtTKHHNhapKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTKHHNhapKho.IsFocused = false;
            this.txtTKHHNhapKho.Location = new System.Drawing.Point(650, 135);
            this.txtTKHHNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKHHNhapKho.Multiline = false;
            this.txtTKHHNhapKho.Name = "txtTKHHNhapKho";
            this.txtTKHHNhapKho.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKHHNhapKho.PasswordChar = false;
            this.txtTKHHNhapKho.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTKHHNhapKho.PlaceholderText = "Tìm kiếm theo mã, tên của hàng hoá";
            this.txtTKHHNhapKho.ReadOnly = false;
            this.txtTKHHNhapKho.Size = new System.Drawing.Size(413, 43);
            this.txtTKHHNhapKho.TabIndex = 54;
            this.txtTKHHNhapKho.Texts = "";
            this.txtTKHHNhapKho.UnderlineedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1101, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tìm kiếm theo phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(644, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tìm kiếm theo hàng hoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(345, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(78, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
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
            this.label6.Size = new System.Drawing.Size(157, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "XUẤT HUỶ";
            // 
            // dataXuatHuy
            // 
            this.dataXuatHuy.AllowUserToResizeColumns = false;
            this.dataXuatHuy.AllowUserToResizeRows = false;
            this.dataXuatHuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXuatHuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.ngayxuat,
            this.tongtien,
            this.ghichu});
            this.dataXuatHuy.Location = new System.Drawing.Point(57, 63);
            this.dataXuatHuy.Name = "dataXuatHuy";
            this.dataXuatHuy.RowHeadersVisible = false;
            this.dataXuatHuy.RowHeadersWidth = 62;
            this.dataXuatHuy.RowTemplate.Height = 28;
            this.dataXuatHuy.Size = new System.Drawing.Size(1559, 499);
            this.dataXuatHuy.TabIndex = 55;
            // 
            // maphieu
            // 
            this.maphieu.HeaderText = "Mã phiếu";
            this.maphieu.MinimumWidth = 8;
            this.maphieu.Name = "maphieu";
            this.maphieu.Width = 375;
            // 
            // ngayxuat
            // 
            this.ngayxuat.HeaderText = "Ngày xuất";
            this.ngayxuat.MinimumWidth = 8;
            this.ngayxuat.Name = "ngayxuat";
            this.ngayxuat.Width = 470;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 8;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 360;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 350;
            // 
            // FormXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1722, 929);
            this.Controls.Add(this.panelXH);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXuatKho";
            this.Text = "FormXuatKho";
            this.panelXH.ResumeLayout(false);
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXuatHuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXH;
        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label lblPhieuNhapKho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel3;
        private FontAwesome.Sharp.IconButton btnXuatHuy;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemXuatKho;
        private CTuserControl.CTDatePicker ctDatePicker1;
        private CTuserControl.CTDatePicker ctDatePicker3;
        private HotelManagement.CTControls.CTTextBox txtTKPNNhapKho;
        private HotelManagement.CTControls.CTTextBox txtTKHHNhapKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataXuatHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}