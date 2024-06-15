using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_TestClass
{
    class TakeTestQuestionReferences
    {
        public object groupBox;
        /*public object question;*/
        public object[] variants;

        public TakeTestQuestionReferences(object groupBox_, /*object question_,*/ object[] variants_)
        {
            groupBox = groupBox_;
            /*question = question_;*/
            variants = variants_;
        }
    }
}
