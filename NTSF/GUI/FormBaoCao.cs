using NTSF.BUS;
using NTSF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NTSF.Application_Class;
namespace NTSF.GUI
{

    public partial class FormBaoCao : Form
    {
        List<HOA_DON> hoaDons;
        List<PHIEU_NHAP> ListPN;
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btnTimKiemBC_Click(object sender, EventArgs e)
        {
            hoaDons = HOA_DON_BUS.Instance.GetBaoCao(ctTimeFrom.Value, ctTimeTo.Value);
            ListPN = PHIEU_NHAP_BUS.Instance.GetBaoCao(ctTimeFrom.Value, ctTimeTo.Value);
            LoadGrid();
        }

        private void ctTimeFrom_ValueChanged(object sender, EventArgs e)
        {

            if (ctTimeFrom.Value > DateTime.Now || ctTimeFrom.Value > ctTimeTo.Value)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeFrom.Value = ctTimeTo.Value;
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

        private void LoadGrid()
        {
            try
            {
                this.dataBaoCao.Rows.Clear();

                SortedDictionary<DateTime, Pair<decimal, decimal>> DSNhap = new SortedDictionary<DateTime, Pair<decimal, decimal>>();
                foreach (HOA_DON hd in hoaDons)
                {
                    if (!DSNhap.Keys.Contains(hd.NGAY_HD.Date))
                        DSNhap.Add(hd.NGAY_HD.Date, new Pair<decimal, decimal>(hd.TRI_GIA, 0));
                    else
                        DSNhap[hd.NGAY_HD].First += hd.TRI_GIA;

                }
                foreach (PHIEU_NHAP pHIEU_NHAP1 in ListPN)
                {
                    if (!DSNhap.Keys.Contains(pHIEU_NHAP1.NGAY_NHAP.Date))
                    {
                        DSNhap.Add(pHIEU_NHAP1.NGAY_NHAP.Date, new Pair<decimal, decimal>(0, pHIEU_NHAP1.TRI_GIA));
                    }
                    else
                    {
                        DSNhap[pHIEU_NHAP1.NGAY_NHAP.Date].Second += pHIEU_NHAP1.TRI_GIA;
                    }
                }

                foreach (KeyValuePair<DateTime, Pair<decimal, decimal>> nhap in DSNhap)
                {
                    decimal loiNhuan = nhap.Value.First - nhap.Value.Second;
                    //if()
                    this.dataBaoCao.Rows.Add(nhap.Key.ToString("dd/MM/yyyy"), nhap.Value.First, nhap.Value.Second, loiNhuan);
                }
                lblCountBC.Text = dataBaoCao.Rows.Count.ToString();
                SumBaoCao(dataBaoCao);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.hoaDons = HOA_DON_BUS.Instance.GetHOA_DONs();
            LoadGrid();
            lblCountBC.Text = dataBaoCao.Rows.Count.ToString();

        }

        private void SumBaoCao(DataGridView dataBaoCao)
        {
            decimal tonghd = 0;
            decimal tongvon = 0;
            decimal tongloi = 0;
            foreach (DataGridViewRow row in dataBaoCao.Rows)
            {
                decimal giaTri;
                decimal giaTriVon;
                decimal giaTriLoi;

                if (decimal.TryParse(row.Cells[1].Value.ToString(), out giaTri))
                {
                    tonghd += giaTri;
                }
                if (decimal.TryParse(row.Cells[2].Value.ToString(), out giaTriVon))
                {
                    tongvon += giaTriVon;
                }
                if (decimal.TryParse(row.Cells[3].Value.ToString(), out giaTriLoi))
                {
                    tongloi += giaTriLoi;
                }
            }
            lblTonghoadon.Text = tonghd.ToString("#,#");
            lblTonggiavon.Text = tongvon.ToString("#,#");
            lblTongloinhuan.Text = tongloi.ToString("#,#");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
