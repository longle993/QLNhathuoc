using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTSF.CTuserControl;
using NTSF.DTO;
using NTSF.BUS;
namespace NTSF.GUI
{
    public partial class FormTongQuan : Form
    {
        List<HOA_DON> DanhSachHD = HOA_DON_BUS.Instance.GetTongQuan(DateTime.Now);

        public FormTongQuan()
        {
            InitializeComponent();
        }

        private void FormTongQuan_Load_1(object sender, EventArgs e)
        {
            LoadAll();
        }
        private void LoadAll()
        {
            List<HOA_DON> thangtruoc = DanhSachHD.Where(p => p.NGAY_HD.Month == DateTime.Now.Month - 1).ToList();
            List<HOA_DON> thangnay = DanhSachHD.Where(p => p.NGAY_HD.Month == DateTime.Now.Month).ToList();
            List<HOA_DON> hdToday = DanhSachHD.Where(p => p.NGAY_HD == DateTime.Now).ToList();


            decimal tongDS = 0;
            decimal tongDSNow = 0;
            decimal tongDSToday = 0;
            foreach (HOA_DON hd in thangtruoc)
            {
                tongDS += hd.TRI_GIA;
            }
            foreach (HOA_DON hd in thangnay)
            {
                tongDSNow += hd.TRI_GIA;
            }
            foreach (HOA_DON hd in hdToday)
            {
                tongDSToday += hd.TRI_GIA;
            }
             lblDSthangtruoc.Text = (tongDS != 0)  ?  tongDS.ToString("#,#") :  "0";

            lblDSthangnay.Text = (tongDSNow != 0) ? tongDSNow.ToString("#,#") : "0";
            lblHoadonthangtruoc.Text = thangtruoc.Count.ToString();
            lblHoadonthangnay.Text = thangnay.Count.ToString();
            lblHoadonBC.Text = hdToday.Count.ToString();
            lblDSBaocao.Text = (tongDSToday != 0) ? tongDSToday.ToString("#,#") : "0";

        }


    }
}
