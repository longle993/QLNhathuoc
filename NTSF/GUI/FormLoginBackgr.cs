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
    public partial class FormLoginBackgr : Form
    {
        private Form currentChildForm;

        public FormLoginBackgr()
        {
            InitializeComponent();
            OpenChildForm(new FormLogin(this));

        }

        public void OpenChildForm(Form childForm)
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
            panelLogin.Controls.Add(childForm);
            panelLogin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormLoginBackgr_Load(object sender, EventArgs e)
        {
            
        }
    }
}
