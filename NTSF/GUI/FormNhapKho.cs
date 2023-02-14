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
    public partial class FormNhapKho : Form
    {
        private Form currentChildForm;
        public FormNhapKho()
        {
            InitializeComponent();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaoPhieu());         
        }

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
            panelTaoPhieu.Controls.Add(childForm);
            panelTaoPhieu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
