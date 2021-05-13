using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzer
{
    class FillInMultipleBlanks : IQuestion
    {
        public string Question { get; set; }
        public string BlankAnswer1 { get; set; }
        public string BlankAnswer2 { get; set; }

        public bool AskQuestion()
        {
            DisplayQuestion();
            string placeholderguess1 = Console.ReadLine();
            string guess1 = placeholderguess1.ToUpper();
            string placeholderguess2 = Console.ReadLine();
            string guess2 = placeholderguess2.ToUpper();
            if (guess1 == BlankAnswer1 & guess2 == BlankAnswer2)
            {
                Console.WriteLine("You got this one right I suppose");
                return true;
            }
            else if (guess1 == BlankAnswer1 & guess2 != BlankAnswer2)
            {
                Console.WriteLine("You missed one. So suck it loser");
                return false;
            }
            else if (guess1 != BlankAnswer1 & guess2 == BlankAnswer2)
            {
                Console.WriteLine("Missed one! Jerkbag");
                return false;
            }
            else
            {
                Console.WriteLine("You missed them both you dolt");
                return false;
            }
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Question);
        }
    }
}
