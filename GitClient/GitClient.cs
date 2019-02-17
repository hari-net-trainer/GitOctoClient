using GitClient.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitClient
{
    public partial class GitClient : Form
    {
        private Control _stpLogin;
        private Control _stpGitSearch;
        public GitClient()
        {
            InitializeComponent();

            txtBoxGitUrl.PlaceHolderText = "Enter Enterprise GitHub Url";
            txtBoxGitUrl.Text = "https://github.wellsfargo.com/";

            _stpLogin = stpLogin;
            _stpGitSearch = stpGitSearch;

            stpLogin.Show();
            stpGitSearch.Hide();
            tpMain.SetColumn(_stpLogin, 0);
            tpMain.SetRow(_stpLogin, 1);
            tpMain.SetColumnSpan(_stpLogin, 2);

            ResetLoginControls();
            ResetSearchControls();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string gheUrl = txtBoxGitUrl.Text;
            string userId = txtBoxUserId.Text;
            string gitPsw = txtBoxPassword.Text;

            bool isValidData = true;
            List<string> formValidationErr = new List<string>();
            if (string.IsNullOrEmpty(gheUrl) || gheUrl.Equals("Enter Enterprise GitHub Url", StringComparison.InvariantCultureIgnoreCase))
            {
                isValidData = false;
                formValidationErr.Add("Please provide Valid Git Url");
            }
            if (string.IsNullOrEmpty(userId) || userId.Equals("Enter User Id/Email Id", StringComparison.InvariantCultureIgnoreCase))
            {
                isValidData = false;
                formValidationErr.Add("User Id is manadatory");
            }
            if (string.IsNullOrEmpty(gitPsw) || gitPsw.Equals("Enter Your GitHub Password", StringComparison.InvariantCultureIgnoreCase))
            {
                isValidData = false;
                formValidationErr.Add("Password is manadatory");
            }
            int retVal = GitOctoClient.Instane(gheUrl).ValdateCredentilas(userId, gitPsw);
            if (retVal < 0)
            {
                isValidData = false;
                formValidationErr.Add("Invalid login details, please try again");
                txtBoxPassword.Text = "";
                txtBoxPassword.PlaceHolderText = "Enter Your GitHub Password";
            }
            else if(retVal == 0)
            {
                isValidData = false;
                formValidationErr.Add("Login Successful, but you dont have any repositories, please use diffrent login");
                ResetLoginControls();
            }

            if (isValidData)
            {
                lblMsg.Text = string.Empty;
                txtBoxGitUrl.Enabled = false;
                ResetLoginControls();

                stpLogin.Hide();
                stpGitSearch.Show();

                tpMain.SetColumn(_stpGitSearch, 0);
                tpMain.SetRow(_stpGitSearch, 1);
                tpMain.SetColumnSpan(_stpGitSearch, 2);

                lstBoxRepos.DataSource = GitOctoClient.Instane(gheUrl).GetRepos();
                lstBoxRepos.DisplayMember = "Name";
            }
            else
            {
                lblMsg.Text = string.Join(";", formValidationErr);
            }
        }

        private void ResetLoginControls()
        {
            txtBoxUserId.Width = txtBoxGitUrl.Width - 2;
            txtBoxPassword.Width = txtBoxGitUrl.Width - 2;
            panelBtn.Width = txtBoxGitUrl.Width - 2;

            txtBoxUserId.Text = "";
            txtBoxUserId.PlaceHolderText = "Enter User Id/Email Id";
            txtBoxPassword.Text = "";
            txtBoxPassword.PlaceHolderText = "Enter Your GitHub Password";
        }

        private void ResetSearchControls()
        {
            //File search Patren, ex: *.md;build.gradel
            txtBoxFilePatren.Width = txtBoxGitUrl.Width - 2;
            lstBoxRepos.Width = txtBoxGitUrl.Width - 2;
            panelCtrl.Width = txtBoxGitUrl.Width - 2;

            txtBoxFilePatren.Text = "";
            txtBoxFilePatren.PlaceHolderText = "File search Patren, ex: *.md;build.gradel";
            IList SourceList;
            BindingSource bindingSource = (BindingSource)lstBoxRepos.DataSource;
            if (bindingSource != null)
            {
                SourceList = (IList)bindingSource.List;
                SourceList.Clear();
            }
            SourceList = new List<string> { "-- Select Repository --" };
            lstBoxRepos.DataSource = SourceList;
        }

        private void btnCancle_Close_Click(object sender, EventArgs e)
        {
            var mainWin = (Form1)this.Owner;
            mainWin.rbFileSystem.Checked = true;
            mainWin.rbGithub.Checked = false;
            this.Close();
        }
    }
}
