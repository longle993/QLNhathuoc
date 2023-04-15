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
    public partial class FormListHangbanhang : Form
    {
        public List<HANG_HOA> dsHH = new List<HANG_HOA>();
        public FormListHangbanhang()
        {
            InitializeComponent();
        }

        private void txtHangBan__TextChanged(object sender, EventArgs e)
        {
            this.dsHH = HANG_HOA_BUS.Instance.FindByName(txtHangBan.Texts,null);
            AutoCompleteStringCollection autoload = new AutoCompleteStringCollection();
            foreach (HANG_HOA hanghoa in this.dsHH)
            {
                autoload.Add($"{hanghoa.TEN_SP} \tSố lô: {hanghoa.SO_LO}");
            }
            txtHangBan.TextBoxControl.AutoCompleteCustomSource = autoload;
        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            if (txtHangBan.Texts is null || txtHangBan.Texts == "")
            {
                MessageBox.Show("Không có hàng hoá cần tìm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = txtHangBan.Texts.LastIndexOf(':');
            string soLO = txtHangBan.Texts.Substring(index + 2);
            string[] tenSP = txtHangBan.Texts.Split(' ');
            dsHH = HANG_HOA_BUS.Instance.FindByName(tenSP[0], null);
            HANG_HOA addHH = dsHH.SingleOrDefault(p => p.SO_LO == soLO);
            CT_PHIEU_NHAP findHSD = CT_PHIEU_NHAP_BUS.Instance.GetCT_PHIEU_NHAPs().SingleOrDefault(p => p.MA_SP == addHH.MA_SP && p.SO_LO == addHH.SO_LO);
            GIA_VON giaVon = GIA_VON_BUS.Instance.GetGIA_VONs().SingleOrDefault(p => p.MA_SP == findHSD.MA_SP && p.SO_LO == findHSD.SO_LO);
            this.dataHangBan.Rows.Add(addHH.TEN_SP,addHH.DVT_CO_BAN,addHH.TONG_TON,addHH.GIA_BAN.ToString("#,#"),(addHH.TONG_TON*addHH.GIA_BAN).ToString("#,#"));
           /* decimal tonghuy = 0;
            foreach (DataGridViewRow row in dataHangBan.Rows)
            {
                decimal giaTri;
                if (decimal.TryParse(row.Cells[7].Value.ToString(), out giaTri))
                {
                    tonghuy += giaTri;
                }
            }*/
            txtHangBan.Texts = string.Empty;
        }

        private void dataHangBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataHangBan.Columns[5] is DataGridViewButtonColumn && e.Value != null)
            {
                // Đặt tên cho button
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataHangBan.Rows[e.RowIndex].Cells[5];
                buttonCell.Value = "Xoá";
            }
        }

        private void dataHangBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại đang được chỉnh sửa
                DataGridViewRow currentRow = dataHangBan.Rows[e.RowIndex];

                if (MessageBox.Show("Bạn có muốn xoá hàng hoá này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.dataHangBan.Rows.Remove(currentRow);
                    HANG_HOA hh = new HANG_HOA();
                    hh = HANG_HOA_BUS.Instance.GetHANG_HOAs().SingleOrDefault(p => p.MA_SP == currentRow.Cells[0].Value.ToString() && p.TEN_SP == currentRow.Cells[1].Value.ToString());
                    dsHH.Remove(hh);
                }
            }
        }

        private void dataHangBan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataHangBan.Rows)
            {
                int SL;
                decimal giaban;
                if(int.TryParse(row.Cells[2].Value.ToString(),out SL))
                {
                    if (decimal.TryParse(row.Cells[3].Value.ToString(), out giaban))
                    {
                        row.Cells[4].Value = (giaban *SL).ToString("#,#");
                    }
                }
                
            }
        }
    }
}
