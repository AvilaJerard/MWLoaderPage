namespace MWLoaderPage
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblUserlogin = new System.Windows.Forms.Label();
            this.lblPEP = new System.Windows.Forms.Label();
            this.lblPEU = new System.Windows.Forms.Label();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOkey = new System.Windows.Forms.Button();
            this.lblErrrorMsg = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblUserlogin);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 23);
            this.panel1.TabIndex = 0;
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(781, -1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(34, 25);
            this.lblMinimize.TabIndex = 24;
            this.lblMinimize.Text = " - ";
            this.lblMinimize.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Black;
            this.lblBack.Location = new System.Drawing.Point(722, -1);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(64, 25);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(807, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(49, 24);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "  X  ";
            this.lblClose.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUserlogin
            // 
            this.lblUserlogin.AutoSize = true;
            this.lblUserlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserlogin.Location = new System.Drawing.Point(13, 3);
            this.lblUserlogin.Name = "lblUserlogin";
            this.lblUserlogin.Size = new System.Drawing.Size(86, 16);
            this.lblUserlogin.TabIndex = 0;
            this.lblUserlogin.Text = "User Log In";
            // 
            // lblPEP
            // 
            this.lblPEP.AutoSize = true;
            this.lblPEP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEP.ForeColor = System.Drawing.Color.Red;
            this.lblPEP.Location = new System.Drawing.Point(385, 114);
            this.lblPEP.Name = "lblPEP";
            this.lblPEP.Size = new System.Drawing.Size(161, 19);
            this.lblPEP.TabIndex = 18;
            this.lblPEP.Text = "*Password is Required";
            this.lblPEP.Visible = false;
            // 
            // lblPEU
            // 
            this.lblPEU.AutoSize = true;
            this.lblPEU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEU.ForeColor = System.Drawing.Color.Red;
            this.lblPEU.Location = new System.Drawing.Point(385, 50);
            this.lblPEU.Name = "lblPEU";
            this.lblPEU.Size = new System.Drawing.Size(160, 19);
            this.lblPEU.TabIndex = 17;
            this.lblPEU.Text = "*Username is required";
            this.lblPEU.Visible = false;
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShow.ForeColor = System.Drawing.Color.Red;
            this.checkBoxShow.Location = new System.Drawing.Point(623, 140);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(45, 13);
            this.checkBoxShow.TabIndex = 19;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = false;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // btnClearFields
            // 
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearFields.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearFields.Location = new System.Drawing.Point(500, 159);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(117, 23);
            this.btnClearFields.TabIndex = 16;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(399, 201);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(91, 23);
            this.btnLogIn.TabIndex = 15;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(389, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 22);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "Enter password here";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Red;
            this.txtUsername.Location = new System.Drawing.Point(389, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 22);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "Enter username here";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(275, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(275, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(15, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 174);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MWLoaderPage.Properties.Resources.mw_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnOkey
            // 
            this.btnOkey.BackColor = System.Drawing.Color.White;
            this.btnOkey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkey.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkey.ForeColor = System.Drawing.Color.Red;
            this.btnOkey.Location = new System.Drawing.Point(497, 226);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(325, 32);
            this.btnOkey.TabIndex = 22;
            this.btnOkey.Text = "Okey";
            this.btnOkey.UseVisualStyleBackColor = false;
            this.btnOkey.Visible = false;
            this.btnOkey.Click += new System.EventHandler(this.btnOkey_Click);
            // 
            // lblErrrorMsg
            // 
            this.lblErrrorMsg.AutoSize = true;
            this.lblErrrorMsg.BackColor = System.Drawing.Color.White;
            this.lblErrrorMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrrorMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrrorMsg.Location = new System.Drawing.Point(17, 1);
            this.lblErrrorMsg.Name = "lblErrrorMsg";
            this.lblErrrorMsg.Size = new System.Drawing.Size(286, 38);
            this.lblErrrorMsg.TabIndex = 21;
            this.lblErrrorMsg.Text = "Your Username and Password is Incorrect\r\n                     Please Try Again";
            this.lblErrrorMsg.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblErrrorMsg);
            this.panel3.Location = new System.Drawing.Point(497, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 73);
            this.panel3.TabIndex = 23;
            this.panel3.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(856, 266);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPEP);
            this.Controls.Add(this.lblPEU);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserlogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblPEP;
        private System.Windows.Forms.Label lblPEU;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.Label lblErrrorMsg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMinimize;
    }
}