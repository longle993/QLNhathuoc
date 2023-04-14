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
        public HANG_HOA sP=null;
        public PHIEU_NHAP PN = null;
        public DON_VI_TINH DVT = null;
        public CT_PHIEU_NHAP CTPN = null;
        Binding binding;
        public FormTaoPhieu()
        {
            InitializeComponent();
            LoadTimeNow();
            txtGhichu.Texts = "";
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
            lblCountPN.Text = dataCTphieunhap.Rows.Count.ToString();
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
            if( sP is null || PN is null || CTPN is null || DVT is null)
            {
                MessageBox.Show("Bạn phải thêm hàng hoá vào phiếu trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
                PN.GHI_CHU = txtGhichu.Texts;
            DateTime tong = datePN.Value.Date;
            string[] tg = lblHour.Text.Split(':');
            tong.AddHours(int.Parse(tg[0]));
            tong.AddMinutes(int.Parse(tg[1]));

            PN.NGAY_NHAP = tong;
            HANG_HOA_BUS.Instance.AddUpdateDMSP(sP);
            PHIEU_NHAP_BUS.Instance.AddUpdatePN(PN);
            CT_PHIEU_NHAP_BUS.Instance.AddUpdateCTPN(CTPN);
            DON_VI_TINH_BUS.Instance.AddOrUpdateDVT(DVT);
            MessageBox.Show("Đã lưu");

            this.Close();
        }

    }
}

