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

namespace NTSF.GUI.HoaDon
{
    public partial class FormCTHD : Form
    {
        List<CT_HOA_DON> DSCTHD;
        public FormCTHD()
        {
            InitializeComponent();
        }
        public FormCTHD(string mahoadon)
        {
            InitializeComponent();
            lblMaHD.Text = mahoadon;

        }

        private void LoadGrid()
        {
            try
            {
                this.dataCTHD.Rows.Clear();
                foreach (CT_HOA_DON cthds in this.DSCTHD)
                {

                    this.dataCTHD.Rows.Add(cthds.MA_SP, cthds.DVT, cthds.SO_LUONG, cthds.CHIET_KHAU);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DSCTHD = CT_HOA_DON_BUS.Instance.GetCT_HOA_DONs(this.lblMaHD.Text);
            LoadGrid();

        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            LoadAll();
        }
    }
}
