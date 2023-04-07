using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        List<KHACH_HANG> KHBan = new List<KHACH_HANG>();
        public FormThanhToan()
        {
            InitializeComponent();
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

        private void MaAuto()
        {
            NhaThuoc db = new NhaThuoc();
            int count = db.HOA_DON.ToList().Count + 1;
            lblmaHDAuto.Text = $"#{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{count.ToString("00")}";
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
                autoload.Add($"{kh.SDT}- {kh.TEN_KH}");
            }
            txtTenKH.TextBoxControl.AutoCompleteCustomSource = autoload;
        }

    }
    }

