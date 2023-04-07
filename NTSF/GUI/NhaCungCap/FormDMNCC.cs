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
            lblCountNCC.Text = DanhSachNCC.Count.ToString();

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

        private void dataNCC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                if (selectedValue == "Xoá NCC")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataNCC.CurrentCell;
                    DataGridViewRow currentRow = dataNCC.Rows[currentCell.RowIndex];

                    // Xoá dữ liệu trong dòng hiện tại
                    if (MessageBox.Show("Bạn có chắc chắn xoá nhà cung cấp này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            dataNCC.Rows.Remove(currentRow);
                            string mancc = (string)currentRow.Cells[0].Value;
                            NHA_CUNG_CAP ncc = DanhSachNCC.Where(p => p.MA_NCC == mancc).SingleOrDefault();
                            DanhSachNCC.Remove(ncc);
                            NHA_CUNG_CAP_BUS.Instance.RemoveNCC(ncc);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Không thể xoá Nhà cung cấp vì trong phiếu nhập của bạn có Nhà cung cấp này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (selectedValue == "Sửa Thông Tin")
                {
                    // Lấy dòng hiện tại đang được chỉnh sửa
                    DataGridViewCell currentCell = dataNCC.CurrentCell;
                    DataGridViewRow currentRow = dataNCC.Rows[currentCell.RowIndex];

                    // Mở Form sửa thông tin
                    FormThemMoiNCC formThemMoiNCC = new FormThemMoiNCC();
                    formThemMoiNCC.ShowDialog();
                    this.Opacity = 0.0;
                }
            }
        }
    }
}
