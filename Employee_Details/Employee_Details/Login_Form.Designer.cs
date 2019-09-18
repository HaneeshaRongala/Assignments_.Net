namespace Employee_Details
{
    partial class Login_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.lbl_Employeelogin = new System.Windows.Forms.Label();
            this.pnl_employeelogin = new System.Windows.Forms.Panel();
            this.lnk_lbl_NewUser = new System.Windows.Forms.LinkLabel();
            this.lbl_new = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.img_Employeelogin = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_employeelogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Employeelogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employeelogin
            // 
            this.lbl_Employeelogin.AutoSize = true;
            this.lbl_Employeelogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Employeelogin.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employeelogin.ForeColor = System.Drawing.Color.Black;
            this.lbl_Employeelogin.Location = new System.Drawing.Point(192, 21);
            this.lbl_Employeelogin.Name = "lbl_Employeelogin";
            this.lbl_Employeelogin.Size = new System.Drawing.Size(240, 34);
            this.lbl_Employeelogin.TabIndex = 0;
            this.lbl_Employeelogin.Text = "EMPLOYEE LOGIN";
            this.lbl_Employeelogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_employeelogin
            // 
            this.pnl_employeelogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_employeelogin.Controls.Add(this.lnk_lbl_NewUser);
            this.pnl_employeelogin.Controls.Add(this.lbl_new);
            this.pnl_employeelogin.Controls.Add(this.btnLogin);
            this.pnl_employeelogin.Controls.Add(this.pictureBox3);
            this.pnl_employeelogin.Controls.Add(this.pictureBox2);
            this.pnl_employeelogin.Controls.Add(this.txt_Password);
            this.pnl_employeelogin.Controls.Add(this.txt_UserName);
            this.pnl_employeelogin.Controls.Add(this.lbl_Password);
            this.pnl_employeelogin.Controls.Add(this.lbl_UserName);
            this.pnl_employeelogin.Controls.Add(this.img_Employeelogin);
            this.pnl_employeelogin.Controls.Add(this.lbl_Employeelogin);
            this.pnl_employeelogin.Location = new System.Drawing.Point(160, 24);
            this.pnl_employeelogin.Name = "pnl_employeelogin";
            this.pnl_employeelogin.Size = new System.Drawing.Size(538, 468);
            this.pnl_employeelogin.TabIndex = 1;
            // 
            // lnk_lbl_NewUser
            // 
            this.lnk_lbl_NewUser.AutoSize = true;
            this.lnk_lbl_NewUser.Location = new System.Drawing.Point(299, 387);
            this.lnk_lbl_NewUser.Name = "lnk_lbl_NewUser";
            this.lnk_lbl_NewUser.Size = new System.Drawing.Size(119, 17);
            this.lnk_lbl_NewUser.TabIndex = 14;
            this.lnk_lbl_NewUser.TabStop = true;
            this.lnk_lbl_NewUser.Text = "Create Account";
            this.lnk_lbl_NewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_lbl_NewUser_LinkClicked);
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new.ForeColor = System.Drawing.Color.Black;
            this.lbl_new.Location = new System.Drawing.Point(108, 387);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(158, 17);
            this.lbl_new.TabIndex = 13;
            this.lbl_new.Text = "Don\'t have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(184, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 41);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Image = global::Employee_Details.Properties.Resources.Iconsmind_Outline_Password_shopping;
            this.pictureBox3.Location = new System.Drawing.Point(133, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Image = global::Employee_Details.Properties.Resources.Double_J_Design_Origami_Colored_Pencil_Blue_user;
            this.pictureBox2.Location = new System.Drawing.Point(133, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Password
            // 
            this.txt_Password.ForeColor = System.Drawing.Color.Silver;
            this.txt_Password.Location = new System.Drawing.Point(133, 248);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(247, 32);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.Text = "Enter your Password";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.Enter += new System.EventHandler(this.txt_PasswordEnter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_PasswordLeave);
            // 
            // txt_UserName
            // 
            this.txt_UserName.ForeColor = System.Drawing.Color.Silver;
            this.txt_UserName.Location = new System.Drawing.Point(133, 153);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(247, 32);
            this.txt_UserName.TabIndex = 8;
            this.txt_UserName.Text = "Enter your Username";
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_UserName.Enter += new System.EventHandler(this.txt_UserNameEnter);
            this.txt_UserName.Leave += new System.EventHandler(this.txt_UsernameLeave);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(193, 209);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(98, 25);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.Black;
            this.lbl_UserName.Location = new System.Drawing.Point(193, 109);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(102, 25);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "Username";
            // 
            // img_Employeelogin
            // 
            this.img_Employeelogin.BackColor = System.Drawing.Color.White;
            this.img_Employeelogin.Image = global::Employee_Details.Properties.Resources.Double_J_Design_Origami_Colored_Pencil_Blue_user;
            this.img_Employeelogin.Location = new System.Drawing.Point(97, 12);
            this.img_Employeelogin.Name = "img_Employeelogin";
            this.img_Employeelogin.Size = new System.Drawing.Size(89, 78);
            this.img_Employeelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Employeelogin.TabIndex = 1;
            this.img_Employeelogin.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(847, 554);
            this.Controls.Add(this.pnl_employeelogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.pnl_employeelogin.ResumeLayout(false);
            this.pnl_employeelogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Employeelogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employeelogin;
        private System.Windows.Forms.Panel pnl_employeelogin;
        private System.Windows.Forms.PictureBox img_Employeelogin;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnk_lbl_NewUser;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        // private System.Windows.Forms.TextBox txt_UserName;
    }
}

