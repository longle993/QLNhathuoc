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
    public partial class FormThemNV : Form
    {
        NHAN_VIEN nv = new NHAN_VIEN();

        public FormThemNV()
        {
            InitializeComponent();
        }

        private void btnDongNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            ThemNV();
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        private void btnLuuThemNV_Click(object sender, EventArgs e)
        {
            ThemNV();
            MessageBox.Show("Đã lưu");
            ResetTextBox(this);

        }

        private void ResetTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    ResetTextBox(c);
                }
            }
        }

        private void ThemNV()
        {
            nv.TEN_NV = txtTenNV.Texts;
            nv.SDT = txtSDTNV.Texts;
            nv.MA_NV = MaAuto();
            NHAN_VIEN_BUS.Instance.AddUpdateNV(nv);
        }
        private string MaAuto()
        {
            NhaThuoc db = new NhaThuoc();
            int count = db.NHAN_VIEN.ToList().Count + 1;
            return $"NV{count.ToString("00")}";
        }




    }
}
