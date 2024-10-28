namespace Day_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class GlobalData
        {
            public static string[] names = new string[128];
            public static string[] passwords = new string[128];
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passTextBox.Text;

            if (userNameTextBox.Text == "")
            {
                errorProvider1.SetError(userNameTextBox , "Username is nothing");
            }
            else
            {
                errorProvider1.Clear();
            }
            
            if (passTextBox.Text == "")
            {
                errorProvider1.SetError(passTextBox , "Password is nothing");
            }
            else
            {
                errorProvider1.Clear();
            }


            if (username != string.Empty || password != string.Empty)
            {
                GlobalData.names[0] = username;
                GlobalData.passwords[0] = password;

                dataGridView1.Rows.Add(username, password, DateTime.Now);
            }

            userNameTextBox.Text = "";
            passTextBox.Text = "";
        }

        private void testUserButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
