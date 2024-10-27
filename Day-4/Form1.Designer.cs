namespace Day_4
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            logInUsernameLabel = new Label();
            userNameTextBox = new TextBox();
            logInPassLabel = new Label();
            logInButton = new Button();
            testUserButton = new Button();
            passTextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Username, Password, Date });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(584, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.Width = 150;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 240;
            // 
            // logInUsernameLabel
            // 
            logInUsernameLabel.AutoSize = true;
            logInUsernameLabel.Location = new Point(15, 182);
            logInUsernameLabel.Name = "logInUsernameLabel";
            logInUsernameLabel.Size = new Size(88, 21);
            logInUsernameLabel.TabIndex = 1;
            logInUsernameLabel.Text = "Username :";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(15, 216);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(557, 29);
            userNameTextBox.TabIndex = 2;
            // 
            // logInPassLabel
            // 
            logInPassLabel.AutoSize = true;
            logInPassLabel.Location = new Point(15, 283);
            logInPassLabel.Name = "logInPassLabel";
            logInPassLabel.Size = new Size(83, 21);
            logInPassLabel.TabIndex = 3;
            logInPassLabel.Text = "Password :";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(15, 406);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(557, 35);
            logInButton.TabIndex = 5;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // testUserButton
            // 
            testUserButton.Location = new Point(15, 463);
            testUserButton.Name = "testUserButton";
            testUserButton.Size = new Size(557, 35);
            testUserButton.TabIndex = 6;
            testUserButton.Text = "Test User";
            testUserButton.UseVisualStyleBackColor = true;
            testUserButton.Click += testUserButton_Click;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(15, 317);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(557, 29);
            passTextBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(testUserButton);
            Controls.Add(logInButton);
            Controls.Add(passTextBox);
            Controls.Add(logInPassLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(logInUsernameLabel);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label logInUsernameLabel;
        private TextBox userNameTextBox;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Date;
        private Label logInPassLabel;
        private Button logInButton;
        private Button testUserButton;
        private TextBox passTextBox;
        private ErrorProvider errorProvider1;
    }
}
