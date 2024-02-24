using AdminsBusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz
{
    public partial class frmLogin : Form
    {
        private clsUser User = null;
        private bool _IsLoginSuccess { get; set; }
        public frmLogin(bool IsLoginSuccess)
        {
            InitializeComponent();
            this._IsLoginSuccess = IsLoginSuccess;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if(pb.Tag.ToString() == "show")
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

        private void txt_Enter(object sender, EventArgs e)
        {
            clsTextColor.ChangeTextColor(sender);
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            clsTextColor.ChangeTextColor(sender, false);
        }

        
        private void _ErrorMessage(string Message, string Caption ="Error" )
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                _ErrorMessage("You have to fill all text boxes!");
                return;
            }

            clsUser User = clsUser.Find(Username);
            if (User == null)
            {
                _ErrorMessage("User not found !");
                return;
            
            }
            if (Password != User.Password) {
                _ErrorMessage("Password Doesn't match");
                return;
            }
            this.User = User;
            _IsLoginSuccess = true;
            this.Close();
        }
        public clsUser GetCurrnetUser()
        {
            return User;
        }
        public bool IsSuccessfulLogin()
        {
            return _IsLoginSuccess;
        }

        public bool IsAdmin()
        {
            return clsAdmin.isAdminExistByUserID(User.UserID);
        }
    }
}
