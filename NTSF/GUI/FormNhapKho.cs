using NTSF.BUS;
using NTSF.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormNhapKho : Form
    {
        private Form currentChildForm;
        List<PHIEU_NHAP> DSPN;
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

        private void ctTimeTo_ValueChanged(object sender, EventArgs e)
        {
            if (ctTimeTo.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeTo.Value = DateTime.Now;
            }
        }

        private void ctTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            if (ctTimeFrom.Value > DateTime.Now || ctTimeFrom.Value > ctTimeTo.Value)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeFrom.Value = ctTimeTo.Value;
            }
        }

        private void LoadGrid()
        {
            try
            {
                this.dataPhieuNhap.Rows.Clear();
                foreach (PHIEU_NHAP pn in this.DSPN)
                {
                    this.dataPhieuNhap.Rows.Add(pn.MA_PHIEU, pn.NGAY_NHAP, pn.TRI_GIA.ToString("#,#"), pn.GHI_CHU);
                }
                lblCountPN.Text = DSPN.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DSPN = PHIEU_NHAP_BUS.Instance.GetPHIEU_NHAPs();
            LoadGrid();
        }

        private void FormNhapKho_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtTKPNNhapKho__TextChanged(object sender, EventArgs e)
        {
            if (txtTKPNNhapKho.Texts == "0" || txtTKPNNhapKho.Texts is null)
            {
                LoadAll();
            }
            DSPN = PHIEU_NHAP_BUS.Instance.FindByMaPN(txtTKPNNhapKho.Texts);
            LoadGrid();
        }

        private void btnTimKiemPN_Click(object sender, EventArgs e)
        {
            try
            {
                dataPhieuNhap.Rows.Clear();
                DSPN = PHIEU_NHAP_BUS.Instance.FindByName(txtSearchHHNK.Texts, txtTKPNNhapKho.Texts, ctTimeFrom.Value, ctTimeTo.Value);
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có phiếu nhập tương ứng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadAll();
            }
        }
    }
}
