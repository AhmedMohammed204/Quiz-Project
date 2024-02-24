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
    public partial class frmQuestion : Form
    {
        TimeSpan ts;
        enum enSubject { Math = 0, Physics = 1}
        clsQuestion _Question;
        enSubject _Subject;
        clsQuestionInterface questionInterFace;
        byte _Seconds;
        clsUser _User;
        public frmQuestion(clsQuestion question, byte Seconds, clsUser User)
        {
            
            InitializeComponent();
            _Question = question;
            _Seconds = Seconds;
            _User = User;
            if (_Question.SubjectID == 1)
                _Subject = enSubject.Math;

            if(_Question.SubjectID == 2)
                _Subject = enSubject.Physics;
        }

        private void _LoadData()
        {
            if(_Subject == enSubject.Physics)
            {
                lblSubject.Text = "Physics";
            }

            if(_Subject == enSubject.Math)
            {
                lblSubject.Text = "Math";
            }
            questionInterFace = new clsQuestionInterface(_Question);
            pbQuestionImage.Image = questionInterFace.QuestionImage;
            _RestartButtons();
            _ResetTimer();
            btnNext.Visible = false;
            this.AcceptButton = null;
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _ResetTimer()
        {
            timer1.Enabled = true;
            ts = new TimeSpan(0, 0, _Seconds);
        }
        private void _GenerateNewQuestion()
        {
            if(_Subject == enSubject.Math)
                _Question = clsQuestion.GetRandomMathQuestion();

            if(_Subject == enSubject.Physics)
                _Question = clsQuestion.GetRandomPysicsQuestion();
        }
        private void _RestartButton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = ColorTranslator.FromHtml("#FFBC57");
        }
        private void _RestartButtons()
        {
            _RestartButton(btnA);
            _RestartButton(btnB);
            _RestartButton(btnC);
            _RestartButton(btnD);
        }


        private void _ChangeButtonColor(Button btn)
        {
            btn.Enabled = false;
            if (btn.Tag.ToString() == _Question.RightAnswerID.ToString())
            {
                btn.BackColor = ColorTranslator.FromHtml("#085942");
                return;
            }

        }
        private void _ChangeQuestionButtonsColor()
        {

            _ChangeButtonColor(btnA);
            _ChangeButtonColor(btnB);
            _ChangeButtonColor(btnC);
            _ChangeButtonColor(btnD);
        }
        private void _SetExpalinImage()
        {
            if (_Question.ExplainImage == null)
                return;

            pbQuestionImage.Image = questionInterFace.ExplainImage;
        }
        private void _EndQuetionTime()
        {
            _ChangeQuestionButtonsColor();
            timer1.Enabled = false;
            this.AcceptButton = btnNext;
            btnNext.Visible = true;
            _SetExpalinImage();

        }
        private void btnOption_Click(object sender, EventArgs e)
        {
            _EndQuetionTime();
            _User.TotalAnswers += 1;
            Button btn = (Button)sender;
            if (btn.Tag.ToString() == _Question.RightAnswerID.ToString())
            {
                _User.TotalRightAnswers += 1;
                btn.BackColor = ColorTranslator.FromHtml("#085942");
            }else
            {
                btn.BackColor = Color.Tomato;
            }
            if (!_User.Save())
                MessageBox.Show("There was an error");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = ts.Seconds.ToString();
            ts = new TimeSpan(ts.Hours, ts.Minutes, ts.Seconds-1);
            if (ts.Seconds <= 0)
                _EndQuetionTime();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _GenerateNewQuestion();
            _LoadData();
        }
    }
}
