using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTSF.BUS;
using NTSF.DTO;

namespace NTSF.GUI
{
    public partial class FormHoaDon : Form
    {
        private List<HOA_DON> DanhSachHD;
        public FormHoaDon()
        {
            InitializeComponent();
        }


        private void LoadGrid()
        {
            try
            {
                this.dataHoaDon.Rows.Clear();
                foreach(HOA_DON hoadon in this.DanhSachHD)
                {
                    this.dataHoaDon.Rows.Add(hoadon.MA_HD, hoadon.NGAY_HD, hoadon.MA_NV, hoadon.TEN_KH,hoadon.MA_PTTT, hoadon.TRI_GIA, hoadon.GHI_CHU);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DanhSachHD = HOA_DON_BUS.Instance.GetHOA_DONs();
            LoadGrid();
            lblCountHD.Text = DanhSachHD.Count.ToString();

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadAll();

        }

        private void txtSearchByName__TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
