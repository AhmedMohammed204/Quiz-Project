using QuestionsBusinessLayer;
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
    public partial class frmQuiz : Form
    {
        clsUser _User = null;
        Panel _CurrentPanel;
        Form activeForm;
        public frmQuiz(clsUser User, Panel CurrentPanel)
        {

            InitializeComponent();
            _CurrentPanel = CurrentPanel;
            _User = User;
            cbTimer.SelectedIndex = 0;
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
            _CurrentPanel.Font = frm.Font;
            frm.Size = _CurrentPanel.Size;
            _CurrentPanel.Controls.Add(frm);
            activeForm = frm;
            frm.BringToFront();
            frm.Show();
        }
        private void btnMath_Click(object sender, EventArgs e)
        {

            clsQuestion question = clsQuestion.GetRandomMathQuestion();
            if (question == null)
            {
                MessageBox.Show("There is no question of this subject");
                return;
            }
            frmQuestion frm = new frmQuestion(question, Convert.ToByte( cbTimer.Text) , _User);
            _OpenForm(frm);
        }


        private void btnPhysics_Click(object sender, EventArgs e)
        {
            clsQuestion question = clsQuestion.GetRandomPysicsQuestion();
            if (question == null)
            {
                MessageBox.Show("There is no question of this subject");
                return;
            }
            frmQuestion frm = new frmQuestion(question, Convert.ToByte(cbTimer.Text), _User);
            _OpenForm(frm);
        }
    }
}
