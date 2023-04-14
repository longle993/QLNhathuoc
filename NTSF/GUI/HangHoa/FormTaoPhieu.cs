using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTSF.CTuserControl;
using HotelManagement.CTControls;
using NTSF.DTO;
using NTSF.BUS;

namespace NTSF.GUI
{
    public partial class FormTaoPhieu : Form
    {
        private Form currentChildForm;
        public HANG_HOA sP;
        public PHIEU_NHAP PN;
        public DON_VI_TINH DVT;
        public CT_PHIEU_NHAP CTPN;

        public FormTaoPhieu()
        {
            InitializeComponent();
            LoadTimeNow();

        }
        private void CheckStatus()
        {

        }

        private void LoadTimeNow()
        {
            this.lblHour.Text = DateTime.Now.ToString("hh:mm");
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemHang(this));
            

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
            PN.GHI_CHU = txtGhichu.Texts;
            HANG_HOA_BUS.Instance.AddUpdateDMSP(sP);
            PHIEU_NHAP_BUS.Instance.AddUpdatePN(PN);
            CT_PHIEU_NHAP_BUS.Instance.AddUpdateCTPN(CTPN);
            DON_VI_TINH_BUS.Instance.AddOrUpdateDVT(DVT);
            MessageBox.Show("Đã lưu");
            this.Close();
        }

    }
}

