using AdminsBusinessLayer;
using QuestionsBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using UsersBusinessLayer;

namespace Quiz
{

    public partial class frmDashboardMain : Form
    {
        public enum enCurrentDataShow { Users = 0, Questions = 1, Admins = 2 };
        private enCurrentDataShow _CurrentDataShow;
        clsAdmin _Admin;
        public frmDashboardMain(clsAdmin Admin)
        {
            InitializeComponent();

            _Admin = Admin;
        }
        private void _LoadQuestionsData()
        {
            DataTable QuestionsData = clsQuestion.GetAllQuestions();
            dgvData.DataSource = QuestionsData;
            _RefreshData();
        }
        private void _LoadUsersData()
        {
            dgvData.DataSource = clsUser.GetAllUsers();
            _RefreshData();
        }
        private void _LoadAdminsData()
        {
            dgvData.DataSource = clsAdmin.GetAllAdmins();
        }

        private void _RefreshData()
        {
            lblTotalUsers.Text = clsUser.GetAllUsers().Rows.Count.ToString();
            lblTotalQuestions.Text = clsQuestion.GetAllQuestions().Rows.Count.ToString();
        }
        private void frmDashboardMain_Load(object sender, EventArgs e)
        {
            cbDataToShow.SelectedIndex = 0;

        }

        private void cbDataToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSearch.Items.Clear();
            if (cbDataToShow.SelectedIndex == 0)
            {
                cbSearch.Items.Add("UserID");
                cbSearch.Items.Add("Username");
                cbSearch.Items.Add("FirstName");
                cbSearch.Items.Add("TotalAnswers");
                cbSearch.Items.Add("TotalRightAnswers");
                cbSearch.SelectedIndex = 0;
                _CurrentDataShow = enCurrentDataShow.Users;
                _LoadUsersData();
            }

            if (cbDataToShow.SelectedIndex == 1)
            {
                cbSearch.Items.Add("QuestionID");
                cbSearch.Items.Add("RightAnswerID");
                cbSearch.Items.Add("AdminID");
                cbSearch.Items.Add("Date");
                cbSearch.SelectedIndex = 0;
                _CurrentDataShow = enCurrentDataShow.Questions;
                _LoadQuestionsData();
            }
            if (cbDataToShow.SelectedIndex == 2)
            {
                cbSearch.Items.Add("AdminID");
                cbSearch.Items.Add("UserID");
                cbSearch.Items.Add("TotalAddedQuestions");
                cbSearch.SelectedIndex = 0;
                _CurrentDataShow = enCurrentDataShow.Admins;
                _LoadAdminsData();
            }

            

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentDataShow == enCurrentDataShow.Questions)
            {

                frmAddQuestion frm = new frmAddQuestion((int)dgvData.CurrentRow.Cells[0].Value, _Admin);
                frm.ShowDialog();
                _LoadQuestionsData();
            }
            if(_CurrentDataShow == enCurrentDataShow.Users)
            {
                frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvData.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _LoadUsersData();
            }
            if(_CurrentDataShow == enCurrentDataShow.Admins)
            {
                MessageBox.Show("You can't update Admins Data!\n\nif you want to update it you must update it from users table");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(_CurrentDataShow == enCurrentDataShow.Users)
            {
                frmAddUpdateUser frm = new frmAddUpdateUser(-1);
                frm.ShowDialog();
                _LoadUsersData();
            }

            if (_CurrentDataShow == enCurrentDataShow.Questions)
            {

                frmAddQuestion frm = new frmAddQuestion(-1, _Admin);
                frm.ShowDialog();
                _LoadQuestionsData();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this record?", "Are your sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (_CurrentDataShow == enCurrentDataShow.Questions)
            {
                clsQuestion.DeleteQuestion((int)dgvData.CurrentRow.Cells[0].Value);
                _LoadQuestionsData();
                return;
            }
            if (_CurrentDataShow == enCurrentDataShow.Users)
            {
                clsUser.DeleteUser((int)dgvData.CurrentRow.Cells[0].Value);
                _LoadUsersData();
                return;
            }
            if (_CurrentDataShow == enCurrentDataShow.Admins)
            {
                MessageBox.Show("You can't delete Admins Data!\n\nif you want to delete it you must delete it from users table");
            }
        }


        private void _SearchInData(DataTable dt, string ColumnToSearch, string SearchTxt)
        {
            if(string.IsNullOrEmpty(SearchTxt))
            {
                dgvData.DataSource = dt;
                return;
            }
            DataView DataViewFilteredData = dt.DefaultView;
            DataViewFilteredData.RowFilter = string.Empty;

            string FilterString = $"CONVERT({ColumnToSearch}, 'System.String') LIKE '{SearchTxt}%'";
            DataViewFilteredData.RowFilter = FilterString;

            dgvData.DataSource = DataViewFilteredData;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_CurrentDataShow == enCurrentDataShow.Questions)
            {
                _SearchInData(clsQuestion.GetAllQuestions(), cbSearch.Text, txtSearch.Text);
            }
            if (_CurrentDataShow == enCurrentDataShow.Users)
            {
                _SearchInData(clsUser.GetAllUsers(), cbSearch.Text, txtSearch.Text);
            }
        }
    }
}
