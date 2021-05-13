using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzer
{
    interface IQuestion
    {
        string Question { get; set; }

        public void DisplayQuestion();
        public bool AskQuestion();
    }
}
