using Quiz.Properties;
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
    public partial class frmAddUpdateUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        int _UserID;
        clsUser _User;
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            
            _UserID = UserID;

            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            
        }

        private void _LoadData()
        {
            string TitleTxt = "Add New User";
            if (_Mode == enMode.AddNew)
            {
                this.Text = TitleTxt;
                lblTitle.Text = TitleTxt;
                _User = new clsUser();
                txtUsername.Focus();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This window will be closed because there is no User with this id");
                this.Close();
            }
            TitleTxt = "Update User";
            this.Text = TitleTxt;
            lblTitle.Text = TitleTxt;

            txtName.Text = _User.FirstName;
            txtPassword.Text = _User.Password;
            txtUsername.Text = _User.Username;
            numericRightAnswers.Value = _User.TotalRightAnswers;
            numericTotalAnswers.Value = _User.TotalAnswers;

        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Tag.ToString() == "show")
            {
                txtPassword.PasswordChar = '\0';
                pb.Tag = "hide";
                pb.Image = Resources.show;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pb.Tag = "show";
                pb.Image = Resources.hide;
            }
        }
        private bool _CheckBeforeSave()
        {

            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You have to fill all text boxes before saving your data");
                return false;
            }
            if(clsUser.isUserExist(txtUsername.Text) && txtUsername.Text != _User.Username)
            {
                MessageBox.Show("this user is already exist. try with another username");
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckBeforeSave())
                return;
            _User.Username = txtUsername.Text;
            _User.Password = txtPassword.Text;
            _User.FirstName = txtName.Text;

            if (numericTotalAnswers.Value == 0)
                _User.TotalAnswers = -1;
            else
                _User.TotalAnswers =(int)numericTotalAnswers.Value;
            
            if (numericRightAnswers.Value == 0)
                _User.TotalRightAnswers = -1;
            else
                _User.TotalRightAnswers =(int)numericRightAnswers.Value;


            if(!_User.Save())
            {
                MessageBox.Show("There was an error!\n\ntry again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Mode = enMode.Update;
            _UserID = _User.UserID;
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
