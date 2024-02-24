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
    public partial class frmProfile : Form
    {
        private clsUser _User = null;
        public frmProfile(clsUser User)

        {
            InitializeComponent();
            this._User = User;
            lblFirstName.Text = this._User.FirstName;
            lblUsername.Text = this._User.Username;
            lblTotalAnswers.Text = this._User.TotalAnswers.ToString();
            lblTotalRightAnswers.Text = this._User.TotalRightAnswers.ToString();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            tcProfile.SelectedIndex = 0;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
            tcProfile.SelectedIndex = 1;
            txtFirstName.Text = this._User.FirstName;
            txtUsername.Text = this._User.Username;
            txtPassword.Text = this._User.Password;
            txtUsername.Focus();
        }
        private void _ErrorMessage(string Message, string Caption = "Error")
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _OpenProfileTap()
        {
            this.AcceptButton = default;
            lblFirstName.Text = _User.FirstName;
            lblUsername.Text = _User.Username;
            txtFirstName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            tcProfile.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                _ErrorMessage("You have to fill all text boxes");
                return;
            }

            if(clsUser.isUserExist(txtUsername.Text) && txtUsername.Text != _User.Username)
            {
                _ErrorMessage("Username is not exist!");
                return;
            }
            this._User.Username = txtUsername.Text;
            this._User.Password = txtPassword.Text;
            this._User.FirstName = txtFirstName.Text;
            if (!this._User.Save())
            {
                _ErrorMessage("User doesn't updated");
                return;
            }
            _OpenProfileTap();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            _OpenProfileTap();
            
        }

    }
}
