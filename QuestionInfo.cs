using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_TestClass
{
    class QuestionInfo
    {
        public string question;
        public List<VariantInfo> variants;

        public QuestionInfo(string question_, List<VariantInfo> variants_)
        {
            question = question_;
            variants = variants_;
        }
    }
}
