
namespace NTSF.GUI
{
    partial class FormNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTaoPhieu = new System.Windows.Forms.Panel();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataPhieuNhap = new System.Windows.Forms.DataGridView();
            this.mapn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCountPN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemPN = new FontAwesome.Sharp.IconButton();
            this.advancedPanel3 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnNhapKho = new FontAwesome.Sharp.IconButton();
            this.ctTimeTo = new NTSF.CTuserControl.CTDatePicker();
            this.ctTimeFrom = new NTSF.CTuserControl.CTDatePicker();
            this.txtTKPNNhapKho = new HotelManagement.CTControls.CTTextBox();
            this.txtSearchHHNK = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTaoPhieu.SuspendLayout();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuNhap)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.advancedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTaoPhieu
            // 
            this.panelTaoPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.panelTaoPhieu.Controls.Add(this.advancedPanel5);
            this.panelTaoPhieu.Controls.Add(this.advancedPanel1);
            this.panelTaoPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaoPhieu.Location = new System.Drawing.Point(0, 0);
            this.panelTaoPhieu.Name = "panelTaoPhieu";
            this.panelTaoPhieu.Size = new System.Drawing.Size(1744, 985);
            this.panelTaoPhieu.TabIndex = 0;
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataPhieuNhap);
            this.advancedPanel5.Controls.Add(this.lblCountPN);
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
            this.advancedPanel5.TabIndex = 6;
            // 
            // dataPhieuNhap
            // 
            this.dataPhieuNhap.AllowUserToAddRows = false;
            this.dataPhieuNhap.AllowUserToDeleteRows = false;
            this.dataPhieuNhap.AllowUserToResizeColumns = false;
            this.dataPhieuNhap.AllowUserToResizeRows = false;
            this.dataPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapn,
            this.ngaynhap,
            this.trigia,
            this.ghichu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhieuNhap.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataPhieuNhap.GridColor = System.Drawing.Color.Silver;
            this.dataPhieuNhap.Location = new System.Drawing.Point(31, 76);
            this.dataPhieuNhap.Name = "dataPhieuNhap";
            this.dataPhieuNhap.RowHeadersVisible = false;
            this.dataPhieuNhap.RowHeadersWidth = 62;
            this.dataPhieuNhap.RowTemplate.Height = 50;
            this.dataPhieuNhap.Size = new System.Drawing.Size(1559, 499);
            this.dataPhieuNhap.TabIndex = 57;
            // 
            // mapn
            // 
            this.mapn.HeaderText = "Mã phiếu";
            this.mapn.MinimumWidth = 8;
            this.mapn.Name = "mapn";
            this.mapn.Width = 380;
            // 
            // ngaynhap
            // 
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 8;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 390;
            // 
            // trigia
            // 
            this.trigia.HeaderText = "Trị giá";
            this.trigia.MinimumWidth = 8;
            this.trigia.Name = "trigia";
            this.trigia.Width = 390;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 390;
            // 
            // lblCountPN
            // 
            this.lblCountPN.AutoSize = true;
            this.lblCountPN.BackColor = System.Drawing.Color.White;
            this.lblCountPN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountPN.ForeColor = System.Drawing.Color.Black;
            this.lblCountPN.Location = new System.Drawing.Point(285, 20);
            this.lblCountPN.Name = "lblCountPN";
            this.lblCountPN.Size = new System.Drawing.Size(37, 30);
            this.lblCountPN.TabIndex = 52;
            this.lblCountPN.Text = "xx";
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
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.advancedPanel3);
            this.advancedPanel1.Controls.Add(this.ctTimeTo);
            this.advancedPanel1.Controls.Add(this.ctTimeFrom);
            this.advancedPanel1.Controls.Add(this.txtTKPNNhapKho);
            this.advancedPanel1.Controls.Add(this.txtSearchHHNK);
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
            this.advancedPanel1.TabIndex = 5;
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemPN);
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
            this.advancedPanel2.TabIndex = 60;
            // 
            // btnTimKiemPN
            // 
            this.btnTimKiemPN.AutoSize = true;
            this.btnTimKiemPN.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemPN.FlatAppearance.BorderSize = 0;
            this.btnTimKiemPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPN.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemPN.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemPN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemPN.IconSize = 30;
            this.btnTimKiemPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPN.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiemPN.Name = "btnTimKiemPN";
            this.btnTimKiemPN.Size = new System.Drawing.Size(141, 43);
            this.btnTimKiemPN.TabIndex = 64;
            this.btnTimKiemPN.Text = "      TÌM KIẾM";
            this.btnTimKiemPN.UseVisualStyleBackColor = false;
            this.btnTimKiemPN.Click += new System.EventHandler(this.btnTimKiemPN_Click);
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackColor = System.Drawing.Color.White;
            this.advancedPanel3.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.btnNhapKho);
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
            // btnNhapKho
            // 
            this.btnNhapKho.AutoSize = true;
            this.btnNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnNhapKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnNhapKho.IconColor = System.Drawing.Color.White;
            this.btnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapKho.IconSize = 30;
            this.btnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Location = new System.Drawing.Point(0, 0);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(141, 43);
            this.btnNhapKho.TabIndex = 66;
            this.btnNhapKho.Text = "NHẬP HÀNG";
            this.btnNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // ctTimeTo
            // 
            this.ctTimeTo.BackColor = System.Drawing.Color.White;
            this.ctTimeTo.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctTimeTo.BorderRadius = 15;
            this.ctTimeTo.BorderSize = 0;
            this.ctTimeTo.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTimeTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctTimeTo.CustomFormat = "dd/MM/yyyy";
            this.ctTimeTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeTo.ForeColor = System.Drawing.Color.Black;
            this.ctTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctTimeTo.Location = new System.Drawing.Point(351, 135);
            this.ctTimeTo.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctTimeTo.Name = "ctTimeTo";
            this.ctTimeTo.Size = new System.Drawing.Size(219, 43);
            this.ctTimeTo.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctTimeTo.TabIndex = 55;
            this.ctTimeTo.TextColor = System.Drawing.Color.Black;
            this.ctTimeTo.ValueChanged += new System.EventHandler(this.ctTimeTo_ValueChanged);
            // 
            // ctTimeFrom
            // 
            this.ctTimeFrom.BackColor = System.Drawing.Color.White;
            this.ctTimeFrom.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctTimeFrom.BorderRadius = 15;
            this.ctTimeFrom.BorderSize = 0;
            this.ctTimeFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTimeFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctTimeFrom.CustomFormat = "dd/MM/yyyy";
            this.ctTimeFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeFrom.ForeColor = System.Drawing.Color.Black;
            this.ctTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctTimeFrom.Location = new System.Drawing.Point(84, 135);
            this.ctTimeFrom.MinimumSize = new System.Drawing.Size(4, 39);
            this.ctTimeFrom.Name = "ctTimeFrom";
            this.ctTimeFrom.Size = new System.Drawing.Size(219, 39);
            this.ctTimeFrom.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctTimeFrom.TabIndex = 55;
            this.ctTimeFrom.TextColor = System.Drawing.Color.Black;
            this.ctTimeFrom.ValueChanged += new System.EventHandler(this.ctTimeFrom_ValueChanged);
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
            this.txtTKPNNhapKho._TextChanged += new System.EventHandler(this.txtTKPNNhapKho__TextChanged);
            // 
            // txtSearchHHNK
            // 
            this.txtSearchHHNK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchHHNK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchHHNK.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearchHHNK.BorderRadius = 5;
            this.txtSearchHHNK.BorderSize = 1;
            this.txtSearchHHNK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchHHNK.IsFocused = false;
            this.txtSearchHHNK.Location = new System.Drawing.Point(650, 135);
            this.txtSearchHHNK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchHHNK.Multiline = false;
            this.txtSearchHHNK.Name = "txtSearchHHNK";
            this.txtSearchHHNK.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchHHNK.PasswordChar = false;
            this.txtSearchHHNK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchHHNK.PlaceholderText = "Tìm kiếm theo mã, tên của hàng hoá";
            this.txtSearchHHNK.ReadOnly = false;
            this.txtSearchHHNK.Size = new System.Drawing.Size(413, 43);
            this.txtSearchHHNK.TabIndex = 54;
            this.txtSearchHHNK.Texts = "";
            this.txtSearchHHNK.UnderlineedStyle = false;
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
            this.label6.Size = new System.Drawing.Size(165, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "NHẬP KHO";
            // 
            // FormNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 985);
            this.Controls.Add(this.panelTaoPhieu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapKho";
            this.Text = "NhapKho";
            this.Load += new System.EventHandler(this.FormNhapKho_Load);
            this.panelTaoPhieu.ResumeLayout(false);
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuNhap)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label lblCountPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTaoPhieu;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemPN;
        private CTuserControl.AdvancedPanel advancedPanel3;
        private FontAwesome.Sharp.IconButton btnNhapKho;
        private CTuserControl.CTDatePicker ctTimeTo;
        private CTuserControl.CTDatePicker ctTimeFrom;
        private HotelManagement.CTControls.CTTextBox txtTKPNNhapKho;
        private HotelManagement.CTControls.CTTextBox txtSearchHHNK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}