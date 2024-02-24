using OptionsBusinessLayer;
using QuestionsBusinessLayer;
using SubjectsBusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using UsersBusinessLayer;
using AdminsBusinessLayer;

namespace Quiz
{
    public partial class frmAddQuestion : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        int _QuestionID = 0;
        clsQuestion _Question;
        private byte[] QuestionImage = null;
        private byte[] ExplainimageImage = null;
        clsQuestionInterface questionInterface;
        clsAdmin _Admin;

        public frmAddQuestion(int QuestionID, clsAdmin Admin)
        {
            InitializeComponent();
            _Admin = Admin;
            _QuestionID = QuestionID;

            if(_QuestionID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            
        }

        private void _FillSubjectsInComboBox()
        {
            DataTable dtSubjects = clsSubject.GetAllSubjects();

            foreach (DataRow Subject in dtSubjects.Rows)
            {
                cbSubjects.Items.Add(Subject["Name"]);
            }
        }
        private void _FillQuestionOptionsInComboBox()
        {
            DataTable dtOptions = clsOption.GetAllOptions();

            foreach (DataRow Options in dtOptions.Rows)
            {
                cbOptions.Items.Add(Options["Name"]);
            }
        }

        private void _LoadData()
        {
            cbSubjects.Focus();
            
            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Question";
                this.Text = "Add New Question";
                cbSubjects.SelectedIndex = 0;
                cbOptions.SelectedIndex = 0;
                _Question = new clsQuestion();
                return;
            }

            _Question = clsQuestion.Find(_QuestionID);
            if(_Question == null) 
            {
                MessageBox.Show("This window will be closed because there is no Question with this id");
                this.Close();
                return;
            }
            lblTitle.Text = "Update Question";
            questionInterface = new clsQuestionInterface(_Question);
            this.Text = "Update Question";
            if (_Question.ExplainImage != null)
            {
                pbExplainPhoto.Image = questionInterface.ExplainImage;
            }
            QuestionImage = _Question.Image;
            ExplainimageImage = _Question.ExplainImage;
            pbQuestionPhoto.Image = questionInterface.QuestionImage;
            cbSubjects.SelectedIndex = cbSubjects.FindString(clsSubject.Find(_Question.SubjectID).Name);
            cbOptions.SelectedIndex = cbOptions.FindString(clsOption.Find(_Question.RightAnswerID).Name);

        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            _FillSubjectsInComboBox();
            _FillQuestionOptionsInComboBox();
            _LoadData();
        }

        private void _LoadPhotoInPictureBox(PictureBox pb, bool IsQuestionImage = true)
        {
            openFileDialog1.InitialDirectory = @"/downloads";
            openFileDialog1.Title = "Choose a photo";

            openFileDialog1.Filter = "png files (*.png)|*.png| All files (*.*)|*.*";
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                //MessageBox.Show(openFileDialog1.FileName);
                pb.Load(path);
                FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(filestream);

                if (IsQuestionImage)
                {
                    QuestionImage = binaryReader.ReadBytes((int)filestream.Length);
                    return;
                }
                ExplainimageImage = binaryReader.ReadBytes((int)filestream.Length);
            }
        }
        private void btnQuestionPhoto_Click(object sender, EventArgs e)
        {
            _LoadPhotoInPictureBox(pbQuestionPhoto);
        }

        private void btnExplainPhoto_Click(object sender, EventArgs e)
        {
            _LoadPhotoInPictureBox(pbExplainPhoto, false);
        }




        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            //clsQuestion Question = new clsQuestion();
            if (pbQuestionPhoto.Image == null)
            {
                MessageBox.Show("Plaese Add Question Photo");
                return;
            }

            int SubjectID = clsSubject.Find(cbSubjects.Text).SubjectID;
            int RightAnswerID = clsOption.Find(cbOptions.Text).OptionID;


            _Question.AdminID = _Admin.AdminID;
            _Question.SubjectID = SubjectID;
            _Question.RightAnswerID = RightAnswerID;
            _Question.Date = DateTime.Now;
            _Question.Image = QuestionImage;
            _Question.ExplainImage = ExplainimageImage;

            _Admin.TotalAddedQuestions += 1;
            _Admin.Save();
            if (!_Question.Save())
            {
                
                MessageBox.Show("There was an error!\n\ntry again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _Mode = enMode.Update;
            _QuestionID = _Question.QuestionID;
            
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExplainPhoto_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete Explain image?", "Are sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK )
            {
                pbExplainPhoto.Image = null;
                ExplainimageImage = null;
            }
        }
        /*
-Save photos in DB


Uncompleted Missions!

-Show TotalQuestions and TotalUsers in Dashboard form
-Create new form which will help admins to create new questions
-Delete & Update & Find --> Questions and Users in Dashborad
-Complete quiz interface


*/
    }
}
