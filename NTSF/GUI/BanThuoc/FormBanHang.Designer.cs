
namespace NTSF.GUI
{
    partial class FormBanHang
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
            this.panelTTTT = new System.Windows.Forms.Panel();
            this.panelDSHH = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTTTT
            // 
            this.panelTTTT.BackColor = System.Drawing.Color.White;
            this.panelTTTT.Location = new System.Drawing.Point(1032, 16);
            this.panelTTTT.Name = "panelTTTT";
            this.panelTTTT.Size = new System.Drawing.Size(663, 969);
            this.panelTTTT.TabIndex = 0;
            // 
            // panelDSHH
            // 
            this.panelDSHH.BackColor = System.Drawing.Color.White;
            this.panelDSHH.Location = new System.Drawing.Point(41, 16);
            this.panelDSHH.Name = "panelDSHH";
            this.panelDSHH.Size = new System.Drawing.Size(950, 411);
            this.panelDSHH.TabIndex = 1;
            // 
            // FormBanHang
            // 
            this.DoubleBuffered = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1722, 929);
            this.Controls.Add(this.panelDSHH);
            this.Controls.Add(this.panelTTTT);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTTTT;
        private System.Windows.Forms.Panel panelDSHH;
    }
}