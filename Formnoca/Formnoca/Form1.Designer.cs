namespace Formnoca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            chbShowPassword = new CheckBox();
            btnSignIn = new Button();
            label4 = new Label();
            LinkSignUp = new LinkLabel();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(39, 84);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(42, 140);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(42, 179);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(257, 24);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(45, 218);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 263);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(257, 25);
            txtPassword.TabIndex = 4;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.ForeColor = Color.LightCoral;
            chbShowPassword.Location = new Point(45, 294);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(108, 19);
            chbShowPassword.TabIndex = 5;
            chbShowPassword.Text = "Show password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.LightCoral;
            btnSignIn.Location = new Point(112, 348);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(143, 49);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(12, 410);
            label4.Name = "label4";
            label4.Size = new Size(229, 22);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkSignUp.LinkColor = Color.Black;
            LinkSignUp.Location = new Point(247, 410);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(82, 22);
            LinkSignUp.TabIndex = 8;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "Sign Up";
            LinkSignUp.LinkClicked += LinkSignUp_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.LightCoral;
            btnClose.Location = new Point(112, 467);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 56);
            btnClose.TabIndex = 9;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(637, 649);
            Controls.Add(btnClose);
            Controls.Add(LinkSignUp);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(chbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox chbShowPassword;
        private Button btnSignIn;
        private Label label4;
        private LinkLabel LinkSignUp;
        private Button btnClose;
    }
}
