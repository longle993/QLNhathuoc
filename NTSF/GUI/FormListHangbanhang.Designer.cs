
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.txtHangBan.Size = new System.Drawing.Size(888, 40);
            this.txtHangBan.TabIndex = 55;
            this.txtHangBan.Texts = "";
            this.txtHangBan.UnderlineedStyle = false;
            this.txtHangBan._TextChanged += new System.EventHandler(this.txtHangBan__TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Tenhang,
            this.DVTinh,
            this.SL,
            this.Giaban,
            this.Thanhtien,
            this.Note});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 123);
            this.dataGridView1.TabIndex = 56;
            // 
            // STT
            // 
            this.STT.HeaderText = "#";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // Tenhang
            // 
            this.Tenhang.HeaderText = "Tên hàng";
            this.Tenhang.MinimumWidth = 8;
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Width = 330;
            // 
            // DVTinh
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DVTinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVTinh.HeaderText = "Đơn vị tính";
            this.DVTinh.MinimumWidth = 8;
            this.DVTinh.Name = "DVTinh";
            this.DVTinh.Width = 105;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            this.SL.Width = 103;
            // 
            // Giaban
            // 
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.MinimumWidth = 8;
            this.Giaban.Name = "Giaban";
            this.Giaban.Width = 131;
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 8;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Width = 139;
            // 
            // Note
            // 
            this.Note.HeaderText = "";
            this.Note.MinimumWidth = 8;
            this.Note.Name = "Note";
            this.Note.Width = 59;
            // 
            // FormListHangbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHangBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListHangbanhang";
            this.Text = "FormListHangbanhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HotelManagement.CTControls.CTTextBox txtHangBan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}