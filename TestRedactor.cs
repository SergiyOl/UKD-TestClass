using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace UKD_TestClass
{
    public partial class TestRedactor : Form
    {
        RedactorTestReferences testReferences = new RedactorTestReferences();
        TestInfo testInfo;
        int questionAmount = 0;

        public TestRedactor()
        {
            InitializeComponent();
        }

        private void TestRedactor_Shown(object sender, EventArgs e)
        {
            if (Tag == "Load")
            {
                LoadTest();
            }
        }

        private void LoadTest()
        {
            // Прочитати з файлу
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        // Запис даних
                        testInfo = JsonConvert.DeserializeObject<TestInfo>(fileContent);
                        // Показ зчитаної інформації про тест
                        textBox_TestName.Text = testInfo.testName;
                        textBox_GivenQuestionAmount.Text = $"{testInfo.givenQuestionAmount}";
                        textBox_Password.Text = testInfo.password;
                        checkBox_ScrumbledQuestions.Checked = testInfo.scrumbledQuestion;
                        checkBox_ScrumbledVariants.Checked = testInfo.scrumbledVariants;
                        foreach (var item in testInfo.questions)
                        {
                            createQuestion();
                            TextBox question = (TextBox)testReferences.questions.Last().question;
                            question.Text = item.question;
                            for (int i = 0; i < item.variants.Count(); i++)
                            {
                                TextBox text = (TextBox)testReferences.questions.Last().variants.ElementAt(i).text;
                                text.Text = item.variants.ElementAt(i).text;
                                RadioButton state = (RadioButton)testReferences.questions.Last().variants.ElementAt(i).state;
                                state.Checked = item.variants.ElementAt(i).state;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createQuestion();
            label3.Text = $"{questionAmount}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int id = (int)b.Tag;
            GroupBox toDelete = (GroupBox)testReferences.questions.ElementAt(id).groupBox;
            this.Controls.Remove(toDelete);
            MoveQuestions(toDelete.Size.Height+20, id + 1);
            PushIndexes(id + 1);
            testReferences.questions.RemoveAt(id);
            questionAmount--;
            label3.Text = $"{questionAmount}";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            testInfo = new TestInfo(textBox_TestName.Text, textBox_Password.Text, Int32.Parse(textBox_GivenQuestionAmount.Text), checkBox_ScrumbledQuestions.Checked, checkBox_ScrumbledVariants.Checked);
            foreach (var item in testReferences.questions)
            {
                TextBox question = (TextBox)item.question;
                List<VariantInfo> variants = new List<VariantInfo>();
                foreach (var variant in item.variants)
                {
                    RadioButton state = (RadioButton)variant.state;
                    TextBox text = (TextBox)variant.text;
                    variants.Add(new VariantInfo(state.Checked, text.Text));
                }
                testInfo.AddNewQuestion(new QuestionInfo(question.Text, variants));
            }
            // Запис у файл
            string strJson = JsonConvert.SerializeObject(testInfo);
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, strJson);
                }
            }
        }

        private void MoveQuestions(int amount, int startPos)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y - amount);
            for (int i = startPos; i<testReferences.questions.Count; i++)
            {
                GroupBox group = (GroupBox)testReferences.questions.ElementAt(i).groupBox;
                group.Location = new Point(group.Location.X, group.Location.Y - amount);
            }
        }

        private void PushIndexes(int startPos)
        {
            for (int i = startPos; i < testReferences.questions.Count; i++)
            {
                GroupBox group = (GroupBox)testReferences.questions.ElementAt(i).groupBox;
                Button button = (Button)testReferences.questions.ElementAt(i).buttonDelete;
                group.Text = $"Питання {i}";
                button.Tag = (int)button.Tag - 1;
            }
        }

        private void createQuestion()
        {
            // Номер питання
            questionAmount++;
            // Текст
            Label labelQuestion = new Label
            {
                AutoSize = true,
                Location = new Point(23, 31),
                Name = "labelQuestion",
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
            RadioButton radioButtonV1 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 68),
                Name = "radioButtonV1",
                Size = new Size(17, 16),
                TabIndex = 0,
                TabStop = true,
                UseVisualStyleBackColor = true
            };
            RadioButton radioButtonV2 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 95),
                Name = "radioButtonV2",
                Size = new Size(17, 16),
                TabIndex = 1,
                TabStop = true,
                UseVisualStyleBackColor = true
            };
            RadioButton radioButtonV3 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 122),
                Name = "radioButtonV3",
                Size = new Size(17, 16),
                TabIndex = 2,
                TabStop = true,
                UseVisualStyleBackColor = true
            };
            RadioButton radioButtonV4 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 149),
                Name = "radioButtonV4",
                Size = new Size(17, 16),
                TabIndex = 3,
                TabStop = true,
                UseVisualStyleBackColor = true
            };
            // Текст варіантів
            TextBox textBoxV1 = new TextBox
            {
                Location = new Point(51, 65),
                Name = "textBoxV1",
                Size = new Size(550, 22),
                TabIndex = 15
            };
            TextBox textBoxV2 = new TextBox
            {
                Location = new Point(51, 92),
                Name = "textBoxV2",
                Size = new Size(550, 22),
                TabIndex = 16
            };
            TextBox textBoxV3 = new TextBox
            {
                Location = new Point(51, 119),
                Name = "textBoxV3",
                Size = new Size(550, 22),
                TabIndex = 17
            };
            TextBox textBoxV4 = new TextBox
            {
                Location = new Point(50, 146),
                Name = "textBoxV4",
                Size = new Size(550, 22),
                TabIndex = 18
            };
            // Кнопка видалення
            Button buttonDelete = new Button
            {
                Location = new Point(620, 70),
                Name = "buttonDelete",
                Size = new Size(160, 30),
                TabIndex = 15,
                Text = "Видалити питання",
                UseVisualStyleBackColor = true,
                Tag = questionAmount - 1
            };
            buttonDelete.Click += new EventHandler(buttonDelete_Click);
            // Коробка
            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(buttonDelete);
            groupBox.Controls.Add(textBoxQuestion);
            groupBox.Controls.Add(labelQuestion);
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
            testReferences.AddNewQuestion(
                new RedactorQuestion(groupBox, labelQuestion, textBoxQuestion, buttonDelete,
                                    new RedactorVariant(radioButtonV1, textBoxV1),
                                    new RedactorVariant(radioButtonV2, textBoxV2),
                                    new RedactorVariant(radioButtonV3, textBoxV3),
                                    new RedactorVariant(radioButtonV4, textBoxV4)));
            // Посунути кнопку
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 200);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Tag = "Back";
            this.Close();
        }
    }
}
