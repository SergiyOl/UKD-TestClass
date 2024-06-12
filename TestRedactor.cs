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
        int questionAmount = 0;
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
            createQuestion();
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 200);
            /*button.Location = button1.Location;
            button.Text = "@_@";
            button.Size = button1.Size;
            button.Visible = true;
            this.Controls.Add(button);
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 50);*/
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            /*this.Controls.Remove(button);*/
        }

        private void createQuestion()
        {
            // Номер питання
            questionAmount++;
            // Текст
            Label label = new Label
            {
                AutoSize = true,
                Location = new Point(23, 31),
                Name = "label",
                Size = new Size(69, 17),
                TabIndex = 19,
                Text = "Питання:"
            };
            // Питання
            TextBox textBoxQuestion = new TextBox
            {
                Location = new Point(76, 28),
                Name = "textBoxQuestion",
                Size = new Size(720, 22),
                TabIndex = 20
            };
            // Вибір варіанту
            RadioButton radioButtonV1 = new RadioButton();
            RadioButton radioButtonV2 = new RadioButton();
            RadioButton radioButtonV3 = new RadioButton();
            RadioButton radioButtonV4 = new RadioButton();

            radioButtonV1.AutoSize = true;
            radioButtonV1.Location = new Point(27, 68);
            radioButtonV1.Name = "radioButtonV1";
            radioButtonV1.Size = new Size(17, 16);
            radioButtonV1.TabIndex = 0;
            radioButtonV1.TabStop = true;
            radioButtonV1.UseVisualStyleBackColor = true;

            radioButtonV2.AutoSize = true;
            radioButtonV2.Location = new Point(27, 95);
            radioButtonV2.Name = "radioButtonV2";
            radioButtonV2.Size = new Size(17, 16);
            radioButtonV2.TabIndex = 1;
            radioButtonV2.TabStop = true;
            radioButtonV2.UseVisualStyleBackColor = true;

            radioButtonV3.AutoSize = true;
            radioButtonV3.Location = new Point(27, 122);
            radioButtonV3.Name = "radioButtonV3";
            radioButtonV3.Size = new Size(17, 16);
            radioButtonV3.TabIndex = 2;
            radioButtonV3.TabStop = true;
            radioButtonV3.UseVisualStyleBackColor = true;

            radioButtonV4.AutoSize = true;
            radioButtonV4.Location = new Point(27, 149);
            radioButtonV4.Name = "radioButtonV4";
            radioButtonV4.Size = new Size(17, 16);
            radioButtonV4.TabIndex = 3;
            radioButtonV4.TabStop = true;
            radioButtonV4.UseVisualStyleBackColor = true;
            // Текст варіантів
            TextBox textBoxV1 = new TextBox();
            TextBox textBoxV2 = new TextBox();
            TextBox textBoxV3 = new TextBox();
            TextBox textBoxV4 = new TextBox();

            textBoxV1.Location = new Point(51, 65);
            textBoxV1.Name = "textBoxV1";
            textBoxV1.Size = new Size(550, 22);
            textBoxV1.TabIndex = 15;

            textBoxV2.Location = new Point(51, 92);
            textBoxV2.Name = "textBoxV2";
            textBoxV2.Size = new Size(550, 22);
            textBoxV2.TabIndex = 16;

            textBoxV3.Location = new Point(51, 119);
            textBoxV3.Name = "textBoxV3";
            textBoxV3.Size = new Size(550, 22);
            textBoxV3.TabIndex = 17;

            textBoxV4.Location = new Point(50, 146);
            textBoxV4.Name = "textBoxV4";
            textBoxV4.Size = new Size(550, 22);
            textBoxV4.TabIndex = 18;
            // Кнопка видалення
            Button buttonDelete = new Button();
            
            buttonDelete.Location = new Point(620, 70);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(160, 30);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Видалити питання";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new EventHandler(buttonDelete_Click);
            // Коробка
            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(buttonDelete);
            groupBox.Controls.Add(textBoxQuestion);
            groupBox.Controls.Add(label);
            groupBox.Controls.Add(textBoxV4);
            groupBox.Controls.Add(textBoxV3);
            groupBox.Controls.Add(textBoxV2);
            groupBox.Controls.Add(textBoxV1);
            groupBox.Controls.Add(radioButtonV4);
            groupBox.Controls.Add(radioButtonV3);
            groupBox.Controls.Add(radioButtonV2);
            groupBox.Controls.Add(radioButtonV1);
            groupBox.Location = new Point(48, button1.Location.Y); 
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(810, 180);
            groupBox.TabIndex = 10;
            groupBox.TabStop = false;
            groupBox.Text = $"Питання #{questionAmount}";
            // Виведення
            this.Controls.Add(groupBox);
            // Збереження
        }
    }
}
