using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTSF.DTO;
using NTSF.BUS;
namespace NTSF.GUI
{
    public partial class FormXuatKho : Form
    {
        private Form currentChildForm;
        List<PHIEU_XUAT_HUY> lstXuatHuy;
        public FormXuatKho()
        {
            InitializeComponent();
        }

        private void btnXuatHuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXuatHuy());
            LoadAll();
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
            panelXH.Controls.Add(childForm);
            panelXH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormXuatKho_Load(object sender, EventArgs e)
        {
            lstXuatHuy = PHIEU_XUAT_HUY_BUS.Instance.GetPHIEU_XUAT_HUYs();
            LoadAll();
        }

        private void LoadGrid()
        {
            try
            {
                this.dataXuatHuy.Rows.Clear();
                foreach (PHIEU_XUAT_HUY huy in this.lstXuatHuy)
                {

                    this.dataXuatHuy.Rows.Add(huy.MA_PHIEU,huy.NGAY_XUAT.ToString("dd/MM/yyyy"),huy.TRI_GIA.ToString("#,#"),huy.GHI_CHU);
                }
                lblCountPhieuHuy.Text = dataXuatHuy.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.lstXuatHuy = PHIEU_XUAT_HUY_BUS.Instance.GetPHIEU_XUAT_HUYs();
            LoadGrid();
        }

        private void ctTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            if (ctTimeFrom.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeFrom.Value = DateTime.Now;
            }
        }

        private void ctTimeTo_ValueChanged(object sender, EventArgs e)
        {
            if (ctTimeTo.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeTo.Value = DateTime.Now;
            }
        }
    }
}
