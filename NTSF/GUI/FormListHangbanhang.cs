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
    public partial class FormListHangbanhang : Form
    {
        List<DANH_MUC_SP> SPBan = new List<DANH_MUC_SP>();
        public FormListHangbanhang()
        {
            InitializeComponent();
        }

        private void txtHangBan__TextChanged(object sender, EventArgs e)
        {
            this.SPBan = DANH_MUC_SP_BUS.Instance.FindByName(txtHangBan.Texts,null);
            AutoCompleteStringCollection autoload = new AutoCompleteStringCollection();
            foreach (DANH_MUC_SP hanghoa in this.SPBan)
            {
                autoload.Add(hanghoa.TEN_SP);
            }
            txtHangBan.TextBoxControl.AutoCompleteCustomSource = autoload;

        }
    }
}
