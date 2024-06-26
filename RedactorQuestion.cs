﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_TestClass
{
    public class RedactorQuestion
    {
        public object groupBox;
        public object lable;
        public object question;
        public object buttonDelete;
        public RedactorVariant[] variants;

        public RedactorQuestion(object groupBox_, object lable_, object question_, object buttonDelete_, params RedactorVariant[] variants_)
        {
            groupBox = groupBox_;
            lable = lable_;
            question = question_;
            buttonDelete = buttonDelete_;
            variants = variants_;
        }
    }
}
