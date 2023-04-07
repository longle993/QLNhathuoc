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
        private List<DANH_MUC_SP> DanhMucSP;
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
                foreach(DANH_MUC_SP hanghoa in this.DanhMucSP)
                {
                    this.dataHangHoa.Rows.Add(hanghoa.MA_SP, hanghoa.TEN_SP, hanghoa.NHOM_SP,"Chi tiết giá vốn",hanghoa.GIA_BAN, hanghoa.TONG_TON);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DanhMucSP = DANH_MUC_SP_BUS.Instance.GetDANH_MUC_SP_DAOs();
            lblCountHang.Text = DanhMucSP.Count.ToString();
            LoadGrid();
        }

        private void btnTimKiemDanhmuc_Click(object sender, EventArgs e)
        {
            this.DanhMucSP = DANH_MUC_SP_BUS.Instance.FindByName(txtSearchHH.Texts,cbboxNhomhang.Text);
            LoadGrid();
        }

        private void txtSearchHH__TextChanged(object sender, EventArgs e)
        {
            if (txtSearchHH.Text == "")
            {
                LoadAll();
            }
            this.DanhMucSP = DANH_MUC_SP_BUS.Instance.FindByName(txtSearchHH.Texts,cbboxNhomhang.Text);
            LoadGrid();
        }
        private void loadNhomHang()
        {
            this.cbboxNhomhang.Items.Clear();
            List<DANH_MUC_SP> DMSPs = DANH_MUC_SP_BUS.Instance.GetDANH_MUC_SP_DAOs();
            foreach (DANH_MUC_SP dmsp in DMSPs)
            {
                if (this.cbboxNhomhang.Items.Contains(dmsp.NHOM_SP))
        
                continue;
                cbboxNhomhang.Items.Add(dmsp.NHOM_SP);
            }
        }

        private void cbboxNhomhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DanhMucSP = DANH_MUC_SP_BUS.Instance.FindByLoaiSP(this.cbboxNhomhang.Text);
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
