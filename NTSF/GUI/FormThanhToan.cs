using System;
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

namespace NTSF.GUI
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
            LoadTimeNow();
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
            foreach(NHAN_VIEN nv in DanhSachNV)
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
        }
    }
}
