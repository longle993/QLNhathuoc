
namespace NTSF.GUI
{
    partial class FormDanhMuc
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
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.advancedPanel3 = new NTSF.CTuserControl.AdvancedPanel();
            this.cbboxNhomhang = new System.Windows.Forms.ComboBox();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemDanhmuc = new FontAwesome.Sharp.IconButton();
            this.txtSearchHH = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataHangHoa = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hamluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mo_ta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt_cb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.advancedPanel3.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.iconPictureBox2);
            this.advancedPanel1.Controls.Add(this.label10);
            this.advancedPanel1.Controls.Add(this.advancedPanel3);
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.txtSearchHH);
            this.advancedPanel1.Controls.Add(this.label4);
            this.advancedPanel1.Controls.Add(this.label3);
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
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(221, 31);
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
            this.label10.Location = new System.Drawing.Point(247, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 38);
            this.label10.TabIndex = 63;
            this.label10.Text = "HÀNG HOÁ";
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackColor = System.Drawing.Color.White;
            this.advancedPanel3.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.cbboxNhomhang);
            this.advancedPanel3.EdgeWidth = 1;
            this.advancedPanel3.EndColor = System.Drawing.Color.White;
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.advancedPanel3.Location = new System.Drawing.Point(661, 135);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 5;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 2;
            this.advancedPanel3.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel3.Size = new System.Drawing.Size(390, 43);
            this.advancedPanel3.StartColor = System.Drawing.Color.White;
            this.advancedPanel3.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 61;
            // 
            // cbboxNhomhang
            // 
            this.cbboxNhomhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbboxNhomhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbboxNhomhang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxNhomhang.FormattingEnabled = true;
            this.cbboxNhomhang.ItemHeight = 28;
            this.cbboxNhomhang.Location = new System.Drawing.Point(3, 0);
            this.cbboxNhomhang.Name = "cbboxNhomhang";
            this.cbboxNhomhang.Size = new System.Drawing.Size(384, 36);
            this.cbboxNhomhang.TabIndex = 58;
            this.cbboxNhomhang.SelectedIndexChanged += new System.EventHandler(this.cbboxNhomhang_SelectedIndexChanged);
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemDanhmuc);
            this.advancedPanel2.EdgeWidth = 2;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel2.Location = new System.Drawing.Point(1133, 135);
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
            // btnTimKiemDanhmuc
            // 
            this.btnTimKiemDanhmuc.AutoSize = true;
            this.btnTimKiemDanhmuc.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemDanhmuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemDanhmuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemDanhmuc.FlatAppearance.BorderSize = 0;
            this.btnTimKiemDanhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemDanhmuc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemDanhmuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemDanhmuc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemDanhmuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemDanhmuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemDanhmuc.IconSize = 30;
            this.btnTimKiemDanhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemDanhmuc.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiemDanhmuc.Name = "btnTimKiemDanhmuc";
            this.btnTimKiemDanhmuc.Size = new System.Drawing.Size(141, 43);
            this.btnTimKiemDanhmuc.TabIndex = 63;
            this.btnTimKiemDanhmuc.Text = "      TÌM KIẾM";
            this.btnTimKiemDanhmuc.UseVisualStyleBackColor = false;
            this.btnTimKiemDanhmuc.Click += new System.EventHandler(this.btnTimKiemDanhmuc_Click);
            // 
            // txtSearchHH
            // 
            this.txtSearchHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchHH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchHH.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearchHH.BorderRadius = 5;
            this.txtSearchHH.BorderSize = 1;
            this.txtSearchHH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchHH.IsFocused = false;
            this.txtSearchHH.Location = new System.Drawing.Point(84, 135);
            this.txtSearchHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchHH.Multiline = false;
            this.txtSearchHH.Name = "txtSearchHH";
            this.txtSearchHH.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchHH.PasswordChar = false;
            this.txtSearchHH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchHH.PlaceholderText = "Tìm kiếm theo mã, tên của hàng hoá";
            this.txtSearchHH.ReadOnly = false;
            this.txtSearchHH.Size = new System.Drawing.Size(500, 43);
            this.txtSearchHH.TabIndex = 54;
            this.txtSearchHH.Texts = "";
            this.txtSearchHH.UnderlineedStyle = false;
            this.txtSearchHH._TextChanged += new System.EventHandler(this.txtSearchHH__TextChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(659, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nhóm hàng";
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
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataHangHoa);
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
            this.advancedPanel5.TabIndex = 6;
            // 
            // dataHangHoa
            // 
            this.dataHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.loaisp,
            this.hamluong,
            this.QCDG,
            this.mo_ta,
            this.dvt_cb,
            this.vat_ban,
            this.giaban,
            this.tongton});
            this.dataHangHoa.Location = new System.Drawing.Point(33, 76);
            this.dataHangHoa.Name = "dataHangHoa";
            this.dataHangHoa.RowHeadersVisible = false;
            this.dataHangHoa.RowHeadersWidth = 62;
            this.dataHangHoa.RowTemplate.Height = 28;
            this.dataHangHoa.Size = new System.Drawing.Size(1559, 499);
            this.dataHangHoa.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(337, 20);
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
            this.label7.Location = new System.Drawing.Point(325, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "(       hàng hoá)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(79, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 30);
            this.label9.TabIndex = 52;
            this.label9.Text = "Danh sách hàng hoá";
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã SP";
            this.masp.MinimumWidth = 8;
            this.masp.Name = "masp";
            this.masp.Width = 110;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên SP";
            this.tensp.MinimumWidth = 8;
            this.tensp.Name = "tensp";
            this.tensp.Width = 340;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại SP";
            this.loaisp.MinimumWidth = 8;
            this.loaisp.Name = "loaisp";
            this.loaisp.Width = 180;
            // 
            // hamluong
            // 
            this.hamluong.HeaderText = "Hàm lượng";
            this.hamluong.MinimumWidth = 8;
            this.hamluong.Name = "hamluong";
            this.hamluong.Width = 140;
            // 
            // QCDG
            // 
            this.QCDG.HeaderText = "Quy cách đóng gói";
            this.QCDG.MinimumWidth = 8;
            this.QCDG.Name = "QCDG";
            this.QCDG.Width = 150;
            // 
            // mo_ta
            // 
            this.mo_ta.HeaderText = "Mô tả";
            this.mo_ta.MinimumWidth = 8;
            this.mo_ta.Name = "mo_ta";
            this.mo_ta.Width = 85;
            // 
            // dvt_cb
            // 
            this.dvt_cb.HeaderText = "DVT Cơ bản";
            this.dvt_cb.MinimumWidth = 8;
            this.dvt_cb.Name = "dvt_cb";
            this.dvt_cb.Width = 150;
            // 
            // vat_ban
            // 
            this.vat_ban.HeaderText = "VAT Bán";
            this.vat_ban.MinimumWidth = 8;
            this.vat_ban.Name = "vat_ban";
            this.vat_ban.Width = 125;
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Giá Bán";
            this.giaban.MinimumWidth = 8;
            this.giaban.Name = "giaban";
            this.giaban.Width = 125;
            // 
            // tongton
            // 
            this.tongton.HeaderText = "Tổng tồn";
            this.tongton.MinimumWidth = 8;
            this.tongton.Name = "tongton";
            this.tongton.Width = 125;
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1722, 929);
            this.Controls.Add(this.advancedPanel5);
            this.Controls.Add(this.advancedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhMuc";
            this.Text = "FormDanhMuc";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel3;
        private System.Windows.Forms.ComboBox cbboxNhomhang;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemDanhmuc;
        private HotelManagement.CTControls.CTTextBox txtSearchHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn hamluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn mo_ta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongton;
    }
}