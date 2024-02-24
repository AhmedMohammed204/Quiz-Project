using AdminsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBusinessLayer;

namespace Quiz
{
    
    public partial class frmMain : Form
    {
        private clsUser User = null;
        private clsAdmin _Admin;
        private frmQuiz frmQuiz = null;
        private frmProfile frmProfile = null;
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
        }
        private void _LoadForm()
        {
            btnDashboard.Visible = false;
            bool IsLoginSuccess = false;
            frmLogin frm = new frmLogin(IsLoginSuccess);
            frm.ShowDialog();
            if (!frm.IsSuccessfulLogin())
            {
                this.Close();
                return;
            }
            User = frm.GetCurrnetUser();

            if (frm.IsAdmin())
            {
                btnDashboard.Visible = true;
            }
            _OpenProfileForm();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadForm();
        }
        private void _OpenForm(Form frm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelScreens.Font = frm.Font;
            frm.Size = panelScreens.Size;
            panelScreens.Controls.Add(frm);
            activeForm = frm;
            frm.BringToFront();
            frm.Show();
        }
        private void _ResetAllButtonsColor()
        {
            btnProfile.BackColor = ColorTranslator.FromHtml("#FFBC57");
            btnQuiz.BackColor = ColorTranslator.FromHtml("#FFBC57");
            
            //btnSittings.BackColor = ColorTranslator.FromHtml("#FFBC57");
        }


        private void _OpenProfileForm()
        {
            btnProfile.BackColor = ColorTranslator.FromHtml("#FC7716");
            
            frmProfile = new frmProfile(User);
            _OpenForm(frmProfile);

        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            _ResetAllButtonsColor();
            _OpenProfileForm();
        }
        
        
        private void _OpenQuizForm()
        {
            btnQuiz.BackColor = ColorTranslator.FromHtml("#FC7716");
            
            frmQuiz = new frmQuiz(User, panelScreens);
            
            _OpenForm(frmQuiz);
        }
        private void btnQuiz_Click(object sender, EventArgs e)
        {

            _ResetAllButtonsColor();
            _OpenQuizForm();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard(clsAdmin.FindByUserID(User.UserID));
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _ResetAllButtonsColor();
            _LoadForm();
        }
    }
}
