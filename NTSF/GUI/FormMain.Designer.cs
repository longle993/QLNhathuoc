using System.Windows.Forms;


namespace NTSF.GUI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new NTSF.GUI.FormMain.DoubleBufferPanel();
            this.panelLogo = new NTSF.GUI.FormMain.DoubleBufferPanel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panel1 = new NTSF.GUI.FormMain.DoubleBufferPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel2 = new NTSF.GUI.FormMain.DoubleBufferPanel();
            this.panelDesktop = new NTSF.GUI.FormMain.DoubleBufferPanel();
            this.dropdownMenu1 = new NTSF.CTuserControl.DropdownMenu(this.components);
            this.dropmenuNhapkho = new System.Windows.Forms.ToolStripMenuItem();
            this.dropmenuXuatkho = new System.Windows.Forms.ToolStripMenuItem();
            this.dropmenuTonkho = new System.Windows.Forms.ToolStripMenuItem();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ctCirclePictureBox5 = new NTSF.CTuserControl.CTCirclePictureBox();
            this.ctCirclePictureBox4 = new NTSF.CTuserControl.CTCirclePictureBox();
            this.btnNhathuoc = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCaidat = new FontAwesome.Sharp.IconButton();
            this.btnDanhmuc = new FontAwesome.Sharp.IconButton();
            this.btnBaocao = new FontAwesome.Sharp.IconButton();
            this.btnKho = new FontAwesome.Sharp.IconButton();
            this.btnHoadon = new FontAwesome.Sharp.IconButton();
            this.btnBuy = new FontAwesome.Sharp.IconButton();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.ctCirclePictureBox2 = new NTSF.CTuserControl.CTCirclePictureBox();
            this.ctCirclePictureBox3 = new NTSF.CTuserControl.CTCirclePictureBox();
            this.ctCirclePictureBox1 = new NTSF.CTuserControl.CTCirclePictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnCaidat);
            this.panelMenu.Controls.Add(this.btnDanhmuc);
            this.panelMenu.Controls.Add(this.btnBaocao);
            this.panelMenu.Controls.Add(this.btnKho);
            this.panelMenu.Controls.Add(this.btnHoadon);
            this.panelMenu.Controls.Add(this.btnBuy);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(176, 1080);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblAdmin);
            this.panelLogo.Controls.Add(this.picAdmin);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 220);
            this.panelLogo.TabIndex = 2;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(50, 129);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 32);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnNhathuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(176, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1744, 95);
            this.panel1.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(1415, 47);
            this.lbTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbTime.Size = new System.Drawing.Size(116, 33);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "09/09/2003";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctCirclePictureBox5);
            this.panel2.Controls.Add(this.ctCirclePictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1594, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 95);
            this.panel2.TabIndex = 6;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(176, 95);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1744, 985);
            this.panelDesktop.TabIndex = 3;
            // 
            // dropdownMenu1
            // 
            this.dropdownMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dropdownMenu1.IsMainMenu = false;
            this.dropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropmenuNhapkho,
            this.dropmenuXuatkho,
            this.dropmenuTonkho});
            this.dropdownMenu1.MenuItemHeight = 25;
            this.dropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropdownMenu1.Name = "dropdownMenu1";
            this.dropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.dropdownMenu1.Size = new System.Drawing.Size(163, 118);
            // 
            // dropmenuNhapkho
            // 
            this.dropmenuNhapkho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.dropmenuNhapkho.Name = "dropmenuNhapkho";
            this.dropmenuNhapkho.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dropmenuNhapkho.Size = new System.Drawing.Size(162, 38);
            this.dropmenuNhapkho.Text = "Nhập kho";
            this.dropmenuNhapkho.Click += new System.EventHandler(this.dropmenuNhapkho_Click);
            // 
            // dropmenuXuatkho
            // 
            this.dropmenuXuatkho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.dropmenuXuatkho.Name = "dropmenuXuatkho";
            this.dropmenuXuatkho.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dropmenuXuatkho.Size = new System.Drawing.Size(162, 38);
            this.dropmenuXuatkho.Text = "Xuất kho";
            // 
            // dropmenuTonkho
            // 
            this.dropmenuTonkho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.dropmenuTonkho.Name = "dropmenuTonkho";
            this.dropmenuTonkho.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dropmenuTonkho.Size = new System.Drawing.Size(162, 38);
            this.dropmenuTonkho.Text = "Tồn kho";
            this.dropmenuTonkho.Click += new System.EventHandler(this.dropmenuTonkho_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(1365, 40);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(53, 44);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // ctCirclePictureBox5
            // 
            this.ctCirclePictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.ctCirclePictureBox5.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ctCirclePictureBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.ctCirclePictureBox5.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.ctCirclePictureBox5.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ctCirclePictureBox5.BorderSize = 0;
            this.ctCirclePictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctCirclePictureBox5.GradientAngle = 50F;
            this.ctCirclePictureBox5.Location = new System.Drawing.Point(75, 0);
            this.ctCirclePictureBox5.Name = "ctCirclePictureBox5";
            this.ctCirclePictureBox5.Size = new System.Drawing.Size(33, 33);
            this.ctCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ctCirclePictureBox5.TabIndex = 0;
            this.ctCirclePictureBox5.TabStop = false;
            this.ctCirclePictureBox5.Click += new System.EventHandler(this.btnMin_Click);
            this.ctCirclePictureBox5.MouseLeave += new System.EventHandler(this.ctCirclePictureBox5_MouseLeave);
            this.ctCirclePictureBox5.MouseHover += new System.EventHandler(this.ctCirclePictureBox5_MouseHover);
            // 
            // ctCirclePictureBox4
            // 
            this.ctCirclePictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ctCirclePictureBox4.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ctCirclePictureBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ctCirclePictureBox4.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ctCirclePictureBox4.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ctCirclePictureBox4.BorderSize = 0;
            this.ctCirclePictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctCirclePictureBox4.GradientAngle = 50F;
            this.ctCirclePictureBox4.Location = new System.Drawing.Point(114, 0);
            this.ctCirclePictureBox4.Name = "ctCirclePictureBox4";
            this.ctCirclePictureBox4.Size = new System.Drawing.Size(33, 33);
            this.ctCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ctCirclePictureBox4.TabIndex = 0;
            this.ctCirclePictureBox4.TabStop = false;
            this.ctCirclePictureBox4.Click += new System.EventHandler(this.btnExit_Click);
            this.ctCirclePictureBox4.MouseLeave += new System.EventHandler(this.ctCirclePictureBox4_MouseLeave);
            this.ctCirclePictureBox4.MouseHover += new System.EventHandler(this.ctCirclePictureBox4_MouseHover);
            // 
            // btnNhathuoc
            // 
            this.btnNhathuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhathuoc.FlatAppearance.BorderSize = 0;
            this.btnNhathuoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNhathuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNhathuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhathuoc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhathuoc.ForeColor = System.Drawing.Color.White;
            this.btnNhathuoc.IconChar = FontAwesome.Sharp.IconChar.BriefcaseMedical;
            this.btnNhathuoc.IconColor = System.Drawing.Color.White;
            this.btnNhathuoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhathuoc.IconSize = 60;
            this.btnNhathuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhathuoc.Location = new System.Drawing.Point(47, 25);
            this.btnNhathuoc.Name = "btnNhathuoc";
            this.btnNhathuoc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnNhathuoc.Size = new System.Drawing.Size(319, 59);
            this.btnNhathuoc.TabIndex = 3;
            this.btnNhathuoc.Text = "NHÀ THUỐC ABC";
            this.btnNhathuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhathuoc.UseVisualStyleBackColor = true;
            this.btnNhathuoc.Click += new System.EventHandler(this.btnNhathuoc_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(0, 940);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.iconButton1.Size = new System.Drawing.Size(176, 120);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Đăng xuất";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCaidat
            // 
            this.btnCaidat.AutoSize = true;
            this.btnCaidat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaidat.FlatAppearance.BorderSize = 0;
            this.btnCaidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaidat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaidat.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnCaidat.IconColor = System.Drawing.Color.White;
            this.btnCaidat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaidat.IconSize = 45;
            this.btnCaidat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaidat.Location = new System.Drawing.Point(0, 820);
            this.btnCaidat.Name = "btnCaidat";
            this.btnCaidat.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.btnCaidat.Size = new System.Drawing.Size(176, 120);
            this.btnCaidat.TabIndex = 15;
            this.btnCaidat.Text = "Cài đặt";
            this.btnCaidat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaidat.UseVisualStyleBackColor = true;
            this.btnCaidat.Click += new System.EventHandler(this.btnCaidat_Click);
            // 
            // btnDanhmuc
            // 
            this.btnDanhmuc.AutoSize = true;
            this.btnDanhmuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhmuc.FlatAppearance.BorderSize = 0;
            this.btnDanhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhmuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhmuc.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal;
            this.btnDanhmuc.IconColor = System.Drawing.Color.White;
            this.btnDanhmuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhmuc.IconSize = 45;
            this.btnDanhmuc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDanhmuc.Location = new System.Drawing.Point(0, 700);
            this.btnDanhmuc.Name = "btnDanhmuc";
            this.btnDanhmuc.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.btnDanhmuc.Size = new System.Drawing.Size(176, 120);
            this.btnDanhmuc.TabIndex = 14;
            this.btnDanhmuc.Text = "Danh mục";
            this.btnDanhmuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDanhmuc.UseVisualStyleBackColor = true;
            this.btnDanhmuc.Click += new System.EventHandler(this.btnDanhmuc_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBaocao.AutoSize = true;
            this.btnBaocao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaocao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnBaocao.IconColor = System.Drawing.Color.White;
            this.btnBaocao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaocao.IconSize = 45;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaocao.Location = new System.Drawing.Point(0, 580);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.btnBaocao.Size = new System.Drawing.Size(176, 120);
            this.btnBaocao.TabIndex = 13;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnKho
            // 
            this.btnKho.AutoSize = true;
            this.btnKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.IconChar = FontAwesome.Sharp.IconChar.BoxArchive;
            this.btnKho.IconColor = System.Drawing.Color.White;
            this.btnKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKho.IconSize = 45;
            this.btnKho.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKho.Location = new System.Drawing.Point(0, 460);
            this.btnKho.Name = "btnKho";
            this.btnKho.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.btnKho.Size = new System.Drawing.Size(176, 120);
            this.btnKho.TabIndex = 12;
            this.btnKho.Text = "Kho";
            this.btnKho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.AutoSize = true;
            this.btnHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.IconChar = FontAwesome.Sharp.IconChar.FileLines;
            this.btnHoadon.IconColor = System.Drawing.Color.White;
            this.btnHoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoadon.IconSize = 45;
            this.btnHoadon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHoadon.Location = new System.Drawing.Point(0, 340);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.btnHoadon.Size = new System.Drawing.Size(176, 120);
            this.btnHoadon.TabIndex = 11;
            this.btnHoadon.Text = "Hoá đơn";
            this.btnHoadon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSize = true;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnBuy.IconColor = System.Drawing.Color.White;
            this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuy.IconSize = 45;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuy.Location = new System.Drawing.Point(0, 220);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.btnBuy.Size = new System.Drawing.Size(176, 120);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Bán hàng";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::NTSF.Properties.Resources.Logoadmin;
            this.picAdmin.Location = new System.Drawing.Point(12, 25);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(162, 101);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // ctCirclePictureBox2
            // 
            this.ctCirclePictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(207)))), ((int)(((byte)(74)))));
            this.ctCirclePictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ctCirclePictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ctCirclePictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.ctCirclePictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ctCirclePictureBox2.BorderSize = 0;
            this.ctCirclePictureBox2.GradientAngle = 50F;
            this.ctCirclePictureBox2.Location = new System.Drawing.Point(60, 0);
            this.ctCirclePictureBox2.Name = "ctCirclePictureBox2";
            this.ctCirclePictureBox2.Size = new System.Drawing.Size(25, 25);
            this.ctCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctCirclePictureBox2.TabIndex = 1;
            this.ctCirclePictureBox2.TabStop = false;
            this.ctCirclePictureBox2.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // ctCirclePictureBox3
            // 
            this.ctCirclePictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ctCirclePictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ctCirclePictureBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ctCirclePictureBox3.BorderColor2 = System.Drawing.Color.HotPink;
            this.ctCirclePictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ctCirclePictureBox3.BorderSize = 0;
            this.ctCirclePictureBox3.GradientAngle = 50F;
            this.ctCirclePictureBox3.Location = new System.Drawing.Point(122, 0);
            this.ctCirclePictureBox3.Name = "ctCirclePictureBox3";
            this.ctCirclePictureBox3.Size = new System.Drawing.Size(25, 25);
            this.ctCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctCirclePictureBox3.TabIndex = 1;
            this.ctCirclePictureBox3.TabStop = false;
            this.ctCirclePictureBox3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ctCirclePictureBox1
            // 
            this.ctCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(207)))), ((int)(((byte)(74)))));
            this.ctCirclePictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ctCirclePictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ctCirclePictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.ctCirclePictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ctCirclePictureBox1.BorderSize = 0;
            this.ctCirclePictureBox1.GradientAngle = 50F;
            this.ctCirclePictureBox1.Location = new System.Drawing.Point(91, 0);
            this.ctCirclePictureBox1.Name = "ctCirclePictureBox1";
            this.ctCirclePictureBox1.Size = new System.Drawing.Size(25, 25);
            this.ctCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctCirclePictureBox1.TabIndex = 0;
            this.ctCirclePictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.dropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCaidat;
        private FontAwesome.Sharp.IconButton btnDanhmuc;
        private FontAwesome.Sharp.IconButton btnBaocao;
        private FontAwesome.Sharp.IconButton btnKho;
        private FontAwesome.Sharp.IconButton btnHoadon;
        private FontAwesome.Sharp.IconButton btnBuy;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private FontAwesome.Sharp.IconButton btnNhathuoc;
        private CTuserControl.CTCirclePictureBox ctCirclePictureBox1;
        private CTuserControl.CTCirclePictureBox ctCirclePictureBox3;
        private CTuserControl.CTCirclePictureBox ctCirclePictureBox2;
        private DoubleBufferPanel panelMenu;
        private DoubleBufferPanel panelLogo;
        private DoubleBufferPanel panel1;
        private DoubleBufferPanel panelDesktop;
        private DoubleBufferPanel panel2;
        private Label lbTime;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CTuserControl.DropdownMenu dropdownMenu1;
        private ToolStripMenuItem dropmenuNhapkho;
        private ToolStripMenuItem dropmenuXuatkho;
        private ToolStripMenuItem dropmenuTonkho;
        private CTuserControl.CTCirclePictureBox ctCirclePictureBox5;
        private CTuserControl.CTCirclePictureBox ctCirclePictureBox4;
    }
}

