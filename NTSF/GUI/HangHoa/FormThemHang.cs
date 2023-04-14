using System;
using System.Windows.Forms;
using NTSF.DTO;
using NTSF.BUS;
using System.Text;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace NTSF.GUI
{
    public partial class FormThemHang : Form
    {
        List<HANG_HOA> SPBan;
        List<HANG_HOA> dsDVT;
        List<DON_VI_TINH> dvtKhac;
        List<NHA_CUNG_CAP> dsNCC;
        FormTaoPhieu formTaoPhieu;
        public FormThemHang()
        {
            InitializeComponent();
        }
        public FormThemHang(FormTaoPhieu formTaoPhieu)
        {
            InitializeComponent();
            this.formTaoPhieu = formTaoPhieu;

        }
        private void btnDongThemHang_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Luu(bool close)
        {
            if (txtHanghoa.Texts == "" || txtQCDG.Texts == "" || txtSolo.Texts == "" || txtGiaDVT.Texts == "" || txtSLNhap.Texts == "" || txtDongia.Texts == "" || txtTongGiamgia.Texts == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã lưu!");
                if (close == true)
                this.Close();
            }
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

        private void btnLuuThemHang_Click(object sender, EventArgs e)
        {
            //Thêm thông tin vào hàng hoá
            HANG_HOA sP = new HANG_HOA();
            sP.MA_SP = LoadMaSPAuto(sP.MA_SP);
            sP.SO_LO = txtSolo.Texts;
            sP.TEN_SP = txtHanghoa.Texts;
            sP.LOAI_SP = cbboxNhomhang.Text;
            sP.HAM_LUONG = txtHamluong.Texts;
            sP.QUY_CACH_DONG_GOI = txtQCDG.Texts;
            sP.MO_TA = "";
            sP.DVT_CO_BAN = cbboxDVTCB.Text;
            sP.VAT_BAN = byte.Parse(txtVATBan.Texts);
            sP.GIA_BAN = decimal.Parse(txtGiaDVT.Texts);
            sP.TONG_TON = int.Parse(txtSLNhap.Texts);
            HANG_HOA_BUS.Instance.AddUpdateDMSP(sP);

            //Thêm thông tin phiếu nhập
            PHIEU_NHAP PN = new PHIEU_NHAP();
            PN.MA_PHIEU = LoadMaPNAuto(PN.MA_PHIEU);
            PN.NGAY_NHAP = DateTime.Now;
            PN.TRI_GIA = Convert.ToDecimal(lblTRIGIA.Text);
            PN.GHI_CHU = "";
            PHIEU_NHAP_BUS.Instance.AddUpdatePN(PN);

            //Thêm thông tin Đơn vị tính
            DON_VI_TINH dvt = new DON_VI_TINH();
            dvt.MA_SP = sP.MA_SP;
            dvt.SO_LO = sP.SO_LO;
            dvt.DVT_KHAC = cbDVT.Text;
            dvt.QUY_DOI = 1;
            dvt.GIA_BAN = decimal.Parse(txtGiaDVT.Texts);
            DON_VI_TINH_BUS.Instance.AddOrUpdateDVT(dvt);

            //Thêm thông tin CT phiết nhập
            CT_PHIEU_NHAP CTPN = new CT_PHIEU_NHAP();
            CTPN.MA_PHIEU = PN.MA_PHIEU;
            CTPN.MA_SP = sP.MA_SP;
            CTPN.SO_LO = sP.SO_LO;
            CTPN.MA_NCC = NHA_CUNG_CAP_BUS.Instance.FindByName(cbNCC.Text).SingleOrDefault().MA_NCC;
            CTPN.HSD = datepickerHSD.Value;
            CTPN.DON_VI_NHAP = txtDVN.Texts;
            CTPN.QUY_DOI = 1;
            CTPN.SO_LUONG = Convert.ToInt32(txtSLNhap.Texts);
            CTPN.DON_GIA = Convert.ToDecimal(txtDongia.Texts);
            CTPN.CHIET_KHAU = Convert.ToDecimal(txtTongGiamgia.Texts);
            CTPN.VAT_NHAP = Convert.ToByte(txtVAT.Texts);
            CT_PHIEU_NHAP_BUS.Instance.AddUpdateCTPN(CTPN);

            formTaoPhieu.dataCTphieunhap.Rows.Add(sP.MA_SP,sP.TEN_SP,sP.SO_LO,CTPN.HSD,sP.DVT_CO_BAN,sP.TONG_TON,CTPN.DON_GIA,CTPN.VAT_NHAP,PN.TRI_GIA);

            formTaoPhieu.sP = sP;
            formTaoPhieu.PN = PN;
            formTaoPhieu.DVT = dvt;
            formTaoPhieu.CTPN = CTPN;

            Luu(true);

        }

        private void btnLuuThemmoi_Click(object sender, EventArgs e)
        {
            Luu(false);
            ResetTextBoxes(this);
        }

        private void LoadAll()
        {
            dsDVT = HANG_HOA_BUS.Instance.GetDVTCB();
            dvtKhac = DON_VI_TINH_BUS.Instance.GetDON_VI_TINHs();
            LoadDVT();

            dsNCC = NHA_CUNG_CAP_BUS.Instance.GetNHA_CUNG_CAPs();
            LoadNCC();
            try
            {
                lblTRIGIA.Text = (((Convert.ToInt32(txtSLNhap.Texts) * Convert.ToInt32(txtDongia.Texts) - Convert.ToInt32(txtTongGiamgia.Texts)) * (1 + Convert.ToInt32(txtVAT.Texts))) / Convert.ToInt32(txtSLNhap.Texts)).ToString("#,#");
            }
            catch
            {
                lblTRIGIA.Text = "0";
            }
            
        }

        private string LoadMaSPAuto(string masp)
        {
            try
            {
                int count = this.SPBan.Count;
                masp = $"SP{count.ToString("000000")}";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return masp;
        }

        private string LoadMaPNAuto(string mapn)
        {
            try
            {
                int count = SPBan.Count + 1;
                mapn = $"PN{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("dd")}{count.ToString("000")}";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return mapn;
        }
        private void LoadDVT()
        {
            cbboxDVTCB.Items.Clear();
            cbDVT.Items.Clear();
            foreach(HANG_HOA dvt in dsDVT)
            {
                cbboxDVTCB.Items.Add(dvt.DVT_CO_BAN);
            }
            foreach(DON_VI_TINH dvt in dvtKhac)
            {
                cbDVT.Items.Add(dvt.DVT_KHAC);
            }
        }

        private void LoadNCC()
        {
            foreach(NHA_CUNG_CAP ncc in dsNCC)
            {
                cbNCC.Items.Add(ncc.TEN_NCC);
            }
        }
        private void txtVATBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtHanghoa__TextChanged(object sender, EventArgs e)
        {
            this.SPBan = HANG_HOA_BUS.Instance.FindByName(txtHanghoa.Texts, null);
            AutoCompleteStringCollection autoload = new AutoCompleteStringCollection();
            foreach (HANG_HOA hanghoa in this.SPBan)
            {
                autoload.Add(hanghoa.TEN_SP);
            }
            txtHanghoa.TextBoxControl.AutoCompleteCustomSource = autoload;
        }

        private void FormThemHang_Load(object sender, EventArgs e)
        {
            LoadAll();
        }


        private void btnPlusNCC_Click(object sender, EventArgs e)
        {
            FormThemMoiNCC addNCC = new FormThemMoiNCC();
            addNCC.ShowDialog();
            LoadAll();
        }

        private void cbNCC_TextChanged(object sender, EventArgs e)
        {
            dsNCC = NHA_CUNG_CAP_BUS.Instance.FindByName(cbNCC.Text);
            if(cbNCC.SelectedItem is null)
            {
                cbNCC.Items.Clear();
            }
            LoadNCC();
            
            this.cbNCC.SelectionStart = cbNCC.Text.Length;
        }

        private void cbboxNhomhang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtHamluong.Texts = SPBan.FirstOrDefault(p => p.TEN_SP == txtHanghoa.Texts && p.LOAI_SP == cbboxNhomhang.Text).HAM_LUONG;
                txtQCDG.Texts = SPBan.FirstOrDefault(p => p.TEN_SP == txtHanghoa.Texts && p.LOAI_SP == cbboxNhomhang.Text).QUY_CACH_DONG_GOI;
            }
            catch
            {
                txtHamluong.Texts = "";
                txtQCDG.Texts = "";
            }
        }

        private void txtSLNhap__TextChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(txtDongia, e);
        }

        private void NumberOnly(HotelManagement.CTControls.CTTextBox txt, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !txt.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }

        private void txtTongGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(txtTongGiamgia, e);
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(txtVAT, e);
        }

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(txtGiaban, e);
        }

        private void txtDongia__TextChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtTongGiamgia__TextChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtVAT__TextChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void txtGiaban__TextChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

    }
}
