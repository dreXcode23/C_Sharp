using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, userResponse;     // These string variables will store the user's input
            double testScore = 0, total = 0,
                    average, tests = 0;
            char response = ' ';

            while (response != 'N' && response != 'n')
            {
                Write("Enter test score: ");
                userInput = ReadLine();
                testScore = Convert.ToDouble(userInput);
                if (testScore >= 0 && testScore <= 100)
                {
                    total += testScore;
                    ++tests;
                    WriteLine("Do you wish to continue? Y or N");
                    userResponse = ReadLine();
                    response = Convert.ToChar(userResponse);
                }
                else
                {
                    WriteLine("Please enter a valid test score!");
                }
            }

            average = total / tests;
            WriteLine("\nYou've entered {0} test scores. \nYour test average is {1:f2}", tests, average);
            
        }
    }
}
