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

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateTest_Click(object sender, EventArgs e)
        {
            // Створення вікна редактора
            Form TestRedactor = new TestRedactor();
            // Задання позиції
            TestRedactor.StartPosition = FormStartPosition.Manual;
            TestRedactor.Location = this.Location;
            // Івент закриття
            TestRedactor.FormClosed += TestRedactor_Closed;
            // Перемикання між вікнами
            this.Hide();
            TestRedactor.Show();
        }

        private void TestRedactor_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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
