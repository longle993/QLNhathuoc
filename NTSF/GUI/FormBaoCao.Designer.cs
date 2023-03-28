
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
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataXuatHuy = new System.Windows.Forms.DataGridView();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonghd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonggiavon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loinhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemBC = new FontAwesome.Sharp.IconButton();
            this.ctDatePicker1 = new NTSF.CTuserControl.CTDatePicker();
            this.ctDatePicker3 = new NTSF.CTuserControl.CTDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXuatHuy)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataXuatHuy);
            this.advancedPanel5.Controls.Add(this.label8);
            this.advancedPanel5.Controls.Add(this.label7);
            this.advancedPanel5.Controls.Add(this.label9);
            this.advancedPanel5.Controls.Add(this.label10);
            this.advancedPanel5.Controls.Add(this.label5);
            this.advancedPanel5.Controls.Add(this.label4);
            this.advancedPanel5.Controls.Add(this.label3);
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
            // dataXuatHuy
            // 
            this.dataXuatHuy.AllowUserToResizeColumns = false;
            this.dataXuatHuy.AllowUserToResizeRows = false;
            this.dataXuatHuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXuatHuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thoigian,
            this.tonghd,
            this.doanhthu,
            this.tonggiavon,
            this.loinhuan});
            this.dataXuatHuy.Location = new System.Drawing.Point(57, 84);
            this.dataXuatHuy.Name = "dataXuatHuy";
            this.dataXuatHuy.RowHeadersVisible = false;
            this.dataXuatHuy.RowHeadersWidth = 62;
            this.dataXuatHuy.RowTemplate.Height = 28;
            this.dataXuatHuy.Size = new System.Drawing.Size(1559, 499);
            this.dataXuatHuy.TabIndex = 56;
            // 
            // thoigian
            // 
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.MinimumWidth = 8;
            this.thoigian.Name = "thoigian";
            this.thoigian.Width = 300;
            // 
            // tonghd
            // 
            this.tonghd.HeaderText = "Tổng tiền hoá đơn";
            this.tonghd.MinimumWidth = 8;
            this.tonghd.Name = "tonghd";
            this.tonghd.Width = 320;
            // 
            // doanhthu
            // 
            this.doanhthu.HeaderText = "Doanh thu";
            this.doanhthu.MinimumWidth = 8;
            this.doanhthu.Name = "doanhthu";
            this.doanhthu.Width = 305;
            // 
            // tonggiavon
            // 
            this.tonggiavon.HeaderText = "Tổng giá vốn";
            this.tonggiavon.MinimumWidth = 8;
            this.tonggiavon.Name = "tonggiavon";
            this.tonggiavon.Width = 310;
            // 
            // loinhuan
            // 
            this.loinhuan.HeaderText = "Lợi nhuận";
            this.loinhuan.MinimumWidth = 8;
            this.loinhuan.Name = "loinhuan";
            this.loinhuan.Width = 320;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(285, 20);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1327, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tổng:";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.ctDatePicker1);
            this.advancedPanel1.Controls.Add(this.ctDatePicker3);
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
            this.ctDatePicker1.Location = new System.Drawing.Point(380, 135);
            this.ctDatePicker1.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctDatePicker1.Name = "ctDatePicker1";
            this.ctDatePicker1.Size = new System.Drawing.Size(258, 43);
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
            this.ctDatePicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctDatePicker3.CustomFormat = "dd/MM/yyyy";
            this.ctDatePicker3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctDatePicker3.ForeColor = System.Drawing.Color.Black;
            this.ctDatePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDatePicker3.Location = new System.Drawing.Point(84, 135);
            this.ctDatePicker3.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctDatePicker3.Name = "ctDatePicker3";
            this.ctDatePicker3.Size = new System.Drawing.Size(258, 43);
            this.ctDatePicker3.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctDatePicker3.TabIndex = 55;
            this.ctDatePicker3.TextColor = System.Drawing.Color.Black;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1010, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tổng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(696, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tổng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(354, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.TabIndex = 52;
            this.label10.Text = "Tổng:";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataXuatHuy)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemBC;
        private CTuserControl.CTDatePicker ctDatePicker1;
        private CTuserControl.CTDatePicker ctDatePicker3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataXuatHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonghd;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonggiavon;
        private System.Windows.Forms.DataGridViewTextBoxColumn loinhuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}