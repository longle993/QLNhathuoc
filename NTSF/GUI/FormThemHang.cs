﻿using System;
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

        private void btnLuuThemHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu!");
        }

    }
}
