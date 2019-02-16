namespace GitClient
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFileType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbGithub = new System.Windows.Forms.RadioButton();
            this.rbFileSystem = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.78151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.21849F));
            this.tableLayoutPanel1.Controls.Add(this.lblFileType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileType.Location = new System.Drawing.Point(3, 0);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(66, 16);
            this.lblFileType.TabIndex = 0;
            this.lblFileType.Text = "File Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbGithub);
            this.panel1.Controls.Add(this.rbFileSystem);
            this.panel1.Location = new System.Drawing.Point(139, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 44);
            this.panel1.TabIndex = 1;
            // 
            // rbGithub
            // 
            this.rbGithub.AutoSize = true;
            this.rbGithub.Location = new System.Drawing.Point(138, 12);
            this.rbGithub.Name = "rbGithub";
            this.rbGithub.Size = new System.Drawing.Size(84, 17);
            this.rbGithub.TabIndex = 1;
            this.rbGithub.TabStop = true;
            this.rbGithub.Text = "From GitHub";
            this.rbGithub.UseVisualStyleBackColor = true;
            this.rbGithub.CheckedChanged += new System.EventHandler(this.rbGithub_CheckedChanged);
            // 
            // rbFileSystem
            // 
            this.rbFileSystem.AutoSize = true;
            this.rbFileSystem.Location = new System.Drawing.Point(13, 12);
            this.rbFileSystem.Name = "rbFileSystem";
            this.rbFileSystem.Size = new System.Drawing.Size(78, 17);
            this.rbFileSystem.TabIndex = 0;
            this.rbFileSystem.TabStop = true;
            this.rbFileSystem.Text = "File System";
            this.rbFileSystem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton rbGithub;
        public System.Windows.Forms.RadioButton rbFileSystem;
    }
}

