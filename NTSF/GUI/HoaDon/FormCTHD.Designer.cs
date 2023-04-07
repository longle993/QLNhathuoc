
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataCTHD = new System.Windows.Forms.DataGridView();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.advancedPanel14 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnDongThemHang = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).BeginInit();
            this.advancedPanel14.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanpham,
            this.dvt,
            this.soluong,
            this.chietkhau});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCTHD.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataCTHD.GridColor = System.Drawing.Color.Silver;
            this.dataCTHD.Location = new System.Drawing.Point(33, 110);
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
            this.advancedPanel14.Controls.Add(this.btnDongThemHang);
            this.advancedPanel14.EdgeWidth = 2;
            this.advancedPanel14.EndColor = System.Drawing.Color.White;
            this.advancedPanel14.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel14.Location = new System.Drawing.Point(964, 545);
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
            // btnDongThemHang
            // 
            this.btnDongThemHang.AutoSize = true;
            this.btnDongThemHang.BackColor = System.Drawing.Color.Transparent;
            this.btnDongThemHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongThemHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDongThemHang.FlatAppearance.BorderSize = 0;
            this.btnDongThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongThemHang.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnDongThemHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnDongThemHang.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnDongThemHang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnDongThemHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDongThemHang.IconSize = 30;
            this.btnDongThemHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongThemHang.Location = new System.Drawing.Point(0, 0);
            this.btnDongThemHang.Name = "btnDongThemHang";
            this.btnDongThemHang.Size = new System.Drawing.Size(141, 43);
            this.btnDongThemHang.TabIndex = 61;
            this.btnDongThemHang.Text = "      ĐÓNG (F10)";
            this.btnDongThemHang.UseVisualStyleBackColor = false;
            // 
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 630);
            this.ControlBox = false;
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
        private FontAwesome.Sharp.IconButton btnDongThemHang;
    }
}