﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWUH14.Domain.Entities
{
    public class Answer
    {
        public string Text { get; }

        public Answer(string text)
        {
            Text = text;
        }
    }
}
