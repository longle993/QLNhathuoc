using System;
using System.Drawing;
using System.Windows.Forms;

namespace NTSF.GUI
{
    public partial class FormCDTK : Form
    {
        public FormCDTK()
        {
            InitializeComponent();
            btnThaydoiHuy.Hide();
            btnThaydoiLuu.Hide();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picAvatar.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThaydoiCDTK_Click(object sender, EventArgs e)
        {
            btnThaydoiHuy.Show();
            btnThaydoiLuu.Show();
        }

        private void btnThaydoiLuu_MouseHover(object sender, EventArgs e)
        {
            btnThaydoiLuu.BorderColor = Color.FromArgb(170, 139, 86);
            btnThaydoiLuu.ForeColor = Color.FromArgb(170, 139, 86);
            btnThaydoiLuu.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnThaydoiLuu_MouseLeave(object sender, EventArgs e)
        {
            btnThaydoiLuu.BorderColor = Color.Silver;
            btnThaydoiLuu.ForeColor = Color.DimGray;
            btnThaydoiLuu.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void btnThaydoiCDTK_MouseHover(object sender, EventArgs e)
        {

            btnThaydoiCDTK.BorderColor = Color.FromArgb(170, 139, 86);
            btnThaydoiCDTK.ForeColor = Color.FromArgb(170, 139, 86);
            btnThaydoiCDTK.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnThaydoiCDTK_MouseLeave(object sender, EventArgs e)
        {
            btnThaydoiCDTK.BorderColor = Color.Silver;
            btnThaydoiCDTK.ForeColor = Color.DimGray;
            btnThaydoiCDTK.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnThaydoiHuy_MouseHover(object sender, EventArgs e)
        {
            btnThaydoiHuy.BorderColor = Color.FromArgb(170, 139, 86);
            btnThaydoiHuy.ForeColor = Color.FromArgb(170, 139, 86);
            btnThaydoiHuy.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnThaydoiHuy_MouseLeave(object sender, EventArgs e)
        {
            btnThaydoiHuy.BorderColor = Color.Silver;
            btnThaydoiHuy.ForeColor = Color.DimGray;
            btnThaydoiHuy.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnThaydoiHuy_Click(object sender, EventArgs e)
        {
            btnThaydoiHuy.Hide();
            btnThaydoiLuu.Hide();
        }

        private void btnThaydoiLuu_Click(object sender, EventArgs e)
        {
            FormMain formMain = (FormMain)Application.OpenForms["FormMain"];
            if (picAvatar.Image != null)
            {
            formMain.picAdmin.Image = picAvatar.Image;
            }
            formMain.lblTENNT.Text = txtTenNT.Texts.ToUpper();
            btnThaydoiHuy.Hide();
            btnThaydoiLuu.Hide();
        }
    }
}
