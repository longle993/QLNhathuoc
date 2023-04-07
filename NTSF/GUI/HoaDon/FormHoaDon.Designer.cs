
using System.Windows.Forms;

namespace NTSF.GUI
{
    partial class FormHoaDon
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

        public class DoubleBufferPanel : Panel

        {

            public DoubleBufferPanel()

            {

                // Set the value of the double-buffering style bits to true.

                this.DoubleBuffered = true;

                this.SetStyle(ControlStyles.AllPaintingInWmPaint |

                ControlStyles.UserPaint |

                ControlStyles.OptimizedDoubleBuffer, true);

                UpdateStyles();

            }

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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.lblCountHD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.btnTimKiemHoadon = new FontAwesome.Sharp.IconButton();
            this.ctTimeTo = new NTSF.CTuserControl.CTDatePicker();
            this.ctTimeFrom = new NTSF.CTuserControl.CTDatePicker();
            this.txtTKHDHoadon = new HotelManagement.CTControls.CTTextBox();
            this.txtSearchByName = new HotelManagement.CTControls.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combobox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.advancedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.dataHoaDon);
            this.advancedPanel5.Controls.Add(this.lblCountHD);
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
            this.advancedPanel5.TabIndex = 2;
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToAddRows = false;
            this.dataHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.khachhang,
            this.ngayban,
            this.tongtien,
            this.ghichu,
            this.combobox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHoaDon.GridColor = System.Drawing.Color.Silver;
            this.dataHoaDon.Location = new System.Drawing.Point(33, 76);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.RowHeadersVisible = false;
            this.dataHoaDon.RowHeadersWidth = 62;
            this.dataHoaDon.RowTemplate.Height = 50;
            this.dataHoaDon.Size = new System.Drawing.Size(1559, 499);
            this.dataHoaDon.TabIndex = 53;
            this.dataHoaDon.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataHoaDon_EditingControlShowing);
            // 
            // lblCountHD
            // 
            this.lblCountHD.AutoSize = true;
            this.lblCountHD.BackColor = System.Drawing.Color.White;
            this.lblCountHD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountHD.ForeColor = System.Drawing.Color.Black;
            this.lblCountHD.Location = new System.Drawing.Point(300, 20);
            this.lblCountHD.Name = "lblCountHD";
            this.lblCountHD.Size = new System.Drawing.Size(37, 30);
            this.lblCountHD.TabIndex = 52;
            this.lblCountHD.Text = "xx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(282, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "(       hoá đơn)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 30);
            this.label5.TabIndex = 52;
            this.label5.Text = "Danh sách hoá đơn";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.advancedPanel2);
            this.advancedPanel1.Controls.Add(this.ctTimeTo);
            this.advancedPanel1.Controls.Add(this.ctTimeFrom);
            this.advancedPanel1.Controls.Add(this.txtTKHDHoadon);
            this.advancedPanel1.Controls.Add(this.txtSearchByName);
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
            this.advancedPanel1.TabIndex = 0;
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackColor = System.Drawing.Color.White;
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.btnTimKiemHoadon);
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
            // btnTimKiemHoadon
            // 
            this.btnTimKiemHoadon.AutoSize = true;
            this.btnTimKiemHoadon.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemHoadon.FlatAppearance.BorderSize = 0;
            this.btnTimKiemHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemHoadon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemHoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemHoadon.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiemHoadon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btnTimKiemHoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemHoadon.IconSize = 30;
            this.btnTimKiemHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemHoadon.Location = new System.Drawing.Point(1, 3);
            this.btnTimKiemHoadon.Name = "btnTimKiemHoadon";
            this.btnTimKiemHoadon.Size = new System.Drawing.Size(138, 36);
            this.btnTimKiemHoadon.TabIndex = 64;
            this.btnTimKiemHoadon.Text = "      TÌM KIẾM";
            this.btnTimKiemHoadon.UseVisualStyleBackColor = false;
            // 
            // ctTimeTo
            // 
            this.ctTimeTo.BackColor = System.Drawing.Color.White;
            this.ctTimeTo.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.ctTimeTo.BorderRadius = 15;
            this.ctTimeTo.BorderSize = 0;
            this.ctTimeTo.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeTo.CustomFormat = "dd/MM/yyyy";
            this.ctTimeTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeTo.ForeColor = System.Drawing.Color.Black;
            this.ctTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctTimeTo.Location = new System.Drawing.Point(375, 135);
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
            this.ctTimeFrom.CustomFormat = "dd/MM/yyyy";
            this.ctTimeFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctTimeFrom.ForeColor = System.Drawing.Color.Black;
            this.ctTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctTimeFrom.Location = new System.Drawing.Point(76, 135);
            this.ctTimeFrom.MinimumSize = new System.Drawing.Size(4, 43);
            this.ctTimeFrom.Name = "ctTimeFrom";
            this.ctTimeFrom.Size = new System.Drawing.Size(258, 43);
            this.ctTimeFrom.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctTimeFrom.TabIndex = 55;
            this.ctTimeFrom.TextColor = System.Drawing.Color.Black;
            this.ctTimeFrom.ValueChanged += new System.EventHandler(this.ctTimeFrom_ValueChanged);
            // 
            // txtTKHDHoadon
            // 
            this.txtTKHDHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHDHoadon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTKHDHoadon.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTKHDHoadon.BorderRadius = 5;
            this.txtTKHDHoadon.BorderSize = 1;
            this.txtTKHDHoadon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTKHDHoadon.IsFocused = false;
            this.txtTKHDHoadon.Location = new System.Drawing.Point(1124, 135);
            this.txtTKHDHoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKHDHoadon.Multiline = false;
            this.txtTKHDHoadon.Name = "txtTKHDHoadon";
            this.txtTKHDHoadon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKHDHoadon.PasswordChar = false;
            this.txtTKHDHoadon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTKHDHoadon.PlaceholderText = "Tìm kiếm theo mã của hàng hoá";
            this.txtTKHDHoadon.ReadOnly = false;
            this.txtTKHDHoadon.Size = new System.Drawing.Size(333, 43);
            this.txtTKHDHoadon.TabIndex = 54;
            this.txtTKHDHoadon.Texts = "";
            this.txtTKHDHoadon.UnderlineedStyle = false;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchByName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSearchByName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearchByName.BorderRadius = 5;
            this.txtSearchByName.BorderSize = 1;
            this.txtSearchByName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchByName.IsFocused = false;
            this.txtSearchByName.Location = new System.Drawing.Point(672, 135);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchByName.Multiline = false;
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchByName.PasswordChar = false;
            this.txtSearchByName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchByName.PlaceholderText = "Tìm kiếm theo tên của hàng hoá";
            this.txtSearchByName.ReadOnly = false;
            this.txtSearchByName.Size = new System.Drawing.Size(413, 43);
            this.txtSearchByName.TabIndex = 54;
            this.txtSearchByName.Texts = "";
            this.txtSearchByName.UnderlineedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1118, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tìm kiếm theo hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(666, 94);
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
            this.label2.Location = new System.Drawing.Point(369, 94);
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
            this.label1.Location = new System.Drawing.Point(70, 94);
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
            this.label6.Size = new System.Drawing.Size(152, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "HOÁ ĐƠN";
            // 
            // mahd
            // 
            this.mahd.HeaderText = "Mã Hoá đơn";
            this.mahd.MinimumWidth = 8;
            this.mahd.Name = "mahd";
            this.mahd.Width = 280;
            // 
            // khachhang
            // 
            this.khachhang.HeaderText = "Khách hàng";
            this.khachhang.MinimumWidth = 8;
            this.khachhang.Name = "khachhang";
            this.khachhang.Width = 300;
            // 
            // ngayban
            // 
            this.ngayban.HeaderText = "Ngày bán hàng";
            this.ngayban.MinimumWidth = 8;
            this.ngayban.Name = "ngayban";
            this.ngayban.Width = 280;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 8;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 280;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 200;
            // 
            // combobox
            // 
            this.combobox.HeaderText = "";
            this.combobox.Items.AddRange(new object[] {
            "Xem chi tiết",
            "Sửa Thông tin",
            "Xoá HĐ"});
            this.combobox.MinimumWidth = 8;
            this.combobox.Name = "combobox";
            this.combobox.Width = 190;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 985);
            this.Controls.Add(this.advancedPanel5);
            this.Controls.Add(this.advancedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private HotelManagement.CTControls.CTTextBox txtSearchByName;
        private CTuserControl.CTDatePicker ctTimeTo;
        private CTuserControl.CTDatePicker ctTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private HotelManagement.CTControls.CTTextBox txtTKHDHoadon;
        private System.Windows.Forms.Label label4;
        private CTuserControl.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountHD;
        private System.Windows.Forms.Label label7;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private FontAwesome.Sharp.IconButton btnTimKiemHoadon;
        private DataGridView dataHoaDon;
        private DataGridViewTextBoxColumn mahd;
        private DataGridViewTextBoxColumn khachhang;
        private DataGridViewTextBoxColumn ngayban;
        private DataGridViewTextBoxColumn tongtien;
        private DataGridViewTextBoxColumn ghichu;
        private DataGridViewComboBoxColumn combobox;
    }
}