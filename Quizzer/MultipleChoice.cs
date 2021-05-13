using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzer
{
    class MultipleChoice : IQuestion
    {
        public string Question { get; set; }
        public List<string> Options = new List<string>();
        public int CorrectAnswer { get; set; }

        public bool AskQuestion()
        {
            DisplayQuestion();
            for (int i =0; i<Options.Count;i++)
            {
                Console.WriteLine(i + " " + Options[i]);
            }
            int guess = Convert.ToInt32(Console.ReadLine());
            if(guess== CorrectAnswer)
            {
                Console.WriteLine("You got it man!");
                return true;
            }
            else
            {
                Console.WriteLine("You suck and are bad at this");
                return false;
            }
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Question);
        }
    }
}
