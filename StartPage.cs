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
        Form takeTest;

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
            testRedactor.FormClosed += Tab_Closed;
            // Перемикання між вікнами
            this.Hide();
            testRedactor.Show();
        }

        private void Tab_Closed(object sender, FormClosedEventArgs e)
        {
            if ((sender as Form).Tag == "Back")
                this.Show();
            else
                this.Close();
        }

        private void button_RedactTest_Click(object sender, EventArgs e)
        {
            OpenTestRedactor("Load");
        }

        private void button_TakeTest_Click(object sender, EventArgs e)
        {
            // Створення вікна редактора
            takeTest = new TakeTest();
            // Задання позиції
            takeTest.StartPosition = FormStartPosition.Manual;
            takeTest.Location = this.Location;
            // Івент закриття
            takeTest.FormClosed += Tab_Closed;
            // Перемикання між вікнами
            this.Hide();
            takeTest.Show();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            Form AboutPage = new AboutPage();
            AboutPage.Show();
        }
    }
}
