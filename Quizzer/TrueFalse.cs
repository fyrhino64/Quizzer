using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzer
{
    class TrueFalse : IQuestion
    {
        public string Question { get; set; }
        public List<string> TrueOrFalse = new List<string>();

        public int CorrectAnswer { get; set; }

        public bool AskQuestion()
        {
            DisplayQuestion();
            for (int i =0; i<TrueOrFalse.Count; i++)
            {
                Console.WriteLine(i + "" + TrueOrFalse[i]);
            }
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == CorrectAnswer)
            {
                Console.WriteLine("Woo! You are not dumb!");
                return true;
            }
            else
            {
                Console.WriteLine("You are the big dumb. F--");
                return false;
            }
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Question);
        }
    }
}
