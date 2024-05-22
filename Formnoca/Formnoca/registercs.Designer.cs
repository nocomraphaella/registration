namespace Formnoca
{
    partial class registercs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registercs));
            btnSignIn = new Button();
            BtnRegisterAccount = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.LightCoral;
            btnSignIn.Location = new Point(72, 531);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(270, 49);
            btnSignIn.TabIndex = 18;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // BtnRegisterAccount
            // 
            BtnRegisterAccount.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegisterAccount.ForeColor = Color.LightCoral;
            BtnRegisterAccount.Location = new Point(72, 468);
            BtnRegisterAccount.Name = "BtnRegisterAccount";
            BtnRegisterAccount.Size = new Size(270, 46);
            BtnRegisterAccount.TabIndex = 17;
            BtnRegisterAccount.Text = "Resgister Account";
            BtnRegisterAccount.UseVisualStyleBackColor = true;
            BtnRegisterAccount.Click += BtnRegisterAccount_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(65, 402);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(257, 25);
            txtPassword.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(68, 363);
            label4.Name = "label4";
            label4.Size = new Size(109, 24);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(65, 303);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(257, 24);
            txtUsername.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(65, 256);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 13;
            label3.Text = "Username";
            // 
            // txtname
            // 
            txtname.Location = new Point(65, 211);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Enter your name";
            txtname.Size = new Size(257, 24);
            txtname.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(65, 166);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(72, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 10;
            label2.Text = "SIGN UP";
            // 
            // registercs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(754, 769);
            Controls.Add(btnSignIn);
            Controls.Add(BtnRegisterAccount);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "registercs";
            Text = "registercs";
            Load += registercs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Button BtnRegisterAccount;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtname;
        private Label label1;
        private Label label2;
    }
}