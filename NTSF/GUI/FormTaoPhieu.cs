using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormTaoPhieu : Form
    {
        public FormTaoPhieu()
        {
            InitializeComponent();
            LoadTimeNow();
        }

        private void LoadTimeNow()
        {
            this.lblHour.Text = DateTime.Now.ToString("hh:mm");
        }
    }
}
