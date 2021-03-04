namespace E_MagazineSystem
{
    partial class Subscribe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMagName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelIssueNo = new System.Windows.Forms.Label();
            this.comboBoxNoOfMonths = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMagName
            // 
            this.labelMagName.AutoSize = true;
            this.labelMagName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(165)))), ((int)(((byte)(163)))));
            this.labelMagName.Location = new System.Drawing.Point(14, 28);
            this.labelMagName.Name = "labelMagName";
            this.labelMagName.Size = new System.Drawing.Size(256, 36);
            this.labelMagName.TabIndex = 13;
            this.labelMagName.Text = "Magazine Name";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(20, 68);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(827, 10);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.labelIssueNo);
            this.panel1.Controls.Add(this.comboBoxNoOfMonths);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(242, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 302);
            this.panel1.TabIndex = 20;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(165)))), ((int)(((byte)(163)))));
            this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(243, 172);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(93, 33);
            this.buttonConfirm.TabIndex = 22;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // labelIssueNo
            // 
            this.labelIssueNo.AutoSize = true;
            this.labelIssueNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueNo.Location = new System.Drawing.Point(81, 236);
            this.labelIssueNo.Name = "labelIssueNo";
            this.labelIssueNo.Size = new System.Drawing.Size(48, 17);
            this.labelIssueNo.TabIndex = 15;
            this.labelIssueNo.Text = "Issue #";
            // 
            // comboBoxNoOfMonths
            // 
            this.comboBoxNoOfMonths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNoOfMonths.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNoOfMonths.FormattingEnabled = true;
            this.comboBoxNoOfMonths.Items.AddRange(new object[] {
            "1 Month",
            "2 Months",
            "3 Months",
            "4 Months",
            "5 Months",
            "6 Months"});
            this.comboBoxNoOfMonths.Location = new System.Drawing.Point(227, 104);
            this.comboBoxNoOfMonths.Name = "comboBoxNoOfMonths";
            this.comboBoxNoOfMonths.Size = new System.Drawing.Size(128, 24);
            this.comboBoxNoOfMonths.TabIndex = 21;
            this.comboBoxNoOfMonths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxNoOfMonths_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(47, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Controls.Add(this.labelMagName);
            this.Content.Controls.Add(this.panel1);
            this.Content.Controls.Add(this.bunifuSeparator1);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(879, 448);
            this.Content.TabIndex = 21;
            // 
            // Subscribe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Content);
            this.Name = "Subscribe";
            this.Size = new System.Drawing.Size(879, 448);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMagName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIssueNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxNoOfMonths;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel Content;
    }
}
