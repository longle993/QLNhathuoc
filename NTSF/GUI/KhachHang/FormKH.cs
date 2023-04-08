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
using NTSF.GUI.KhachHang;

namespace NTSF.GUI
{
    public partial class FormKH : Form
    {
        List<KHACH_HANG> DSKH;
        public FormKH()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            try
            {
                this.dataKH.Rows.Clear();
                foreach (KHACH_HANG kh in this.DSKH)
                {
                    this.dataKH.Rows.Add(kh.TEN_KH, kh.GIOI_TINH,kh.SDT );
                }
                lblCountKH.Text = DSKH.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DSKH = KHACH_HANG_BUS.Instance.GetKHACH_HANGs();
            LoadGrid();
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            LoadAll();
        }


        private void txtSearchKH__TextChanged(object sender, EventArgs e)
        {
            if (txtSearchKH.Texts == "")
            {
                LoadAll();
            }
            this.DSKH = KHACH_HANG_BUS.Instance.FindByName(txtSearchKH.Texts);
            LoadGrid();
        }

        private void btnThemmoiKH_Click(object sender, EventArgs e)
        {
            FormThemKH formThemKH = new FormThemKH();
            formThemKH.ShowDialog();
        }


        private void dataKH_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                if (selectedValue == "Xoá KH")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataKH.CurrentCell;
                    DataGridViewRow currentRow = dataKH.Rows[currentCell.RowIndex];

                    // Xoá dữ liệu trong dòng hiện tại
                    if (MessageBox.Show("Bạn có chắc chắn xoá khách hàng này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataKH.Rows.Remove(currentRow);
                        string sdt = (string)currentRow.Cells[2].Value;
                        KHACH_HANG khachhang = DSKH.Where(p => p.SDT == sdt).SingleOrDefault();
                        DSKH.Remove(khachhang);
                        KHACH_HANG_BUS.Instance.RemoveKH(khachhang);
                    }
                }
                else if (selectedValue == "Sửa Thông Tin")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataKH.CurrentCell;
                    DataGridViewRow currentRow = dataKH.Rows[currentCell.RowIndex];

                    //Mở Form sửa khách hàng
                    if(MessageBox.Show("Bạn có muốn sửa thông tin khách hàng này?","Cảnh báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sdt = (string)currentRow.Cells[2].Value;
                        KHACH_HANG khachhang = DSKH.Where(p => p.SDT == sdt).SingleOrDefault();
                        FormSuaKH formSuaKH = new FormSuaKH(khachhang);
                        formSuaKH.ShowDialog();
                        this.Opacity = 0.0;
                    }
                }
            }
        }
    }
}
