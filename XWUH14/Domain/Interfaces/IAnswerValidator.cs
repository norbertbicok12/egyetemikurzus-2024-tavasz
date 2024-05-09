﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XWUH14.Domain.Entities;

namespace XWUH14.Domain.Interfaces
{
    public interface IAnswerValidator
    {
        bool ValidateAnswer(Question question, Answer answer);
    }
}
