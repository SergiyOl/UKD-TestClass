using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_TestClass
{
    public class RedactorTestReferences
    {
        public List<RedactorQuestion> questions = new List<RedactorQuestion>();

        public void AddNewQuestion(RedactorQuestion item)
        {
            questions.Add(item);
        }
    }
}
