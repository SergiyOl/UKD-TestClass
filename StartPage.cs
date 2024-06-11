using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKD_TestClass
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing yet", "Work in progress",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_RedactTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing yet", "Work in progress",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_TakeTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing yet", "Work in progress",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            Form AboutPage = new AboutPage();
            AboutPage.Show();
        }
    }
}
