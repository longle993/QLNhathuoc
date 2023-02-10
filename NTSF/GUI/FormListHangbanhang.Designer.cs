
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTKPNNhapKho = new HotelManagement.CTControls.CTTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bán hàng";
            // 
            // txtTKPNNhapKho
            // 
            this.txtTKPNNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKPNNhapKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKPNNhapKho.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTKPNNhapKho.BorderRadius = 5;
            this.txtTKPNNhapKho.BorderSize = 0;
            this.txtTKPNNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTKPNNhapKho.IsFocused = false;
            this.txtTKPNNhapKho.Location = new System.Drawing.Point(34, 84);
            this.txtTKPNNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKPNNhapKho.Multiline = false;
            this.txtTKPNNhapKho.Name = "txtTKPNNhapKho";
            this.txtTKPNNhapKho.Padding = new System.Windows.Forms.Padding(7, 0, 7, 7);
            this.txtTKPNNhapKho.PasswordChar = false;
            this.txtTKPNNhapKho.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTKPNNhapKho.PlaceholderText = "Nhập mã sản phẩm hoặc tên sản phẩm để tìm kiếm";
            this.txtTKPNNhapKho.ReadOnly = false;
            this.txtTKPNNhapKho.Size = new System.Drawing.Size(888, 33);
            this.txtTKPNNhapKho.TabIndex = 55;
            this.txtTKPNNhapKho.Texts = "";
            this.txtTKPNNhapKho.UnderlineedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 123);
            this.dataGridView1.TabIndex = 56;
            // 
            // FormListHangbanhang
            // 
            this.DoubleBuffered = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTKPNNhapKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private HotelManagement.CTControls.CTTextBox txtTKPNNhapKho;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}