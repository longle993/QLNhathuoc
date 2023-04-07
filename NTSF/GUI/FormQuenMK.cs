﻿using System;
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
    public partial class FormQuenMK : Form
    {
        private Form currentChildForm;
        public FormQuenMK()
        {
            InitializeComponent();
        }

        private void btnKTOTP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDatLaiMK());
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
            panelQuenMK.Controls.Add(childForm);
            panelQuenMK.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
