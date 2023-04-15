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
    public partial class FormTonKho : Form
    { 
        List<HANG_HOA> dsHH;
        List<CT_PHIEU_NHAP> dsPN;
        List<CT_PHIEU_XUAT_HUY> dsPH;
        List<CT_HOA_DON> dsHD;
        public FormTonKho()
        {
            InitializeComponent();
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
            if (ctTimeFrom.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeFrom.Value = DateTime.Now;
            }
        }

        private void btnTimKiemTonKho_Click(object sender, EventArgs e)
        {
            LoadAll();
        }
        private void LoadGrid()
        {

            try
            {
                this.dataTonKho.Rows.Clear();
                foreach (HANG_HOA hh in this.dsHH)
                {
                    Random rd = new Random();

                    CT_PHIEU_NHAP ctpn = dsPN.Where(p => p.MA_SP == hh.MA_SP && p.SO_LO == hh.SO_LO).FirstOrDefault();
                    dsHD = dsHD.Where(p => p.MA_SP == hh.MA_SP && p.SO_LO == hh.SO_LO).ToList();
                    int TongXuatHD = 0;
                    foreach(CT_HOA_DON cthd in dsHD)
                    {
                        TongXuatHD += cthd.SO_LUONG;
                    }
                    DON_VI_TINH dON_VI_TINH = DON_VI_TINH_BUS.Instance.GetDON_VI_TINHs().SingleOrDefault(p=>p.MA_SP == hh.MA_SP && p.SO_LO == hh.SO_LO && p.DVT_KHAC == ctpn.DON_VI_NHAP);
                    dsPH = dsPH.Where(p => p.MA_SP == hh.MA_SP && p.SO_LO == hh.SO_LO).ToList();
                    int tonDau = rd.Next(50, 200);
                    int xuat = 0;
                    foreach(CT_PHIEU_XUAT_HUY ph in dsPH)
                    {
                        xuat += ph.SO_LUONG;
                    }
                    xuat += TongXuatHD;
                    this.dataTonKho.Rows.Add(hh.MA_SP,hh.TEN_SP,hh.LOAI_SP,hh.SO_LO,ctpn.HSD,ctpn.DON_GIA,hh.DVT_CO_BAN, tonDau,xuat,tonDau - xuat);
                }
                //lblCountHD.Text = DanhSachHD.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAll()
        {
            this.dsHH = HANG_HOA_BUS.Instance.GetHANG_HOAs();
            this.dsPN = CT_PHIEU_NHAP_BUS.Instance.GetCT_PHIEU_NHAPs();
            this.dsPH = CT_PHIEU_XUAT_HUY_BUS.Instance.GetCT_PHIEU_XUAT_HUYs();
            this.dsHD = CT_HOA_DON_BUS.Instance.GetAll();
            LoadGrid();
        }
    }
}
