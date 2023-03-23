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
    public partial class FormDMNCC : Form
    {
        List<NHA_CUNG_CAP> DanhSachNCC;
        public FormDMNCC()
        {
            InitializeComponent();
        }

        private void btnThemmoiNCC_Click(object sender, EventArgs e)
        {
            FormThemMoiNCC formThemMoiNCC = new FormThemMoiNCC();
            formThemMoiNCC.ShowDialog();
            this.Opacity = 0.0;
        }

        private void LoadGrid()
        {
            try
            {
                this.dataNCC.Rows.Clear();
                foreach(NHA_CUNG_CAP ncc in DanhSachNCC)
                {
                    this.dataNCC.Rows.Add(ncc.MA_NCC, ncc.TEN_NCC, ncc.MA_SO_THUE, ncc.SDT, ncc.GHI_CHU);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DanhSachNCC = NHA_CUNG_CAP_BUS.Instance.GetNHA_CUNG_CAPs();
            LoadGrid();
        }

        private void FormDMNCC_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtSearchNCC__TextChanged(object sender, EventArgs e)
        {
            if(txtSearchNCC.Texts == "")
            {
                LoadAll();
            }
                this.DanhSachNCC = NHA_CUNG_CAP_BUS.Instance.FindByName(txtSearchNCC.Texts);
                LoadGrid();          
        }
    }
}
