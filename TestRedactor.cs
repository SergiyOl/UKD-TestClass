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
    public partial class TestRedactor : Form
    {
        RedactorTestReferences test = new RedactorTestReferences(); 
        /*Button button = new Button();*/

        public TestRedactor()
        {
            InitializeComponent();
        }

        private void TestRedactor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*button.Location = button1.Location;
            button.Text = "@_@";
            button.Size = button1.Size;
            button.Visible = true;
            this.Controls.Add(button);
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 50);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*this.Controls.Remove(button);*/
        }

        private void createQuestion()
        {
            
        }
    }
}
