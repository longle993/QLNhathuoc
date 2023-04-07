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
    public partial class FormNhanVien : Form
    {
        List<NHAN_VIEN> DSNV;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemmoiNV_Click(object sender, EventArgs e)
        {
            FormThemNV formThemNV = new FormThemNV();
            formThemNV.ShowDialog();
            this.Opacity = 0.0;
        }
        private void LoadGrid()
        {
            try
            {
                this.dataNV.Rows.Clear();
                foreach(NHAN_VIEN nv in this.DSNV)
                {
                    this.dataNV.Rows.Add(nv.MA_NV,nv.TEN_NV, nv.SDT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DSNV = NHAN_VIEN_BUS.Instance.GetNHAN_VIENs();
            LoadGrid();
            lblCountNV.Text = DSNV.Count.ToString();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtSearchNV__TextChanged(object sender, EventArgs e)
        {
            if(txtSearchNV.Texts == "")
            {
                LoadAll();
            }
            this.DSNV = NHAN_VIEN_BUS.Instance.FindByName(txtSearchNV.Texts);
            LoadGrid();
        }

        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã nhấp vào nút xem chi tiết chưa
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại đang được chỉnh sửa
                DataGridViewRow currentRow = dataNV.Rows[e.RowIndex];


                // Chi tiết dữ liệu trong dòng hiện tại
                if (MessageBox.Show("Bạn có chắc chắn xoá nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataNV.Rows.Remove(currentRow);
                    string sdt = (string)currentRow.Cells[1].Value;
                    NHAN_VIEN nv = DSNV.Where(p => p.SDT == sdt).SingleOrDefault();
                    DSNV.Remove(nv);
                    NHAN_VIEN_BUS.Instance.RemoveNV(nv);
                }
            }
        }

        private void dataNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataNV.Columns[3] is DataGridViewButtonColumn && e.Value != null)
            {
                // Đặt tên cho button
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataNV.Rows[e.RowIndex].Cells[3];
                buttonCell.Value = "Xoá";
            }
        }
    }
}
