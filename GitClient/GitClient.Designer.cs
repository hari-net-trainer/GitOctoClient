using System.Windows.Forms;

namespace GitClient
{
    partial class GitClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblGitEUrl = new System.Windows.Forms.Label();
            this.txtBoxGitUrl = new System.Windows.Forms.PlaceHolderTextBox();
            this.stpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUserId = new System.Windows.Forms.PlaceHolderTextBox();
            this.txtBoxPassword = new System.Windows.Forms.PlaceHolderTextBox();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.stpGitSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblRepoList = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxFilePatren = new System.Windows.Forms.PlaceHolderTextBox();
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.lstBoxRepos = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tpMain.SuspendLayout();
            this.stpLogin.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.stpGitSearch.SuspendLayout();
            this.panelCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.ColumnCount = 2;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.32424F));
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.67576F));
            this.tpMain.Controls.Add(this.lblGitEUrl, 0, 0);
            this.tpMain.Controls.Add(this.txtBoxGitUrl, 1, 0);
            this.tpMain.Controls.Add(this.stpLogin, 0, 1);
            this.tpMain.Controls.Add(this.stpGitSearch, 1, 1);
            this.tpMain.Controls.Add(this.lblInfo, 0, 2);
            this.tpMain.Location = new System.Drawing.Point(12, 12);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 3;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpMain.Size = new System.Drawing.Size(623, 141);
            this.tpMain.TabIndex = 0;
            // 
            // lblGitEUrl
            // 
            this.lblGitEUrl.AutoSize = true;
            this.lblGitEUrl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitEUrl.Location = new System.Drawing.Point(3, 0);
            this.lblGitEUrl.Name = "lblGitEUrl";
            this.lblGitEUrl.Size = new System.Drawing.Size(121, 16);
            this.lblGitEUrl.TabIndex = 0;
            this.lblGitEUrl.Text = "Enterprise GitUri *";
            // 
            // txtBoxGitUrl
            // 
            this.txtBoxGitUrl.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxGitUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxGitUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtBoxGitUrl.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxGitUrl.Location = new System.Drawing.Point(167, 3);
            this.txtBoxGitUrl.Name = "txtBoxGitUrl";
            this.txtBoxGitUrl.PlaceHolderText = "Enter Enterprise GitHub Url";
            this.txtBoxGitUrl.Size = new System.Drawing.Size(453, 20);
            this.txtBoxGitUrl.TabIndex = 1;
            this.txtBoxGitUrl.Text = "https://github.wellsfargo.com";
            // 
            // stpLogin
            // 
            this.stpLogin.ColumnCount = 2;
            this.stpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.stpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.stpLogin.Controls.Add(this.label1, 0, 0);
            this.stpLogin.Controls.Add(this.label2, 0, 1);
            this.stpLogin.Controls.Add(this.txtBoxUserId, 1, 0);
            this.stpLogin.Controls.Add(this.txtBoxPassword, 1, 1);
            this.stpLogin.Controls.Add(this.panelBtn, 1, 2);
            this.stpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpLogin.Location = new System.Drawing.Point(3, 24);
            this.stpLogin.Name = "stpLogin";
            this.stpLogin.RowCount = 3;
            this.stpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.stpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.stpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.stpLogin.Size = new System.Drawing.Size(158, 99);
            this.stpLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password *";
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtBoxUserId.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxUserId.Location = new System.Drawing.Point(44, 3);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.PlaceHolderText = "Enter User Id/Email Id";
            this.txtBoxUserId.Size = new System.Drawing.Size(111, 20);
            this.txtBoxUserId.TabIndex = 2;
            this.txtBoxUserId.Text = "Enter User Id/Email Id";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxPassword.Location = new System.Drawing.Point(44, 35);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.PlaceHolderText = "Enter Your GitHub Password";
            this.txtBoxPassword.Size = new System.Drawing.Size(111, 20);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.Text = "Enter Your GitHub Password";
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnCancle);
            this.panelBtn.Controls.Add(this.btnLogIn);
            this.panelBtn.Location = new System.Drawing.Point(44, 67);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(111, 27);
            this.panelBtn.TabIndex = 4;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(-39, 0);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 27);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Close_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(36, 0);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 27);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // stpGitSearch
            // 
            this.stpGitSearch.ColumnCount = 2;
            this.stpGitSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.stpGitSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.stpGitSearch.Controls.Add(this.lblRepoList, 0, 0);
            this.stpGitSearch.Controls.Add(this.lblSearch, 0, 1);
            this.stpGitSearch.Controls.Add(this.txtBoxFilePatren, 1, 1);
            this.stpGitSearch.Controls.Add(this.panelCtrl, 1, 2);
            this.stpGitSearch.Controls.Add(this.lstBoxRepos, 1, 0);
            this.stpGitSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpGitSearch.Location = new System.Drawing.Point(167, 24);
            this.stpGitSearch.Name = "stpGitSearch";
            this.stpGitSearch.RowCount = 3;
            this.stpGitSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.stpGitSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.stpGitSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.stpGitSearch.Size = new System.Drawing.Size(453, 99);
            this.stpGitSearch.TabIndex = 3;
            this.stpGitSearch.Visible = false;
            // 
            // lblRepoList
            // 
            this.lblRepoList.AutoSize = true;
            this.lblRepoList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepoList.Location = new System.Drawing.Point(3, 0);
            this.lblRepoList.Name = "lblRepoList";
            this.lblRepoList.Size = new System.Drawing.Size(95, 16);
            this.lblRepoList.TabIndex = 0;
            this.lblRepoList.Text = "Repositories *";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(85, 32);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search File Patren #";
            // 
            // txtBoxFilePatren
            // 
            this.txtBoxFilePatren.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxFilePatren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFilePatren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtBoxFilePatren.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxFilePatren.Location = new System.Drawing.Point(120, 35);
            this.txtBoxFilePatren.Name = "txtBoxFilePatren";
            this.txtBoxFilePatren.PlaceHolderText = "File search Patren, ex: *.md;build.gradel";
            this.txtBoxFilePatren.Size = new System.Drawing.Size(330, 20);
            this.txtBoxFilePatren.TabIndex = 3;
            this.txtBoxFilePatren.Text = "File search Patren, ex: *.md;build.gradel";
            // 
            // panelCtrl
            // 
            this.panelCtrl.Controls.Add(this.btnClose);
            this.panelCtrl.Controls.Add(this.btnSearchFile);
            this.panelCtrl.Location = new System.Drawing.Point(120, 67);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(330, 27);
            this.panelCtrl.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(180, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancle_Close_Click);
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFile.Location = new System.Drawing.Point(255, 0);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(75, 27);
            this.btnSearchFile.TabIndex = 0;
            this.btnSearchFile.Text = "Search";
            this.btnSearchFile.UseVisualStyleBackColor = false;
            // 
            // lstBoxRepos
            // 
            this.lstBoxRepos.BackColor = System.Drawing.SystemColors.Info;
            this.lstBoxRepos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRepos.FormattingEnabled = true;
            this.lstBoxRepos.Location = new System.Drawing.Point(120, 3);
            this.lstBoxRepos.Name = "lstBoxRepos";
            this.lstBoxRepos.Size = new System.Drawing.Size(330, 21);
            this.lstBoxRepos.TabIndex = 5;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(12, 156);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(78, 14);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Error Message";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.tpMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 126);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(617, 15);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "* Required Fields, # Serceh file paterns for multiple patrens sapatare with semic" +
    "olan;)";
            // 
            // GitClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 206);
            this.ControlBox = false;
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.tpMain);
            this.MinimizeBox = false;
            this.Name = "GitClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GitClient";
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.stpLogin.ResumeLayout(false);
            this.stpLogin.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.stpGitSearch.ResumeLayout(false);
            this.stpGitSearch.PerformLayout();
            this.panelCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblGitEUrl;
        private System.Windows.Forms.TableLayoutPanel stpLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PlaceHolderTextBox txtBoxUserId;
        private PlaceHolderTextBox txtBoxGitUrl;
        private PlaceHolderTextBox txtBoxPassword;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TableLayoutPanel stpGitSearch;
        private System.Windows.Forms.Label lblRepoList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Panel panelCtrl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearchFile;
        private PlaceHolderTextBox txtBoxFilePatren;
        private System.Windows.Forms.ComboBox lstBoxRepos;
        private Label lblInfo;
    }
}