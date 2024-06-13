using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UKD_TestClass
{
    public partial class StartPage : Form
    {
        Form testRedactor;

        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateTest_Click(object sender, EventArgs e)
        {
            OpenTestRedactor("Create");
        }

        private void OpenTestRedactor(string tag)
        {
            // Створення вікна редактора
            testRedactor = new TestRedactor();
            // Передання тегу
            testRedactor.Tag = tag;
            // Задання позиції
            testRedactor.StartPosition = FormStartPosition.Manual;
            testRedactor.Location = this.Location;
            // Івент закриття
            testRedactor.FormClosed += TestRedactor_Closed;
            // Перемикання між вікнами
            this.Hide();
            testRedactor.Show();
        }

        private void TestRedactor_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_RedactTest_Click(object sender, EventArgs e)
        {
            OpenTestRedactor("Load");
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
