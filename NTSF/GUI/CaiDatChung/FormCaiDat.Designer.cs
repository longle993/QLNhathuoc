
namespace NTSF.GUI
{
    partial class FormCaiDat
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCDTK = new FontAwesome.Sharp.IconButton();
            this.panelBtnHT = new NTSF.CTuserControl.AdvancedPanel();
            this.btnCDHT = new FontAwesome.Sharp.IconButton();
            this.panelBtnTK = new NTSF.CTuserControl.AdvancedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCDTK = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBtnHT.SuspendLayout();
            this.panelBtnTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCDTK, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1650, 906);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelBtnHT);
            this.panel1.Controls.Add(this.panelBtnTK);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 900);
            this.panel1.TabIndex = 1;
            // 
            // btnCDTK
            // 
            this.btnCDTK.BackColor = System.Drawing.Color.Transparent;
            this.btnCDTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCDTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCDTK.FlatAppearance.BorderSize = 0;
            this.btnCDTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDTK.ForeColor = System.Drawing.Color.Black;
            this.btnCDTK.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCDTK.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.btnCDTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCDTK.IconSize = 35;
            this.btnCDTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDTK.Location = new System.Drawing.Point(0, 0);
            this.btnCDTK.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnCDTK.Name = "btnCDTK";
            this.btnCDTK.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnCDTK.Size = new System.Drawing.Size(327, 50);
            this.btnCDTK.TabIndex = 0;
            this.btnCDTK.Text = "           Cài đặt tài khoản";
            this.btnCDTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDTK.UseVisualStyleBackColor = false;
            this.btnCDTK.Click += new System.EventHandler(this.btnCDTK_Click);
            // 
            // panelBtnHT
            // 
            this.panelBtnHT.BackColor = System.Drawing.Color.White;
            this.panelBtnHT.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.panelBtnHT.Controls.Add(this.btnCDHT);
            this.panelBtnHT.EdgeWidth = 2;
            this.panelBtnHT.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelBtnHT.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelBtnHT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBtnHT.Location = new System.Drawing.Point(40, 208);
            this.panelBtnHT.Name = "panelBtnHT";
            this.panelBtnHT.RectRadius = 10;
            this.panelBtnHT.ShadowColor = System.Drawing.Color.Transparent;
            this.panelBtnHT.ShadowShift = 0;
            this.panelBtnHT.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.panelBtnHT.Size = new System.Drawing.Size(327, 50);
            this.panelBtnHT.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelBtnHT.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.panelBtnHT.TabIndex = 54;
            // 
            // btnCDHT
            // 
            this.btnCDHT.BackColor = System.Drawing.Color.Transparent;
            this.btnCDHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCDHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCDHT.FlatAppearance.BorderSize = 0;
            this.btnCDHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDHT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDHT.ForeColor = System.Drawing.Color.Black;
            this.btnCDHT.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.btnCDHT.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.btnCDHT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCDHT.IconSize = 35;
            this.btnCDHT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDHT.Location = new System.Drawing.Point(0, 0);
            this.btnCDHT.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnCDHT.Name = "btnCDHT";
            this.btnCDHT.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnCDHT.Size = new System.Drawing.Size(327, 50);
            this.btnCDHT.TabIndex = 0;
            this.btnCDHT.Text = "           Cài đặt hệ thống";
            this.btnCDHT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDHT.UseVisualStyleBackColor = false;
            this.btnCDHT.Click += new System.EventHandler(this.btnCDHT_Click);
            // 
            // panelBtnTK
            // 
            this.panelBtnTK.BackColor = System.Drawing.Color.White;
            this.panelBtnTK.BackgroundGradientMode = NTSF.CTuserControl.AdvancedPanel.PanelGradientMode.Vertical;
            this.panelBtnTK.Controls.Add(this.btnCDTK);
            this.panelBtnTK.EdgeWidth = 2;
            this.panelBtnTK.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelBtnTK.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelBtnTK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBtnTK.Location = new System.Drawing.Point(38, 116);
            this.panelBtnTK.Name = "panelBtnTK";
            this.panelBtnTK.RectRadius = 10;
            this.panelBtnTK.ShadowColor = System.Drawing.Color.Transparent;
            this.panelBtnTK.ShadowShift = 0;
            this.panelBtnTK.ShadowStyle = NTSF.CTuserControl.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.panelBtnTK.Size = new System.Drawing.Size(327, 50);
            this.panelBtnTK.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelBtnTK.Style = NTSF.CTuserControl.AdvancedPanel.BevelStyle.Flat;
            this.panelBtnTK.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 38);
            this.label6.TabIndex = 52;
            this.label6.Text = "CÀI ĐẶT";
            // 
            // panelCDTK
            // 
            this.panelCDTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCDTK.Location = new System.Drawing.Point(553, 3);
            this.panelCDTK.Name = "panelCDTK";
            this.panelCDTK.Size = new System.Drawing.Size(1094, 900);
            this.panelCDTK.TabIndex = 2;
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1722, 929);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaiDat";
            this.Text = "FormCaiDat";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBtnHT.ResumeLayout(false);
            this.panelBtnTK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private CTuserControl.AdvancedPanel panelBtnHT;
        private FontAwesome.Sharp.IconButton btnCDHT;
        private CTuserControl.AdvancedPanel panelBtnTK;
        private FontAwesome.Sharp.IconButton btnCDTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelCDTK;
    }
}