namespace MWLoaderPage
{
    partial class Frm2LogInMW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm2LogInMW));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1Quit = new System.Windows.Forms.Button();
            this.btn2minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPEU = new System.Windows.Forms.Label();
            this.lblPEP = new System.Windows.Forms.Label();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.lblErrrorMsg = new System.Windows.Forms.Label();
            this.btnOkey = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(361, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(361, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Red;
            this.txtUsername.Location = new System.Drawing.Point(475, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 22);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Enter username here";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(475, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Enter password here";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(485, 216);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(91, 23);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearFields.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearFields.Location = new System.Drawing.Point(586, 174);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(117, 23);
            this.btnClearFields.TabIndex = 6;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 285);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn1Quit
            // 
            this.btn1Quit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn1Quit.BackColor = System.Drawing.Color.Red;
            this.btn1Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Quit.ForeColor = System.Drawing.Color.Snow;
            this.btn1Quit.ImageKey = "(none)";
            this.btn1Quit.Location = new System.Drawing.Point(729, -1);
            this.btn1Quit.Name = "btn1Quit";
            this.btn1Quit.Size = new System.Drawing.Size(49, 48);
            this.btn1Quit.TabIndex = 1;
            this.btn1Quit.Text = "X";
            this.btn1Quit.UseVisualStyleBackColor = false;
            this.btn1Quit.Click += new System.EventHandler(this.btn1Quit_Click);
            // 
            // btn2minimize
            // 
            this.btn2minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn2minimize.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn2minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2minimize.Location = new System.Drawing.Point(695, -1);
            this.btn2minimize.Name = "btn2minimize";
            this.btn2minimize.Size = new System.Drawing.Size(38, 48);
            this.btn2minimize.TabIndex = 1;
            this.btn2minimize.Text = "_";
            this.btn2minimize.UseVisualStyleBackColor = false;
            this.btn2minimize.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin LogIn to MW Moto HUB";
            // 
            // lblPEU
            // 
            this.lblPEU.AutoSize = true;
            this.lblPEU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEU.ForeColor = System.Drawing.Color.Red;
            this.lblPEU.Location = new System.Drawing.Point(471, 65);
            this.lblPEU.Name = "lblPEU";
            this.lblPEU.Size = new System.Drawing.Size(160, 19);
            this.lblPEU.TabIndex = 8;
            this.lblPEU.Text = "*Username is required";
            this.lblPEU.Visible = false;
            // 
            // lblPEP
            // 
            this.lblPEP.AutoSize = true;
            this.lblPEP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEP.ForeColor = System.Drawing.Color.Red;
            this.lblPEP.Location = new System.Drawing.Point(471, 129);
            this.lblPEP.Name = "lblPEP";
            this.lblPEP.Size = new System.Drawing.Size(161, 19);
            this.lblPEP.TabIndex = 9;
            this.lblPEP.Text = "*Password is Required";
            this.lblPEP.Visible = false;
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShow.ForeColor = System.Drawing.Color.Red;
            this.checkBoxShow.Location = new System.Drawing.Point(709, 155);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(45, 13);
            this.checkBoxShow.TabIndex = 10;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = false;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // lblErrrorMsg
            // 
            this.lblErrrorMsg.AutoSize = true;
            this.lblErrrorMsg.BackColor = System.Drawing.Color.White;
            this.lblErrrorMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrrorMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrrorMsg.Location = new System.Drawing.Point(447, 242);
            this.lblErrrorMsg.Name = "lblErrrorMsg";
            this.lblErrrorMsg.Size = new System.Drawing.Size(286, 95);
            this.lblErrrorMsg.TabIndex = 11;
            this.lblErrrorMsg.Text = "Your Username and Password is Incorrect\r\n                     Please Try Again\r\n\r" +
    "\n\r\n\r\n";
            this.lblErrrorMsg.Visible = false;
            // 
            // btnOkey
            // 
            this.btnOkey.BackColor = System.Drawing.Color.Black;
            this.btnOkey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkey.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkey.ForeColor = System.Drawing.Color.Red;
            this.btnOkey.Location = new System.Drawing.Point(545, 289);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(94, 32);
            this.btnOkey.TabIndex = 12;
            this.btnOkey.Text = "Okey";
            this.btnOkey.UseVisualStyleBackColor = false;
            this.btnOkey.Visible = false;
            this.btnOkey.Click += new System.EventHandler(this.btnOkey_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(595, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 32);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm2LogInMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(777, 355);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPEP);
            this.Controls.Add(this.lblPEU);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn1Quit);
            this.Controls.Add(this.btn2minimize);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrrorMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm2LogInMW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInMW";
            this.Load += new System.EventHandler(this.Frm2LogInMW_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1Quit;
        private System.Windows.Forms.Button btn2minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPEU;
        private System.Windows.Forms.Label lblPEP;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.Label lblErrrorMsg;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.Button btnBack;
    }
}