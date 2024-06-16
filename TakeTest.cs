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
    public partial class TakeTest : Form
    {
        Random r = new Random();
        TestInfo testInfo;
        List<QuestionInfo> givenQuestions = new List<QuestionInfo>();
        List<TakeTestQuestionReferences> questionReferences = new List<TakeTestQuestionReferences>();
        int currentQuestion = 0;

        public TakeTest()
        {
            InitializeComponent();
        }

        private void TakeTest_Shown(object sender, EventArgs e)
        {
            LoadTest();
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

                // Перевірка чи був обраний файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        // Перевірка на правильність файлу
                        try
                        {
                            // Запис даних
                            testInfo = JsonConvert.DeserializeObject<TestInfo>(fileContent);
                        }
                        catch 
                        {
                            if (MessageBox.Show("Сталась помилка при спробі зчитування файлу. Спробувати ще раз?", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                LoadTest();
                                return;
                            }
                            else
                            {
                                button_Back.PerformClick();
                                return;
                            }
                        }
                        
                        // Створення тесту
                        // Кількість питань
                        int givenQuestionAmount;
                        if (testInfo.givenQuestionAmount == 0 || 
                            testInfo.givenQuestionAmount > testInfo.questions.Count())
                        { 
                            givenQuestionAmount = testInfo.questions.Count(); 
                        }
                        else 
                        { 
                            givenQuestionAmount = testInfo.givenQuestionAmount; 
                        }
                        // Запис питань у список
                        for (int i = 0; i < givenQuestionAmount; i++)
                        {
                            givenQuestions.Add(testInfo.questions.ElementAt(i));
                            // Перемішення варіантів
                            if (testInfo.scrumbledVariants)
                            {
                                ExtensionClass.Shuffle(givenQuestions.ElementAt(i).variants);
                            }
                        }
                        // Перемішення питань
                        if (testInfo.scrumbledQuestion)
                        {
                            ExtensionClass.Shuffle(givenQuestions);
                        }
                        // Створення інтерфейсу питань
                        for (int i = 0; i < givenQuestions.Count(); i++)
                        {
                            CreateTestPage(i);
                        }
                    }
                }
                else
                {
                    button_Back.PerformClick();
                }
            }
        }

        private void CreateTestPage(int id)
        {
            // Питання
            Label labelQuestion = new Label
            {
                AutoSize = true,
                Location = new Point(23, 31),
                Name = "labelQuestion",
                Size = new Size(69, 17),
                TabIndex = 19,
                Text = givenQuestions.ElementAt(id).question
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
                UseVisualStyleBackColor = true,
                Text = givenQuestions.ElementAt(id).variants.ElementAt(0).text
            };
            RadioButton radioButtonV2 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 95),
                Name = "radioButtonV2",
                Size = new Size(17, 16),
                TabIndex = 1,
                TabStop = true,
                UseVisualStyleBackColor = true,
                Text = givenQuestions.ElementAt(id).variants.ElementAt(1).text
            };
            RadioButton radioButtonV3 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 122),
                Name = "radioButtonV3",
                Size = new Size(17, 16),
                TabIndex = 2,
                TabStop = true,
                UseVisualStyleBackColor = true,
                Text = givenQuestions.ElementAt(id).variants.ElementAt(2).text
            };
            RadioButton radioButtonV4 = new RadioButton
            {
                AutoSize = true,
                Location = new Point(27, 149),
                Name = "radioButtonV4",
                Size = new Size(17, 16),
                TabIndex = 3,
                TabStop = true,
                UseVisualStyleBackColor = true,
                Text = givenQuestions.ElementAt(id).variants.ElementAt(3).text
            };
            // Коробка
            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(labelQuestion);
            groupBox.Controls.Add(radioButtonV4);
            groupBox.Controls.Add(radioButtonV3);
            groupBox.Controls.Add(radioButtonV2);
            groupBox.Controls.Add(radioButtonV1);
            groupBox.Location = new Point(48, 112);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1000, 370);
            groupBox.TabIndex = 10;
            groupBox.TabStop = false;
            groupBox.Text = $"Питання #{id + 1}";
            groupBox.Hide();
            // Виведення
            this.Controls.Add(groupBox);
            // Збереження
            RadioButton[] variants = { radioButtonV4, radioButtonV3, radioButtonV2, radioButtonV1 };
            questionReferences.Add(new TakeTestQuestionReferences(groupBox, variants));
            
        }

        private void button_StartTest_Click(object sender, EventArgs e)
        {
            label_TestName.Hide();
            label_QuestionAmount.Hide();
            button_StartTest.Hide();
            GroupBox question = (GroupBox)questionReferences.ElementAt(currentQuestion).groupBox;
            question.Show();
            button_Next.Show();
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            GroupBox question = (GroupBox)questionReferences.ElementAt(currentQuestion).groupBox;
            question.Hide();
            currentQuestion--;
            GroupBox newQuestion = (GroupBox)questionReferences.ElementAt(currentQuestion).groupBox;
            newQuestion.Show();
            if (currentQuestion == 0)
            {
                button_Previous.Hide();
            }
            button_Next.Show();
            button_EndTest.Hide();

        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            GroupBox question = (GroupBox)questionReferences.ElementAt(currentQuestion).groupBox;
            question.Hide();
            currentQuestion++;
            GroupBox newQuestion = (GroupBox)questionReferences.ElementAt(currentQuestion).groupBox;
            newQuestion.Show();
            button_Previous.Show();
            if (currentQuestion == givenQuestions.Count - 1)
            {
                button_Next.Hide();
                button_EndTest.Show();
            }
        }

        private void button_EndTest_Click(object sender, EventArgs e)
        {
            // Кількість правильних відповідей
            int rightAnswerAmount = 0;
            // Перевірка відповідей
            for (int i = 0; i < givenQuestions.Count(); i++)
            {
                int variantsCount = givenQuestions.ElementAt(i).variants.Count();
                for (int j = 0; j < variantsCount; j++) 
                {
                    if (givenQuestions.ElementAt(i).variants.ElementAt(j).state)
                    {
                        RadioButton rButton = (RadioButton)questionReferences.ElementAt(i).variants.ElementAt(j);
                        if (rButton.Checked)
                        {
                            rightAnswerAmount++;
                        }
                    }
                }
            }
            // Вивід результатів
            GroupBox question = (GroupBox)questionReferences.ElementAt(currentQuestion).groupBox;
            question.Hide();
            button_Previous.Hide();
            button_Next.Hide();
            button_EndTest.Hide();
            label_Result.Text = $"Результат: {rightAnswerAmount}/{givenQuestions.Count()}";
            label_Result.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Tag = "Back";
            this.Close();
        }
    }
    public static class ExtensionClass
    {
        private static System.Random rng = new System.Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
