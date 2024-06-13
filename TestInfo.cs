using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_TestClass
{
    class TestInfo
    {
        public string testName;
        public string password;
        public int givenQuestionAmount;
        public bool scrumbledQuestion;
        public bool scrumbledVariants;
        public List<QuestionInfo> questions = new List<QuestionInfo>();

        public TestInfo(string testName_, string password_, int givenQuestionAmount_, bool scrumbledQuestion_, bool scrumbledVariants_)
        {
            testName = testName_;
            password = password_;
            givenQuestionAmount = givenQuestionAmount_;
            scrumbledQuestion = scrumbledQuestion_;
            scrumbledVariants = scrumbledVariants_;
        }

        public void AddNewQuestion(QuestionInfo question)
        {
            questions.Add(question);
        }
    }
}
