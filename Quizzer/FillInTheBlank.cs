using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzer
{
    class FillInTheBlank : IQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public bool AskQuestion()
        {
            DisplayQuestion();
            string placeholderguess = Console.ReadLine();
            string guess = placeholderguess.ToUpper();
            if (guess == Answer)
            {
                Console.WriteLine("Your answer is correct");
                return true;
            }
            else
            {
                Console.WriteLine("Your answer is wrong, you suck");
                return false;
            }

        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Question);
        }
    }
}
