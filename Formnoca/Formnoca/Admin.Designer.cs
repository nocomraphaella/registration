namespace Formnoca
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label1 = new Label();
            TxtID = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            cbRole = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnLogout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(311, 49);
            label1.Name = "label1";
            label1.Size = new Size(234, 56);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(76, 132);
            TxtID.Multiline = true;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(170, 28);
            TxtID.TabIndex = 1;
            TxtID.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(76, 105);
            label2.Name = "label2";
            label2.Size = new Size(21, 24);
            label2.TabIndex = 2;
            label2.Text = "#";
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 210);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 28);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(76, 183);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(76, 263);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(76, 290);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 28);
            txtUsername.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(76, 345);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(76, 372);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 28);
            txtPassword.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(76, 429);
            label6.Name = "label6";
            label6.Size = new Size(52, 24);
            label6.TabIndex = 9;
            label6.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.AutoCompleteCustomSource.AddRange(new string[] { "Teacher\t", "Admin", "Student" });
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Teacher", "Student", "Admin" });
            cbRole.Location = new Point(76, 456);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(170, 23);
            cbRole.TabIndex = 10;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.LightCoral;
            btnAdd.Location = new Point(76, 517);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 45);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.LightCoral;
            btnUpdate.Location = new Point(76, 568);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 45);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Black;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.LightCoral;
            btnRemove.Location = new Point(76, 619);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(170, 45);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.LightCoral;
            btnLogout.Location = new Point(802, 60);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 45);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(311, 132);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(481, 28);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.LightCoral;
            btnSearch.Location = new Point(802, 132);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(170, 28);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(311, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(661, 454);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1011, 762);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbRole);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtID;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private ComboBox cbRole;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
    }
}