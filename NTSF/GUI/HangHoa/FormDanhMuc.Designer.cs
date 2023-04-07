
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataHangHoa = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giavon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonchitiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCountHang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.advancedPanel3 = new NTSF.CTuserControl.AdvancedPanel();
            this.cbboxNhomhang = new System.Windows.Forms.ComboBox();
            this.txtSearchHH = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.advancedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataHangHoa);
            this.advancedPanel5.Controls.Add(this.lblCountHang);
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
            this.dataHangHoa.AllowUserToAddRows = false;
            this.dataHangHoa.AllowUserToResizeColumns = false;
            this.dataHangHoa.AllowUserToResizeRows = false;
            this.dataHangHoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.loaisp,
            this.giavon,
            this.giaban,
            this.tongton,
            this.buttonchitiet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHangHoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHangHoa.GridColor = System.Drawing.Color.Silver;
            this.dataHangHoa.Location = new System.Drawing.Point(33, 76);
            this.dataHangHoa.Name = "dataHangHoa";
            this.dataHangHoa.RowHeadersVisible = false;
            this.dataHangHoa.RowHeadersWidth = 62;
            this.dataHangHoa.RowTemplate.Height = 50;
            this.dataHangHoa.Size = new System.Drawing.Size(1559, 499);
            this.dataHangHoa.TabIndex = 53;
            this.dataHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangHoa_CellClick);
            this.dataHangHoa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataHangHoa_CellFormatting);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã hàng hoá";
            this.masp.MinimumWidth = 8;
            this.masp.Name = "masp";
            this.masp.Width = 170;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên hàng hoá";
            this.tensp.MinimumWidth = 8;
            this.tensp.Name = "tensp";
            this.tensp.Width = 410;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại hàng hoá";
            this.loaisp.MinimumWidth = 8;
            this.loaisp.Name = "loaisp";
            this.loaisp.Width = 220;
            // 
            // giavon
            // 
            this.giavon.HeaderText = "Giá vốn";
            this.giavon.MinimumWidth = 8;
            this.giavon.Name = "giavon";
            this.giavon.Width = 180;
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Giá Bán";
            this.giaban.MinimumWidth = 8;
            this.giaban.Name = "giaban";
            this.giaban.Width = 250;
            // 
            // tongton
            // 
            this.tongton.HeaderText = "Tổng tồn";
            this.tongton.MinimumWidth = 8;
            this.tongton.Name = "tongton";
            this.tongton.Width = 130;
            // 
            // buttonchitiet
            // 
            this.buttonchitiet.HeaderText = "Thao tác";
            this.buttonchitiet.MinimumWidth = 8;
            this.buttonchitiet.Name = "buttonchitiet";
            this.buttonchitiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonchitiet.Text = "Xem chi tiết";
            this.buttonchitiet.Width = 168;
            // 
            // lblCountHang
            // 
            this.lblCountHang.AutoSize = true;
            this.lblCountHang.BackColor = System.Drawing.Color.White;
            this.lblCountHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountHang.ForeColor = System.Drawing.Color.Black;
            this.lblCountHang.Location = new System.Drawing.Point(337, 20);
            this.lblCountHang.Name = "lblCountHang";
            this.lblCountHang.Size = new System.Drawing.Size(37, 30);
            this.lblCountHang.TabIndex = 52;
            this.lblCountHang.Text = "xx";
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
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.iconPictureBox2);
            this.advancedPanel1.Controls.Add(this.label10);
            this.advancedPanel1.Controls.Add(this.advancedPanel3);
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
            this.advancedPanel3.Location = new System.Drawing.Point(989, 135);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 5;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 2;
            this.advancedPanel3.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel3.Size = new System.Drawing.Size(603, 43);
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
            this.cbboxNhomhang.Size = new System.Drawing.Size(597, 36);
            this.cbboxNhomhang.TabIndex = 58;
            this.cbboxNhomhang.SelectedIndexChanged += new System.EventHandler(this.cbboxNhomhang_SelectedIndexChanged);
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
            this.txtSearchHH.Size = new System.Drawing.Size(756, 43);
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
            this.label3.Location = new System.Drawing.Point(984, 94);
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
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.advancedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CTuserControl.AdvancedPanel advancedPanel1;
        private CTuserControl.AdvancedPanel advancedPanel3;
        private System.Windows.Forms.ComboBox cbboxNhomhang;
        private HotelManagement.CTControls.CTTextBox txtSearchHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label lblCountHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giavon;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongton;
        private System.Windows.Forms.DataGridViewButtonColumn buttonchitiet;

    }
}