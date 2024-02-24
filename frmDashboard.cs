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
    public partial class frmDashboard : Form
    {
        private Form activeForm = null;
        private frmDashboardMain frmMainDahboard = null;
        private frmAddQuestion FrmAddQuestion= null;
        private string _LightColor = "#7B44F2";
        private string _DarkColor = "#32088C";
        clsAdmin _Admin;
        
        private Color LightColor()
        {
            return ColorTranslator.FromHtml(_LightColor);
        }
        private Color DarkColor()
        {
            return ColorTranslator.FromHtml(_DarkColor);
        }
        public frmDashboard(clsAdmin Admin)
        {
            InitializeComponent();
            _Admin = Admin;
            lblAdminData.Text = $"Admin ID: {Admin.AdminID}";
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {

            _OpenMainDashboardForm();
        }
        
        
        private void _OpenForm(Form frm)
        {
            if (activeForm != null)
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
            btnMainDashboard.BackColor = LightColor();
            //btnQuiz.BackColor = ColorTranslator.FromHtml(Color);

            //btnSittings.BackColor = ColorTranslator.FromHtml(Color);
        }
        
        
        private void _OpenMainDashboardForm()
        {
            btnMainDashboard.BackColor = DarkColor();
            frmMainDahboard = new frmDashboardMain(_Admin);
            _OpenForm(frmMainDahboard);
        }
        private void btnMainDashboard_Click(object sender, EventArgs e)
        {
            _ResetAllButtonsColor();
            _OpenMainDashboardForm();
        }

        //private void _OpenAddQuestionForm()
        //{
        //    btnAddQuestion.BackColor = DarkColor();
        //    FrmAddQuestion = new frmAddQuestion();
        //    _OpenForm(FrmAddQuestion);
        //}
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            _ResetAllButtonsColor();
            //_OpenAddQuestionForm();
        }
    }
}
