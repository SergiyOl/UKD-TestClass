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
                        // Створення тесту
                        // Кількість питань
                        int givenQuestionAmount;
                        if (testInfo.givenQuestionAmount == 0)
                        { givenQuestionAmount = testInfo.questions.Count(); }
                        else 
                        { givenQuestionAmount = testInfo.givenQuestionAmount; }
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
                        // Показ зчитаної інформації про тест
                        string strJson = JsonConvert.SerializeObject(givenQuestions);
                        label1.Text = strJson;
                        /*textBox_TestName.Text = testInfo.testName;
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
                        }*/
                    }
                }
            }
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
