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
    public partial class FormTaoPhieu : Form
    {
        private Form currentChildForm;
        public FormTaoPhieu()
        {
            InitializeComponent();
            LoadTimeNow();
        }

        private void LoadTimeNow()
        {
            this.lblHour.Text = DateTime.Now.ToString("hh:mm");
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemHang());
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
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
            panelTaoPhieuThem.Controls.Add(childForm);
            panelTaoPhieuThem.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu");
            this.Close();
        }
    }
}

