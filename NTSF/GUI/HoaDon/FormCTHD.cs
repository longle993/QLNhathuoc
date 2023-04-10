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

namespace NTSF.GUI.HoaDon
{
    public partial class FormCTHD : Form
    {
        List<CT_HOA_DON> DSCTHD;
        List<KHACH_HANG> KHBan;
        List<NHAN_VIEN> NVBan;
        HOA_DON hoadon = new HOA_DON();
        public FormCTHD()
        {
            InitializeComponent();
        }
        public FormCTHD(string mahoadon)
        {
            InitializeComponent();
            lblMaHD.Text = mahoadon;
        }

        private void LoadGrid()
        {
            try
            {
                this.dataCTHD.Rows.Clear();
                foreach (CT_HOA_DON cthds in this.DSCTHD)
                {
                    HANG_HOA sp = HANG_HOA_BUS.Instance.GetTenSP(cthds.MA_SP);
                    this.dataCTHD.Rows.Add(cthds.MA_SP,sp.TEN_SP, cthds.DVT, cthds.SO_LUONG, cthds.CHIET_KHAU);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.DSCTHD = CT_HOA_DON_BUS.Instance.GetCT_HOA_DONs(this.lblMaHD.Text);
            hoadon = HOA_DON_BUS.Instance.GetHDforCTHD(lblMaHD.Text);
            this.ctDateHD.Value = hoadon.NGAY_HD;
            this.txtGioban.Texts = hoadon.NGAY_HD.ToString("HH");
            this.txtPhutban.Texts = hoadon.NGAY_HD.ToString("mm");
            this.txtTenKH.Texts = hoadon.TEN_KH;
            this.txtTenNV.Texts = NHAN_VIEN_BUS.Instance.GetNHAN_VIENs().SingleOrDefault(p=>p.MA_NV == hoadon.MA_NV).TEN_NV;
            LoadGrid();

        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            LoadAll();
        }


        private void btnDongCTHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenKH__TextChanged(object sender, EventArgs e)
        {
            this.KHBan = KHACH_HANG_BUS.Instance.GetKHACH_HANGs();
            
            AutoCompleteStringCollection autoload = new AutoCompleteStringCollection();
            foreach (KHACH_HANG kh in this.KHBan)
            {
                autoload.Add($"{kh.SDT.Trim(' ')} - {kh.TEN_KH}");
            }
            txtTenKH.TextBoxControl.AutoCompleteCustomSource = autoload;
        }

        private void txtTenNV__TextChanged(object sender, EventArgs e)
        {
            this.NVBan = NHAN_VIEN_BUS.Instance.GetNHAN_VIENs();

            AutoCompleteStringCollection autoload = new AutoCompleteStringCollection();
            foreach (NHAN_VIEN nv in this.NVBan)
            {
                autoload.Add($"{nv.TEN_NV}");
            }
            txtTenNV.TextBoxControl.AutoCompleteCustomSource = autoload;
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            NHAN_VIEN nv = NVBan.SingleOrDefault(p => p.TEN_NV == txtTenNV.Texts);
            hoadon.MA_HD = lblMaHD.Text;
            hoadon.NGAY_HD = ctDateHD.Value;
            hoadon.TEN_KH = txtTenKH.Texts;
            hoadon.MA_NV = nv.MA_NV;
            HOA_DON_BUS.Instance.AddOrUpdate(hoadon);
            MessageBox.Show("Đã lưu");
            this.Close();
        }
    }
}
