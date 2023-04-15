using System;
using System.Drawing;
using FontAwesome.Sharp;
using System.Windows.Forms;
using NTSF.CTuserControl;

namespace NTSF.GUI
{
    public partial class FormCaiDat : Form
    {
        private IconButton currentBtn;
        private Form currentChildForm;
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
            panelCDTK.Controls.Add(childForm);
            panelCDTK.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public FormCaiDat()
        {
            InitializeComponent();
            OpenChildForm(new FormCDTK());
            ActivateButton(btnCDTK, panelBtnTK);
        }

        private void ActivateButton(object senderBtn, AdvancedPanel panel)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                panel.FlatBorderColor = Color.FromArgb(170, 139, 86);
                panel.BringToFront();
                currentBtn.ForeColor = Color.FromArgb(170, 139, 86);
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Black;
                panelBtnHT.FlatBorderColor = Color.FromArgb(236, 236, 236);
                panelBtnTK.FlatBorderColor = Color.FromArgb(236, 236, 236);

            }
        }

        private void btnCDTK_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelBtnTK);
            OpenChildForm(new FormCDTK());
        }

        private void btnCDHT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,panelBtnHT);
            OpenChildForm(new FormCDHT());
        }
    }
}
