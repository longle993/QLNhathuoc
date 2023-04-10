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
    public partial class FormDanhMuc : Form
    {
        private List<HANG_HOA> DanhMucSP;
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            LoadAll();
            loadNhomHang();
            
        }

        private void LoadGrid()
        {   
            try
            {
                this.dataHangHoa.Rows.Clear();
                var groupbyMasp = DanhMucSP.GroupBy(p => p.MA_SP).ToList();
                List<List<HANG_HOA>> dshang = new List<List<HANG_HOA>>();
                foreach(var hang in groupbyMasp)
                {
                    dshang.Add(hang.ToList());
                }
                foreach(List<HANG_HOA> listhh in dshang)
                {
                    int TongTon=0;
                    foreach(HANG_HOA hanghoa in listhh)
                    {
                        TongTon += hanghoa.TONG_TON;
                    }
                    this.dataHangHoa.Rows.Add(listhh[0].MA_SP, listhh[0].TEN_SP, listhh[0].LOAI_SP, "Chi tiết giá vốn", listhh[0].GIA_BAN.ToString("#,#"), TongTon);

                }
                foreach (HANG_HOA hanghoa in this.DanhMucSP)
                {
                }
                lblCountHang.Text = DanhMucSP.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DanhMucSP = HANG_HOA_BUS.Instance.GetHANG_HOAs();
            LoadGrid();
        }

        private void btnTimKiemDanhmuc_Click(object sender, EventArgs e)
        {
            this.DanhMucSP = HANG_HOA_BUS.Instance.FindByName(txtSearchHH.Texts,cbboxNhomhang.Text);
            LoadGrid();
        }

        private void txtSearchHH__TextChanged(object sender, EventArgs e)
        {
            if (txtSearchHH.Text == "")
            {
                LoadAll();
            }
            this.DanhMucSP = HANG_HOA_BUS.Instance.FindByName(txtSearchHH.Texts,cbboxNhomhang.Text);
            LoadGrid();
        }
        private void loadNhomHang()
        {
            this.cbboxNhomhang.Items.Clear();
            List<HANG_HOA> DMSPs = HANG_HOA_BUS.Instance.GetHANG_HOAs();
            foreach (HANG_HOA dmsp in DMSPs)
            {
                if (this.cbboxNhomhang.Items.Contains(dmsp.LOAI_SP))
        
                continue;
                cbboxNhomhang.Items.Add(dmsp.LOAI_SP);
            }
        }

        private void cbboxNhomhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DanhMucSP = HANG_HOA_BUS.Instance.FindByLoaiSP(this.cbboxNhomhang.Text);
            LoadGrid();
        }

        private void dataHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã nhấp vào nút xem chi tiết chưa
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại đang được chỉnh sửa
                DataGridViewRow currentRow = dataHangHoa.Rows[e.RowIndex];

                // Chi tiết dữ liệu trong dòng hiện tại
                if (MessageBox.Show("Bạn có muốn xem chi tiết hàng hoá này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }
            }
        }

        private void dataHangHoa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataHangHoa.Columns[6] is DataGridViewButtonColumn && e.Value != null)
            {
                // Đặt tên cho button
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataHangHoa.Rows[e.RowIndex].Cells[6];
                buttonCell.Value = "Xem Chi tiết";
            }
        }
    }
}
