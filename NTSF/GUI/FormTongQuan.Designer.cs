
using System.Windows.Forms;

namespace NTSF.GUI
{
    partial class FormTongQuan
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.advancedPanel5 = new NTSF.CTuserControl.AdvancedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.advancedPanel6 = new NTSF.CTuserControl.AdvancedPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedPanel7 = new NTSF.CTuserControl.AdvancedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.advancedPanel1 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDSthangnay = new System.Windows.Forms.Label();
            this.lblDSthangtruoc = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.advancedPanel4 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblHethang = new System.Windows.Forms.Label();
            this.lblHethan = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.advancedPanel3 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHoadonBC = new System.Windows.Forms.Label();
            this.lblDSBaocao = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.advancedPanel2 = new NTSF.CTuserControl.AdvancedPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblHoadonthangtruoc = new System.Windows.Forms.Label();
            this.lblHoadonthangnay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.advancedPanel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.advancedPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.advancedPanel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.advancedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.advancedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.advancedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1744, 462);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.advancedPanel5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(866, 456);
            this.panel5.TabIndex = 0;
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.label4);
            this.advancedPanel5.EdgeWidth = 0;
            this.advancedPanel5.EndColor = System.Drawing.Color.White;
            this.advancedPanel5.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel5.Location = new System.Drawing.Point(41, 13);
            this.advancedPanel5.Name = "advancedPanel5";
            this.advancedPanel5.RectRadius = 5;
            this.advancedPanel5.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel5.ShadowShift = 5;
            this.advancedPanel5.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel5.Size = new System.Drawing.Size(778, 425);
            this.advancedPanel5.StartColor = System.Drawing.Color.White;
            this.advancedPanel5.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(90, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Doanh số bán hàng tháng này:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.advancedPanel6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(875, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(866, 456);
            this.panel6.TabIndex = 1;
            // 
            // advancedPanel6
            // 
            this.advancedPanel6.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel6.Controls.Add(this.label20);
            this.advancedPanel6.EdgeWidth = 0;
            this.advancedPanel6.EndColor = System.Drawing.Color.White;
            this.advancedPanel6.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel6.Location = new System.Drawing.Point(27, 13);
            this.advancedPanel6.Name = "advancedPanel6";
            this.advancedPanel6.RectRadius = 5;
            this.advancedPanel6.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel6.ShadowShift = 5;
            this.advancedPanel6.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel6.Size = new System.Drawing.Size(778, 425);
            this.advancedPanel6.StartColor = System.Drawing.Color.White;
            this.advancedPanel6.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel6.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(66, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 28);
            this.label20.TabIndex = 53;
            this.label20.Text = "CẢNH BÁO HÀNG HOÁ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.advancedPanel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1744, 345);
            this.panel1.TabIndex = 2;
            // 
            // advancedPanel7
            // 
            this.advancedPanel7.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel7.Controls.Add(this.label6);
            this.advancedPanel7.EdgeWidth = 0;
            this.advancedPanel7.EndColor = System.Drawing.Color.White;
            this.advancedPanel7.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel7.Location = new System.Drawing.Point(47, 6);
            this.advancedPanel7.Name = "advancedPanel7";
            this.advancedPanel7.RectRadius = 5;
            this.advancedPanel7.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel7.ShadowShift = 5;
            this.advancedPanel7.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel7.Size = new System.Drawing.Size(1634, 303);
            this.advancedPanel7.StartColor = System.Drawing.Color.White;
            this.advancedPanel7.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(57, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "TOP 10 HÀNG HOÁ BÁN CHẠY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.advancedPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 172);
            this.panel2.TabIndex = 4;
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.lblDSthangtruoc);
            this.advancedPanel1.Controls.Add(this.lblDSthangnay);
            this.advancedPanel1.Controls.Add(this.label8);
            this.advancedPanel1.Controls.Add(this.label7);
            this.advancedPanel1.Controls.Add(this.label15);
            this.advancedPanel1.Controls.Add(this.iconPictureBox1);
            this.advancedPanel1.EdgeWidth = 0;
            this.advancedPanel1.EndColor = System.Drawing.Color.White;
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel1.Location = new System.Drawing.Point(41, 9);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 5;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 3;
            this.advancedPanel1.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(350, 158);
            this.advancedPanel1.StartColor = System.Drawing.Color.White;
            this.advancedPanel1.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Location = new System.Drawing.Point(92, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(44, 28);
            this.iconPictureBox1.TabIndex = 58;
            this.iconPictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label15.Location = new System.Drawing.Point(126, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 28);
            this.label15.TabIndex = 57;
            this.label15.Text = "DOANH SỐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tháng trước:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "Tháng này:";
            // 
            // lblDSthangnay
            // 
            this.lblDSthangnay.AutoSize = true;
            this.lblDSthangnay.BackColor = System.Drawing.Color.White;
            this.lblDSthangnay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSthangnay.Location = new System.Drawing.Point(207, 104);
            this.lblDSthangnay.Name = "lblDSthangnay";
            this.lblDSthangnay.Size = new System.Drawing.Size(99, 21);
            this.lblDSthangnay.TabIndex = 61;
            this.lblDSthangnay.Text = "1000,999.00";
            // 
            // lblDSthangtruoc
            // 
            this.lblDSthangtruoc.AutoSize = true;
            this.lblDSthangtruoc.BackColor = System.Drawing.Color.White;
            this.lblDSthangtruoc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSthangtruoc.Location = new System.Drawing.Point(207, 71);
            this.lblDSthangtruoc.Name = "lblDSthangtruoc";
            this.lblDSthangtruoc.Size = new System.Drawing.Size(90, 21);
            this.lblDSthangtruoc.TabIndex = 61;
            this.lblDSthangtruoc.Text = "999,999.00";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.advancedPanel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(1311, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 172);
            this.panel7.TabIndex = 3;
            // 
            // advancedPanel4
            // 
            this.advancedPanel4.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel4.Controls.Add(this.label19);
            this.advancedPanel4.Controls.Add(this.lblHethan);
            this.advancedPanel4.Controls.Add(this.lblHethang);
            this.advancedPanel4.Controls.Add(this.label18);
            this.advancedPanel4.Controls.Add(this.label14);
            this.advancedPanel4.Controls.Add(this.label13);
            this.advancedPanel4.Controls.Add(this.label3);
            this.advancedPanel4.Controls.Add(this.iconPictureBox4);
            this.advancedPanel4.EdgeWidth = 0;
            this.advancedPanel4.EndColor = System.Drawing.Color.White;
            this.advancedPanel4.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel4.Location = new System.Drawing.Point(20, 9);
            this.advancedPanel4.Name = "advancedPanel4";
            this.advancedPanel4.RectRadius = 5;
            this.advancedPanel4.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel4.ShadowShift = 3;
            this.advancedPanel4.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel4.Size = new System.Drawing.Size(350, 158);
            this.advancedPanel4.StartColor = System.Drawing.Color.White;
            this.advancedPanel4.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel4.TabIndex = 3;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.White;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 40;
            this.iconPictureBox4.Location = new System.Drawing.Point(20, 20);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(44, 40);
            this.iconPictureBox4.TabIndex = 60;
            this.iconPictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(61, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "CẢNH BÁO HÀNG HOÁ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 21);
            this.label13.TabIndex = 64;
            this.label13.Text = "Hàng hoá sắp hết hạn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "Hàng hoá sắp hết hàng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(286, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 21);
            this.label18.TabIndex = 62;
            this.label18.Text = "loại";
            // 
            // lblHethang
            // 
            this.lblHethang.AutoSize = true;
            this.lblHethang.BackColor = System.Drawing.Color.White;
            this.lblHethang.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHethang.Location = new System.Drawing.Point(252, 104);
            this.lblHethang.Name = "lblHethang";
            this.lblHethang.Size = new System.Drawing.Size(28, 21);
            this.lblHethang.TabIndex = 61;
            this.lblHethang.Text = "xx";
            // 
            // lblHethan
            // 
            this.lblHethan.AutoSize = true;
            this.lblHethan.BackColor = System.Drawing.Color.White;
            this.lblHethan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHethan.Location = new System.Drawing.Point(252, 71);
            this.lblHethan.Name = "lblHethan";
            this.lblHethan.Size = new System.Drawing.Size(28, 21);
            this.lblHethan.TabIndex = 61;
            this.lblHethan.Text = "xx";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(286, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 21);
            this.label19.TabIndex = 61;
            this.label19.Text = "loại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.advancedPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(875, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 172);
            this.panel4.TabIndex = 2;
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.label12);
            this.advancedPanel3.Controls.Add(this.lblDSBaocao);
            this.advancedPanel3.Controls.Add(this.lblHoadonBC);
            this.advancedPanel3.Controls.Add(this.label11);
            this.advancedPanel3.Controls.Add(this.label2);
            this.advancedPanel3.Controls.Add(this.iconPictureBox3);
            this.advancedPanel3.EdgeWidth = 0;
            this.advancedPanel3.EndColor = System.Drawing.Color.White;
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel3.Location = new System.Drawing.Point(27, 9);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 5;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 3;
            this.advancedPanel3.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel3.Size = new System.Drawing.Size(350, 158);
            this.advancedPanel3.StartColor = System.Drawing.Color.White;
            this.advancedPanel3.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 40;
            this.iconPictureBox3.Location = new System.Drawing.Point(43, 20);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(44, 40);
            this.iconPictureBox3.TabIndex = 58;
            this.iconPictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(76, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "BÁO CÁO TRONG NGÀY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 60;
            this.label11.Text = "Hoá đơn:";
            // 
            // lblHoadonBC
            // 
            this.lblHoadonBC.AutoSize = true;
            this.lblHoadonBC.BackColor = System.Drawing.Color.White;
            this.lblHoadonBC.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoadonBC.Location = new System.Drawing.Point(270, 71);
            this.lblHoadonBC.Name = "lblHoadonBC";
            this.lblHoadonBC.Size = new System.Drawing.Size(28, 21);
            this.lblHoadonBC.TabIndex = 61;
            this.lblHoadonBC.Text = "xx";
            // 
            // lblDSBaocao
            // 
            this.lblDSBaocao.AutoSize = true;
            this.lblDSBaocao.BackColor = System.Drawing.Color.White;
            this.lblDSBaocao.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSBaocao.Location = new System.Drawing.Point(270, 104);
            this.lblDSBaocao.Name = "lblDSBaocao";
            this.lblDSBaocao.Size = new System.Drawing.Size(28, 21);
            this.lblDSBaocao.TabIndex = 61;
            this.lblDSBaocao.Text = "xx";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 21);
            this.label12.TabIndex = 59;
            this.label12.Text = "Doanh số:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.advancedPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(439, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 172);
            this.panel3.TabIndex = 1;
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.lblHoadonthangnay);
            this.advancedPanel2.Controls.Add(this.lblHoadonthangtruoc);
            this.advancedPanel2.Controls.Add(this.label17);
            this.advancedPanel2.Controls.Add(this.label10);
            this.advancedPanel2.Controls.Add(this.label16);
            this.advancedPanel2.Controls.Add(this.label9);
            this.advancedPanel2.Controls.Add(this.label1);
            this.advancedPanel2.Controls.Add(this.iconPictureBox2);
            this.advancedPanel2.EdgeWidth = 0;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.White;
            this.advancedPanel2.Location = new System.Drawing.Point(34, 9);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 5;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 3;
            this.advancedPanel2.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(350, 158);
            this.advancedPanel2.StartColor = System.Drawing.Color.White;
            this.advancedPanel2.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FileLines;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 40;
            this.iconPictureBox2.Location = new System.Drawing.Point(101, 20);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(44, 40);
            this.iconPictureBox2.TabIndex = 60;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(142, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 59;
            this.label1.Text = "HOÁ ĐƠN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Tháng trước:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(253, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 21);
            this.label16.TabIndex = 63;
            this.label16.Text = "đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Tháng này:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(253, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 21);
            this.label17.TabIndex = 61;
            this.label17.Text = "đơn";
            // 
            // lblHoadonthangtruoc
            // 
            this.lblHoadonthangtruoc.AutoSize = true;
            this.lblHoadonthangtruoc.BackColor = System.Drawing.Color.White;
            this.lblHoadonthangtruoc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoadonthangtruoc.Location = new System.Drawing.Point(219, 71);
            this.lblHoadonthangtruoc.Name = "lblHoadonthangtruoc";
            this.lblHoadonthangtruoc.Size = new System.Drawing.Size(28, 21);
            this.lblHoadonthangtruoc.TabIndex = 61;
            this.lblHoadonthangtruoc.Text = "xx";
            // 
            // lblHoadonthangnay
            // 
            this.lblHoadonthangnay.AutoSize = true;
            this.lblHoadonthangnay.BackColor = System.Drawing.Color.White;
            this.lblHoadonthangnay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoadonthangnay.Location = new System.Drawing.Point(219, 104);
            this.lblHoadonthangnay.Name = "lblHoadonthangnay";
            this.lblHoadonthangnay.Size = new System.Drawing.Size(28, 21);
            this.lblHoadonthangnay.TabIndex = 61;
            this.lblHoadonthangnay.Text = "xx";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1744, 178);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormTongQuan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1744, 985);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTongQuan";
            this.Text = "FormTongQuan";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.advancedPanel6.ResumeLayout(false);
            this.advancedPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.advancedPanel7.ResumeLayout(false);
            this.advancedPanel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.advancedPanel4.ResumeLayout(false);
            this.advancedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private CTuserControl.AdvancedPanel advancedPanel5;
        private Label label4;
        private CTuserControl.AdvancedPanel advancedPanel6;
        private Label label20;
        private CTuserControl.AdvancedPanel advancedPanel7;
        private Panel panel2;
        private CTuserControl.AdvancedPanel advancedPanel1;
        private Label lblDSthangtruoc;
        private Label lblDSthangnay;
        private Label label8;
        private Label label7;
        private Label label15;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel7;
        private CTuserControl.AdvancedPanel advancedPanel4;
        private Label label19;
        private Label lblHethan;
        private Label lblHethang;
        private Label label18;
        private Label label14;
        private Label label13;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panel4;
        private CTuserControl.AdvancedPanel advancedPanel3;
        private Label label12;
        private Label lblDSBaocao;
        private Label lblHoadonBC;
        private Label label11;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Panel panel3;
        private CTuserControl.AdvancedPanel advancedPanel2;
        private Label lblHoadonthangnay;
        private Label lblHoadonthangtruoc;
        private Label label17;
        private Label label10;
        private Label label16;
        private Label label9;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}