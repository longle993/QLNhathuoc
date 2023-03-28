using System;
using System.Windows.Forms;
using NTSF.DTO;
using NTSF.BUS;
using System.Text;
using System.Data.SqlClient;

namespace NTSF.GUI
{
    public partial class FormThemHang : Form
    {
        public FormThemHang()
        {
            InitializeComponent();
        }

        private void btnDongThemHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Luu(bool close)
        {
            if (txtHanghoa.Texts == "" || txtQCDG.Texts == "" || txtSolo.Texts == "" || txtGiaban.Texts == "" || txtSLNhap.Texts == "" || txtDongia.Texts == "" || txtTongGiamgia.Texts == "")
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
            Luu(true);
            DANH_MUC_SP sP = new DANH_MUC_SP();
            TON_KHO tonkho = new TON_KHO();
            PHIEU_NHAP PN = new PHIEU_NHAP();
            CT_PHIEU_NHAP CTPN = new CT_PHIEU_NHAP();

            sP.MA_SP = LoadMaSPAuto(sP.MA_SP);
            sP.TEN_SP = txtHanghoa.Texts;
            sP.NHOM_SP = cbboxNhomhang.Text;
            sP.HAM_LUONG = txtHamluong.Texts;
            sP.QUY_CACH_DONG_GOI = txtQCDG.Texts;/*
            sP.VAT_BAN = Byte.Parse(txtSLNhap.Text);*/
            sP.DVT_CO_BAN = cbboxDVTCB.Text;
            sP.GIA_BAN = decimal.Parse(txtGiaban.Text);
            sP.TONG_TON = int.Parse(txtSLNhap.Text);


            tonkho.MA_SP = LoadMaSPAuto(sP.MA_SP);
            tonkho.SO_LO = txtSolo.Texts;
            tonkho.SO_LUONG_NHAP = Convert.ToInt32(txtSLNhap.Text);

            PN.MA_PHIEU = LoadMaPNAuto(PN.MA_PHIEU);
            PN.NGAY_NHAP = DateTime.Now.Date;
            PN.GIO_NHAP = DateTime.Now.TimeOfDay;
            PN.TRI_GIA = Convert.ToDecimal(lblTRIGIA.Text);

            CTPN.MA_PHIEU = PN.MA_PHIEU;
            CTPN.MA_SP = tonkho.MA_SP;
            CTPN.SO_LO = tonkho.SO_LO;
            CTPN.HSD = DateTime.Parse(datepickerHSD.Text);
            CTPN.DON_VI_NHAP = cbDVN.Text;
            CTPN.QUY_DOI = 1;
            CTPN.SOLUONG = tonkho.SO_LUONG_NHAP;
            CTPN.DON_GIA = Convert.ToDecimal(txtDongia.Text);
            CTPN.CHIET_KHAU = Convert.ToDecimal(txtTongGiamgia.Text);
            CTPN.VAT_NHAP = Convert.ToByte(txtVAT.Text);

            DANH_MUC_SP_BUS.Instance.AddUpdateDMSP(sP);
        }

        private void btnLuuThemmoi_Click(object sender, EventArgs e)
        {
            Luu(false);
            ResetTextBoxes(this);
        }

        private string LoadMaSPAuto(string masp)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-JSUCTMT;Initial Catalog=QUANLYBANTHUOC;Integrated Security=True";
                string query = "SELECT COUNT(*) FROM DANH_MUC_SP;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    count++;
                    masp = $"SP{count.ToString("000000")}";
                }
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
                string connectionString = "Data Source=DESKTOP-JSUCTMT;Initial Catalog=QUANLYBANTHUOC;Integrated Security=True";
                string query = "SELECT COUNT(*) FROM PHIEU_NHAP;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    count++;
                    mapn = $"PN{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("dd")}{count.ToString("000")}";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return mapn;
        }

    }
}
