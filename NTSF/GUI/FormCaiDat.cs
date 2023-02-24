using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormCaiDat : Form
    {
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCDTK.Controls.Add(childForm);
            panelCDTK.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public FormCaiDat()
        {
            InitializeComponent();
        }

        private void btnCDTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCDTK());
        }

        private void btnCDHT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCDHT());
        }
    }
}
