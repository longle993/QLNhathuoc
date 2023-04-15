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
    public partial class FormXuatHuy : Form
    {
        NhaThuoc db = new NhaThuoc();
        List<HANG_HOA> dsHH;
        public FormXuatHuy()
        {
            InitializeComponent();
            lblHour.Text = DateTime.Now.ToString("HH : mm");
        }

        private void btnTroVeXuatHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataPhieuXuatHuy.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu trống!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Lấy thời gian xuất huỷ
            DateTime tong = ctTimeOut.Value.Date;
            string[] tg = lblHour.Text.Split(':');
            tong.AddHours(int.Parse(tg[0]));
            tong.AddMinutes(int.Parse(tg[1]));


            //Thêm phiếu xuất huỷ
            PHIEU_XUAT_HUY pH = new PHIEU_XUAT_HUY();
            pH.MA_PHIEU = LoadMaPHAuto();
            pH.NGAY_XUAT = tong;
            pH.TRI_GIA = decimal.Parse(lblTong.Text);
            pH.GHI_CHU = txtGhichu.Texts;

            db.PHIEU_XUAT_HUY.Add(pH);


            //Thêm chi tiết xuất huỷ

            foreach (DataGridViewRow row in dataPhieuXuatHuy.Rows)
            {
                string a;
                CT_PHIEU_XUAT_HUY ctp = new CT_PHIEU_XUAT_HUY();
                ctp.MA_PHIEU = pH.MA_PHIEU.ToString();
                ctp.MA_SP = row.Cells[0].Value.ToString();
                ctp.SO_LO = row.Cells[2].Value.ToString();
                ctp.DVT = row.Cells[4].Value.ToString();
                int soLuong;
                if (int.TryParse(row.Cells[5].Value.ToString(), out soLuong))
                {
                    ctp.SO_LUONG = soLuong;
                }
                else
                {
                    MessageBox.Show("KHông thể chuyển đổi!");
                }
                ctp.LY_DO = row.Cells[6].Value.ToString() == null || row.Cells[6].Value.ToString() == ""? "Không có" : row.Cells[6].Value.ToString();
                db.CT_PHIEU_XUAT_HUY.Add(ctp);
                db.SaveChanges();
            }

            MessageBox.Show("Đã lưu!");
            this.Close();
        }
        private string LoadMaPHAuto()
        {
            List<PHIEU_XUAT_HUY> dsPH = PHIEU_XUAT_HUY_BUS.Instance.GetPHIEU_XUAT_HUYs();
            string maph = "";
            try
            {
                int count = dsPH.Count + 1;
                maph = $"PH{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("dd")}{count.ToString("000")}";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return maph;
        }

        private void txtHuyhang__TextChanged(object sender, EventArgs e)
        {
            dsHH = HANG_HOA_BUS.Instance.FindByName(txtHuyhang.Texts, null);
            AutoCompleteStringCollection autoload = new AutoCompleteStringCollection();
            foreach (HANG_HOA hanghoa in this.dsHH)
            {
                autoload.Add($"{hanghoa.TEN_SP} \tSố lô: {hanghoa.SO_LO}");
            }
            txtHuyhang.TextBoxControl.AutoCompleteCustomSource = autoload;
        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            if (txtHuyhang.Texts is null || txtHuyhang.Texts == "")
            {
                MessageBox.Show("Không có hàng hoá cần tìm","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int index = txtHuyhang.Texts.LastIndexOf(':');
            string soLO = txtHuyhang.Texts.Substring(index + 2);
            string[] tenSP = txtHuyhang.Texts.Split(' ');
            dsHH = HANG_HOA_BUS.Instance.FindByName(tenSP[0], null);
            HANG_HOA addHH = dsHH.SingleOrDefault(p => p.SO_LO == soLO);
            CT_PHIEU_NHAP findHSD = CT_PHIEU_NHAP_BUS.Instance.GetCT_PHIEU_NHAPs().SingleOrDefault(p => p.MA_SP == addHH.MA_SP && p.SO_LO == addHH.SO_LO);
            GIA_VON giaVon = GIA_VON_BUS.Instance.GetGIA_VONs().SingleOrDefault(p => p.MA_SP == findHSD.MA_SP && p.SO_LO == findHSD.SO_LO);
            this.dataPhieuXuatHuy.Rows.Add(addHH.MA_SP, addHH.TEN_SP, addHH.SO_LO, findHSD.HSD, addHH.QUY_CACH_DONG_GOI, addHH.TONG_TON, "", giaVon.GIAVON.ToString("#,#"));
            lblCoutHangHuy.Text = dataPhieuXuatHuy.Rows.Count.ToString();
            decimal tonghuy = 0;
            foreach (DataGridViewRow row in dataPhieuXuatHuy.Rows)
            {
                decimal giaTri;
                if (decimal.TryParse(row.Cells[7].Value.ToString(), out giaTri))
                {
                    tonghuy += giaTri;
                }
            }
            lblTong.Text = tonghuy.ToString("#,#");
            txtHuyhang.Texts = string.Empty;
        }

        private void ctTimeOut_ValueChanged(object sender, EventArgs e)
        {
            if (ctTimeOut.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctTimeOut.Value = DateTime.Now;
            }
        }
    }
}
