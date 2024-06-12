using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_TestClass
{
    public class RedactorVariant
    {
        public object state;
        public object text;

        public RedactorVariant(object state_, object text_)
        {
            state = state_;
            text = text_;
        }
    }
}
