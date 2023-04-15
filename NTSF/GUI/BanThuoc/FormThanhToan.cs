using NTSF.BUS;
using NTSF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormThanhToan : Form
    {
        List<KHACH_HANG> KHBan = new List<KHACH_HANG>();
        FormListHangbanhang listHangbanhang;
        public FormThanhToan()
        {
            InitializeComponent();
            LoadTimeNow();
            MaAuto();
        }

        public FormThanhToan(FormListHangbanhang listHangbanhang)
        {
            InitializeComponent();
            this.listHangbanhang = listHangbanhang;
            LoadTimeNow();
            MaAuto();
        }


        private void LoadTimeNow()
        {
            this.lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lblHour.Text = DateTime.Now.ToString("hh:mm");
        }

        private void LoadNV()
        {
            this.cbboxNV.Items.Clear();
            List<NHAN_VIEN> DanhSachNV = NHAN_VIEN_BUS.Instance.GetNHAN_VIENs();
            foreach (NHAN_VIEN nv in DanhSachNV)
            {
                if (this.cbboxNV.Items.Contains(nv.TEN_NV))

                    continue;
                cbboxNV.Items.Add(nv.TEN_NV);
            }
        }

        private void LoadPTTT()
        {
            this.cbboxPTTT.Items.Clear();
            List<PTTT> DanhSachPTTT = PTTT_BUS.Instance.GetPTTTs();
            foreach (PTTT pttt in DanhSachPTTT)
            {
                if (this.cbboxNV.Items.Contains(pttt.TEN_PTTT))

                    continue;
                cbboxPTTT.Items.Add(pttt.TEN_PTTT);
            }
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            LoadNV();
            LoadPTTT();
            LoaddataHang();
            txtGiamgia.Texts = "0";
            txtKhachtra.Texts = "0";

        }

        private void MaAuto()
        {
            NhaThuoc db = new NhaThuoc();
            int count = db.HOA_DON.ToList().Count + 1;
            lblmaHDAuto.Text = $"#{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("dd")}{count.ToString("000")}";
        }

        private void btnQuayve_Click(object sender, EventArgs e)
        {
            ResetTextBoxes(this);
        }
        private void ResetTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    ResetTextBoxes(c);
                }
            }
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
            LoaddataHang();

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            FormThemKH formThemKH = new FormThemKH();
            formThemKH.ShowDialog();
            LoaddataHang();

        }

        private void LoaddataHang()
        {
            decimal tongtien = 0;
            foreach (DataGridViewRow row in listHangbanhang.dataHangBan.Rows)
            {
                decimal giaTri = 0;
                if (decimal.TryParse(row.Cells[4].Value.ToString(), out giaTri))
                {
                    tongtien += giaTri;
                }

            }
            lblTong.Text = tongtien.ToString("#,#");
            if (txtGiamgia.Texts == "" || txtGiamgia.Texts is null)
            {
                lblKhachcantra.Text = lblTong.Text;
            }
        }

        private void cbboxPTTT_SelectedValueChanged(object sender, EventArgs e)
        {
            LoaddataHang();
        }

        private void lblTong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblKhachcantra.Text = (decimal.Parse(lblTong.Text) - decimal.Parse(txtGiamgia.Texts)).ToString("#,#");

            }
            catch
            {
                lblKhachcantra.Text = "0";
            }

        }

        private void txtGiamgia__TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblKhachcantra.Text = (decimal.Parse(lblTong.Text) - decimal.Parse(txtGiamgia.Texts)).ToString("#,#");
            }
            catch
            {
                lblKhachcantra.Text = "0";
            }

        }

        private void lblKhachcantra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblTienthua.Text = (decimal.Parse(lblKhachcantra.Text) - decimal.Parse(txtKhachtra.Texts)).ToString("#,#");
            }
            catch
            {
                lblTienthua.Text = "0";
            }
        }

        private void txtKhachtra__TextChanged(object sender, EventArgs e)
        {
            try
            {

                lblTienthua.Text = (decimal.Parse(lblKhachcantra.Text) - decimal.Parse(txtKhachtra.Texts)).ToString("#,#");
            }
            catch
            {
                lblTienthua.Text = "0";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (listHangbanhang.dataHangBan.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu trống!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] gettenkh = txtTenKH.Texts.Split(' ');
            NHAN_VIEN nv = NHAN_VIEN_BUS.Instance.FindByName(cbboxNV.Text).SingleOrDefault();
            KHACH_HANG kh = KHACH_HANG_BUS.Instance.FindByPhone(gettenkh[0]).SingleOrDefault();
            PTTT pttt = PTTT_BUS.Instance.GetPTTTs().SingleOrDefault(p => p.TEN_PTTT == cbboxPTTT.Text);


            //Thêm hoá đơn
            HOA_DON hd = new HOA_DON();
            hd.MA_HD = "HD"+lblmaHDAuto.Text.Substring(1);
            hd.NGAY_HD = DateTime.Now;
            hd.MA_NV = nv.MA_NV;
            hd.TEN_KH = kh.TEN_KH;
            hd.MA_PTTT = pttt.MA_PTTT;
            hd.TRI_GIA = decimal.Parse(lblKhachcantra.Text);
            hd.GHI_CHU = txtboxGhichu.Texts is null || txtboxGhichu.Texts == "" ? " " : txtboxGhichu.Texts;
            HOA_DON_BUS.Instance.AddOrUpdate(hd);


            foreach(HANG_HOA hh in listHangbanhang.dsHH)
            {
                CT_HOA_DON cthd = new CT_HOA_DON();
                cthd.MA_HD = hd.MA_HD;
                cthd.MA_SP = hh.MA_SP;
                cthd.SO_LO = hh.SO_LO;
                cthd.DVT = hh.DVT_CO_BAN;
                foreach(DataGridViewRow row in listHangbanhang.dataHangBan.Rows)
                {
                    if(row.Cells[0].Value.ToString() == hh.MA_SP && row.Cells[1].Value.ToString() == hh.TEN_SP)
                    {
                        cthd.SO_LUONG = int.Parse(row.Cells[2].Value.ToString());
                    }
                }
                cthd.CHIET_KHAU = 0;
                try
                {
                    CT_HOA_DON_BUS.Instance.AddOrUpdateCHTD(cthd);

                }
                catch
                {
                    MessageBox.Show("Lỗi ở CTHD");
                }
            }


            MessageBox.Show("Lưu thành công!");

        }
    }
}

