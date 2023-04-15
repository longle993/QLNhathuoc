
namespace NTSF.GUI
{
    partial class FormListHangbanhang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHangBan = new HotelManagement.CTControls.CTTextBox();
            this.dataHangBan = new System.Windows.Forms.DataGridView();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.advancedPanel16 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnAddHH = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangBan)).BeginInit();
            this.advancedPanel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(892, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bán hàng";
            // 
            // txtHangBan
            // 
            this.txtHangBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtHangBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtHangBan.BorderFocusColor = System.Drawing.Color.Black;
            this.txtHangBan.BorderRadius = 5;
            this.txtHangBan.BorderSize = 1;
            this.txtHangBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHangBan.IsFocused = false;
            this.txtHangBan.Location = new System.Drawing.Point(34, 84);
            this.txtHangBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHangBan.Multiline = false;
            this.txtHangBan.Name = "txtHangBan";
            this.txtHangBan.Padding = new System.Windows.Forms.Padding(7);
            this.txtHangBan.PasswordChar = false;
            this.txtHangBan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHangBan.PlaceholderText = "Nhập mã sản phẩm hoặc tên sản phẩm để tìm kiếm";
            this.txtHangBan.ReadOnly = false;
            this.txtHangBan.Size = new System.Drawing.Size(843, 40);
            this.txtHangBan.TabIndex = 55;
            this.txtHangBan.Texts = "";
            this.txtHangBan.UnderlineedStyle = false;
            this.txtHangBan._TextChanged += new System.EventHandler(this.txtHangBan__TextChanged);
            // 
            // dataHangBan
            // 
            this.dataHangBan.AllowUserToAddRows = false;
            this.dataHangBan.AllowUserToDeleteRows = false;
            this.dataHangBan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHangBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHangBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenhang,
            this.DVTinh,
            this.SL,
            this.Giaban,
            this.Thanhtien,
            this.delete});
            this.dataHangBan.EnableHeadersVisualStyles = false;
            this.dataHangBan.Location = new System.Drawing.Point(23, 204);
            this.dataHangBan.Name = "dataHangBan";
            this.dataHangBan.RowHeadersVisible = false;
            this.dataHangBan.RowHeadersWidth = 62;
            this.dataHangBan.RowTemplate.Height = 28;
            this.dataHangBan.Size = new System.Drawing.Size(910, 123);
            this.dataHangBan.TabIndex = 56;
            this.dataHangBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangBan_CellClick);
            this.dataHangBan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataHangBan_CellFormatting);
            this.dataHangBan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangBan_CellValueChanged);
            // 
            // Tenhang
            // 
            this.Tenhang.HeaderText = "Tên hàng";
            this.Tenhang.MinimumWidth = 8;
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Width = 300;
            // 
            // DVTinh
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DVTinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVTinh.HeaderText = "Đơn vị tính";
            this.DVTinh.MinimumWidth = 8;
            this.DVTinh.Name = "DVTinh";
            this.DVTinh.Width = 125;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            this.SL.Width = 115;
            // 
            // Giaban
            // 
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.MinimumWidth = 8;
            this.Giaban.Name = "Giaban";
            this.Giaban.Width = 120;
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 8;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Width = 139;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 8;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Xoá hàng";
            this.delete.Width = 90;
            // 
            // advancedPanel16
            // 
            this.advancedPanel16.BackColor = System.Drawing.Color.White;
            this.advancedPanel16.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel16.Controls.Add(this.btnAddHH);
            this.advancedPanel16.EdgeWidth = 1;
            this.advancedPanel16.EndColor = System.Drawing.Color.White;
            this.advancedPanel16.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.advancedPanel16.Location = new System.Drawing.Point(884, 84);
            this.advancedPanel16.Name = "advancedPanel16";
            this.advancedPanel16.RectRadius = 5;
            this.advancedPanel16.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel16.ShadowShift = 2;
            this.advancedPanel16.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel16.Size = new System.Drawing.Size(49, 45);
            this.advancedPanel16.StartColor = System.Drawing.Color.White;
            this.advancedPanel16.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel16.TabIndex = 76;
            // 
            // btnAddHH
            // 
            this.btnAddHH.BackColor = System.Drawing.Color.Transparent;
            this.btnAddHH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHH.FlatAppearance.BorderSize = 0;
            this.btnAddHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHH.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddHH.IconColor = System.Drawing.Color.Black;
            this.btnAddHH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddHH.IconSize = 30;
            this.btnAddHH.Location = new System.Drawing.Point(0, 0);
            this.btnAddHH.Name = "btnAddHH";
            this.btnAddHH.Size = new System.Drawing.Size(49, 43);
            this.btnAddHH.TabIndex = 74;
            this.btnAddHH.UseVisualStyleBackColor = false;
            this.btnAddHH.Click += new System.EventHandler(this.btnAddHH_Click);
            // 
            // FormListHangbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 411);
            this.Controls.Add(this.advancedPanel16);
            this.Controls.Add(this.dataHangBan);
            this.Controls.Add(this.txtHangBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListHangbanhang";
            this.Text = "FormListHangbanhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataHangBan)).EndInit();
            this.advancedPanel16.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HotelManagement.CTControls.CTTextBox txtHangBan;
        public System.Windows.Forms.DataGridView dataHangBan;
        private CTuserControl.AdvancedPanel advancedPanel16;
        private FontAwesome.Sharp.IconButton btnAddHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}