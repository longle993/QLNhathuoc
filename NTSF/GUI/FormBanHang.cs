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
    public partial class FormBanHang : Form
    {
        private Form currentChildForm;
        public FormBanHang()
        {
            InitializeComponent();
            OpenChildForm(new FormThanhToan(), panelTTTT);
            OpenChildForm(new FormListHangbanhang(), panelDSHH);
        }

        private void OpenChildForm(Form childForm, Panel panel)
        {
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Bán hàng: Mặc định khách thanh toán = khách cần trả
    }
}
