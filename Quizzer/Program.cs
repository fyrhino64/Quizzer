using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzer
{
    class Program
    {
        static void Main()
        {
            FillInTheBlank Question1 = new FillInTheBlank();
            Question1.Question = "Who is Buddy's best friend?";
            Question1.Answer = "Rebekah";

            MultipleChoice Question2 = new MultipleChoice();
            Question2.Question = "What is Rachel's Middle Name?";
            Question2.Options.Add("Jimothy");
            Question2.Options.Add("Timothy");
            Question2.Options.Add("Jane");
            Question2.Options.Add("Wil Sha");
            Question2.CorrectAnswer = 3;

            TrueFalse Question3 = new TrueFalse();
            Question3.Question = "Travis is a stinky face man";
            Question3.TrueOrFalse.Add("True");
            Question3.TrueOrFalse.Add("False");
            Question3.CorrectAnswer = 0;

            FillInMultipleBlanks Question4 = new FillInMultipleBlanks();
            Question4.Question = "___ and ___ are the best dogs in the world";
            Question4.BlankAnswer1 = "DAISY";
            Question4.BlankAnswer2 = "BUDDY";

            int score = 0;

            if (Question1.AskQuestion() == true)
            {
                score++;
            }
            Console.WriteLine("Your score is now " + score);
            if (Question2.AskQuestion() == true)
            {
                score++;
            }
            Console.WriteLine("Your score is now " + score);
            if (Question3.AskQuestion() == true)
            {
                score++;
            }
            Console.WriteLine("Your score is now " + score);
            if (Question4.AskQuestion() == true)
            {
                score++;
            }
            Console.WriteLine("Your score is now " + score);
        }
    }
}
