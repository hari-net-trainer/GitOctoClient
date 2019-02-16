using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbGithub_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGithub.Checked)
            {
                GitClient popupWin = new GitClient();
                popupWin.ShowDialog(this);
            }
        }
    }
}
