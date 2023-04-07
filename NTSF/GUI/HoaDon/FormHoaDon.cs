using System;
using System.Collections;
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
using NTSF.GUI.HoaDon;

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
                foreach (HOA_DON hoadon in this.DanhSachHD)
                {
                    
                    this.dataHoaDon.Rows.Add(hoadon.MA_HD, hoadon.TEN_KH, hoadon.NGAY_HD, hoadon.TRI_GIA.ToString("#,#"), hoadon.GHI_CHU );
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

        private void dataHoaDon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewComboBoxEditingControl comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                // Thêm xử lý sự kiện cho ComboBox
                comboBox.SelectedIndexChanged -= new EventHandler(comboBox_SelectedIndexChanged);
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comboBox = sender as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                // Lấy giá trị được chọn trong ComboBox
                string selectedValue = comboBox.SelectedItem as string;

                // Kiểm tra giá trị được chọn
                if (selectedValue == "Xoá HĐ")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataHoaDon.CurrentCell;
                    DataGridViewRow currentRow = dataHoaDon.Rows[currentCell.RowIndex];

                    // Xoá dữ liệu trong dòng hiện tại
                    if (MessageBox.Show("Bạn có chắc chắn xoá khách hàng này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataHoaDon.Rows.Remove(currentRow);
                        string mahoadon = (string)currentRow.Cells[0].Value;
                        CT_HOA_DON_BUS.Instance.RemoveCTHD(mahoadon);
                        HOA_DON_BUS.Instance.RemoveHD(mahoadon);
                    }
                }
                else if (selectedValue == "Xem chi tiết")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataHoaDon.CurrentCell;
                    DataGridViewRow currentRow = dataHoaDon.Rows[currentCell.RowIndex];

                    //Mở Form sửa khách hàng
                    if (MessageBox.Show("Bạn có muốn xem chi tiết hoá đơn này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string mahd = ((string)currentRow.Cells[0].Value).Substring(0,11);
                        FormCTHD formCTHD = new FormCTHD(mahd);
                        formCTHD.ShowDialog();
                        LoadAll();
                        this.Opacity = 0.0;
                    }
                }

                else if (selectedValue == "Sửa Thông tin")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataHoaDon.CurrentCell;
                    DataGridViewRow currentRow = dataHoaDon.Rows[currentCell.RowIndex];

                    if(MessageBox.Show("Bạn có muốn chỉnh sửa Thông tin Hoá đơn này?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mahd = ((string)currentRow.Cells[0].Value).Substring(0, 11);

                    }
                }
            }
        }

        private void btnTimKiemHoadon_Click(object sender, EventArgs e)
        {
            try
            {
                dataHoaDon.Rows.Clear();
                DanhSachHD = HOA_DON_BUS.Instance.FindByName(txtSearchByName.Texts);
                LoadGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không có hoá đơn tương ứng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadAll();
            }
            
        }
    }
}
