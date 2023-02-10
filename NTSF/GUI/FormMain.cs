using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace NTSF.GUI
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Image calendarIcon = Properties.Resources.Calendar;


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 120);
            panelMenu.Controls.Add(leftBorderBtn);
            LoadTimeNow();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new FormTongQuan());

        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        private struct RGBColors
        {
            public static Color color395144 = Color.FromArgb(57, 81, 68);
            public static Color color395 = Color.FromArgb(51, 153, 85);
            public static Color colorEAE = Color.FromArgb(234, 235, 245);
            public static Color color4E6 = Color.FromArgb(78, 108, 80); 

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.color4E6;
                //Left border button
                leftBorderBtn.BackColor = Color.White;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.color395144;
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                leftBorderBtn.Visible = false;
            }
        }
        private void LoadTimeNow()
        {
            this.lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color395);
            OpenChildForm(new FormBanHang());
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color395);
            OpenChildForm(new FormHoaDon());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color395);
            dropdownMenu1.Show(btnKho, btnKho.Width, 0);
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color395);
            OpenChildForm(new FormBaoCao());
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color395);
            OpenChildForm(new FormDanhMuc());

        }

        private void btnCaidat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color395);
            OpenChildForm(new FormCaiDat());

        }

        private void btnNhathuoc_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new FormTongQuan());

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLoginBackgr formlogin = new FormLoginBackgr();
            this.Close();
            formlogin.ShowDialog();
        }

        private void dropmenuNhapkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapKho());

        }

        private void dropmenuTonkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTonKho());
        }



        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctCirclePictureBox4_MouseHover(object sender, EventArgs e)
        {

                this.ctCirclePictureBox4.Image = global::NTSF.Properties.Resources.Xmark;
        }

        private void ctCirclePictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.ctCirclePictureBox4.Image = null;
        }

        private void ctCirclePictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.ctCirclePictureBox5.Image = global::NTSF.Properties.Resources.minius;
        }

        private void ctCirclePictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.ctCirclePictureBox5.Image = null;

        }
    }
}
