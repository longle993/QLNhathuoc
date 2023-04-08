
namespace NTSF.GUI
{
    partial class FormBaoCao
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
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataBaoCao = new System.Windows.Forms.DataGridView();
            this.lblCountBC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemBC = new FontAwesome.Sharp.IconButton();
            this.ctTimeTo = new NTSF.CTuserControl.CTDatePicker();
            this.ctTimeFrom = new NTSF.CTuserControl.CTDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTonghoadon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTonggiavon = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTongloinhuan = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonghd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonggiavon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loinhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoCao)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.lblTonghoadon);
            this.advancedPanel5.Controls.Add(this.label12);
            this.advancedPanel5.Controls.Add(this.lblTonggiavon);
            this.advancedPanel5.Controls.Add(this.label13);
            this.advancedPanel5.Controls.Add(this.lblTongloinhuan);
            this.advancedPanel5.Controls.Add(this.label14);
            this.advancedPanel5.Controls.Add(this.dataBaoCao);
            this.advancedPanel5.Controls.Add(this.lblCountBC);
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
            this.advancedPanel5.TabIndex = 7;
            // 
            // dataBaoCao
            // 
            this.dataBaoCao.AllowUserToAddRows = false;
            this.dataBaoCao.AllowUserToDeleteRows = false;
            this.dataBaoCao.AllowUserToResizeColumns = false;
            this.dataBaoCao.AllowUserToResizeRows = false;
            this.dataBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thoigian,
            this.tonghd,
            this.tonggiavon,
            this.loinhuan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataBaoCao.GridColor = System.Drawing.Color.Silver;
            this.dataBaoCao.Location = new System.Drawing.Point(57, 84);
            this.dataBaoCao.Name = "dataBaoCao";
            this.dataBaoCao.RowHeadersVisible = false;
            this.dataBaoCao.RowHeadersWidth = 62;
            this.dataBaoCao.RowTemplate.Height = 50;
            this.dataBaoCao.Size = new System.Drawing.Size(1559, 499);
            this.dataBaoCao.TabIndex = 56;
            // 
            // lblCountBC
            // 
            this.lblCountBC.AutoSize = true;
            this.lblCountBC.BackColor = System.Drawing.Color.White;
            this.lblCountBC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountBC.ForeColor = System.Drawing.Color.Black;
            this.lblCountBC.Location = new System.Drawing.Point(285, 20);
            this.lblCountBC.Name = "lblCountBC";
            this.lblCountBC.Size = new System.Drawing.Size(37, 30);
            this.lblCountBC.TabIndex = 52;
            this.lblCountBC.Text = "xx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(270, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "(       bản ghi)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(79, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 30);
            this.label9.TabIndex = 52;
            this.label9.Text = "Danh sách dữ liệu";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.ctTimeTo);
            this.advancedPanel1.Controls.Add(this.ctTimeFrom);
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
            this.advancedPanel1.TabIndex = 6;
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemBC);
            this.advancedPanel2.EdgeWidth = 2;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel2.Location = new System.Drawing.Point(679, 135);
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
            // btnTimKiemBC
            // 
            this.btnTimKiemBC.AutoSize = true;
            this.btnTimKiemBC.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemBC.FlatAppearance.BorderSize = 0;
            this.btnTimKiemBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemBC.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemBC.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemBC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemBC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemBC.IconSize = 30;
            this.btnTimKiemBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemBC.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiemBC.Name = "btnTimKiemBC";
            this.btnTimKiemBC.Size = new System.Drawing.Size(141, 43);
            this.btnTimKiemBC.TabIndex = 63;
            this.btnTimKiemBC.Text = "      TÌM KIẾM";
            this.btnTimKiemBC.UseVisualStyleBackColor = false;
            this.btnTimKiemBC.Click += new System.EventHandler(this.btnTimKiemBC_Click);
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
            this.ctTimeTo.Location = new System.Drawing.Point(380, 135);
            this.ctTimeTo.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctTimeTo.Name = "ctTimeTo";
            this.ctTimeTo.Size = new System.Drawing.Size(258, 43);
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
            this.ctTimeFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctTimeFrom.CustomFormat = "dd/MM/yyyy";
            this.ctTimeFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeFrom.ForeColor = System.Drawing.Color.Black;
            this.ctTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctTimeFrom.Location = new System.Drawing.Point(84, 135);
            this.ctTimeFrom.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctTimeFrom.Name = "ctTimeFrom";
            this.ctTimeFrom.Size = new System.Drawing.Size(258, 43);
            this.ctTimeFrom.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctTimeFrom.TabIndex = 55;
            this.ctTimeFrom.TextColor = System.Drawing.Color.Black;
            this.ctTimeFrom.ValueChanged += new System.EventHandler(this.ctTimeFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(375, 94);
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
            this.label6.Size = new System.Drawing.Size(142, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "BÁO CÁO";
            // 
            // lblTonghoadon
            // 
            this.lblTonghoadon.AutoSize = true;
            this.lblTonghoadon.BackColor = System.Drawing.Color.White;
            this.lblTonghoadon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTonghoadon.Location = new System.Drawing.Point(570, 607);
            this.lblTonghoadon.Name = "lblTonghoadon";
            this.lblTonghoadon.Size = new System.Drawing.Size(24, 28);
            this.lblTonghoadon.TabIndex = 57;
            this.lblTonghoadon.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(499, 607);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 28);
            this.label12.TabIndex = 58;
            this.label12.Text = "Tổng:";
            // 
            // lblTonggiavon
            // 
            this.lblTonggiavon.AutoSize = true;
            this.lblTonggiavon.BackColor = System.Drawing.Color.White;
            this.lblTonggiavon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTonggiavon.Location = new System.Drawing.Point(973, 607);
            this.lblTonggiavon.Name = "lblTonggiavon";
            this.lblTonggiavon.Size = new System.Drawing.Size(24, 28);
            this.lblTonggiavon.TabIndex = 59;
            this.lblTonggiavon.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(902, 607);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 28);
            this.label13.TabIndex = 60;
            this.label13.Text = "Tổng:";
            // 
            // lblTongloinhuan
            // 
            this.lblTongloinhuan.AutoSize = true;
            this.lblTongloinhuan.BackColor = System.Drawing.Color.White;
            this.lblTongloinhuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongloinhuan.Location = new System.Drawing.Point(1364, 607);
            this.lblTongloinhuan.Name = "lblTongloinhuan";
            this.lblTongloinhuan.Size = new System.Drawing.Size(24, 28);
            this.lblTongloinhuan.TabIndex = 61;
            this.lblTongloinhuan.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1293, 607);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 28);
            this.label14.TabIndex = 62;
            this.label14.Text = "Tổng:";
            // 
            // thoigian
            // 
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.MinimumWidth = 8;
            this.thoigian.Name = "thoigian";
            this.thoigian.Width = 385;
            // 
            // tonghd
            // 
            this.tonghd.HeaderText = "Tổng tiền hoá đơn";
            this.tonghd.MinimumWidth = 8;
            this.tonghd.Name = "tonghd";
            this.tonghd.Width = 390;
            // 
            // tonggiavon
            // 
            this.tonggiavon.HeaderText = "Tổng giá vốn";
            this.tonggiavon.MinimumWidth = 8;
            this.tonggiavon.Name = "tonggiavon";
            this.tonggiavon.Width = 390;
            // 
            // loinhuan
            // 
            this.loinhuan.HeaderText = "Lợi nhuận";
            this.loinhuan.MinimumWidth = 8;
            this.loinhuan.Name = "loinhuan";
            this.loinhuan.Width = 390;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1744, 985);
            this.Controls.Add(this.advancedPanel5);
            this.Controls.Add(this.advancedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoCao)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label lblCountBC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemBC;
        private CTuserControl.CTDatePicker ctTimeTo;
        private CTuserControl.CTDatePicker ctTimeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataBaoCao;
        private System.Windows.Forms.Label lblTonghoadon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTonggiavon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTongloinhuan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonghd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonggiavon;
        private System.Windows.Forms.DataGridViewTextBoxColumn loinhuan;
    }
}