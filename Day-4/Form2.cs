using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void testUser_Click(object sender, EventArgs e)
        {
            string username = testUserNameTextBox.Text;
            string password = testPassTextBox.Text;

            for (int i = 0; i < Form1.GlobalData.names.Length; i++)
            {
                if (username == Form1.GlobalData.names[i] && password == Form1.GlobalData.passwords[i])
                {
                    testResult.Items.Add(username + " user is defined");
                    break;
                }
                else
                {
                    testResult.Items.Add(username + " user is undefined");
                    break;
                }
            }
        }
    }
}
