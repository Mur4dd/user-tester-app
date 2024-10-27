namespace Day_4
{
    partial class Form2
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
            testResult = new ListBox();
            testUser = new Button();
            testPassTextBox = new TextBox();
            logInPassLabel = new Label();
            testUserNameTextBox = new TextBox();
            logInUsernameLabel = new Label();
            SuspendLayout();
            // 
            // testResult
            // 
            testResult.Dock = DockStyle.Top;
            testResult.FormattingEnabled = true;
            testResult.ItemHeight = 21;
            testResult.Location = new Point(0, 0);
            testResult.Name = "testResult";
            testResult.Size = new Size(584, 88);
            testResult.TabIndex = 1;
            // 
            // testUser
            // 
            testUser.Location = new Point(12, 342);
            testUser.Name = "testUser";
            testUser.Size = new Size(557, 35);
            testUser.TabIndex = 10;
            testUser.Text = "Test";
            testUser.UseVisualStyleBackColor = true;
            testUser.Click += testUser_Click;
            // 
            // testPassTextBox
            // 
            testPassTextBox.Location = new Point(12, 253);
            testPassTextBox.Name = "testPassTextBox";
            testPassTextBox.Size = new Size(557, 29);
            testPassTextBox.TabIndex = 9;
            // 
            // logInPassLabel
            // 
            logInPassLabel.AutoSize = true;
            logInPassLabel.Location = new Point(12, 219);
            logInPassLabel.Name = "logInPassLabel";
            logInPassLabel.Size = new Size(83, 21);
            logInPassLabel.TabIndex = 8;
            logInPassLabel.Text = "Password :";
            // 
            // testUserNameTextBox
            // 
            testUserNameTextBox.Location = new Point(12, 152);
            testUserNameTextBox.Name = "testUserNameTextBox";
            testUserNameTextBox.Size = new Size(557, 29);
            testUserNameTextBox.TabIndex = 7;
            // 
            // logInUsernameLabel
            // 
            logInUsernameLabel.AutoSize = true;
            logInUsernameLabel.Location = new Point(12, 118);
            logInUsernameLabel.Name = "logInUsernameLabel";
            logInUsernameLabel.Size = new Size(88, 21);
            logInUsernameLabel.TabIndex = 6;
            logInUsernameLabel.Text = "Username :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(testUser);
            Controls.Add(testPassTextBox);
            Controls.Add(logInPassLabel);
            Controls.Add(testUserNameTextBox);
            Controls.Add(logInUsernameLabel);
            Controls.Add(testResult);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox testResult;
        private Button testUser;
        private TextBox testPassTextBox;
        private Label logInPassLabel;
        private TextBox testUserNameTextBox;
        private Label logInUsernameLabel;
    }
}