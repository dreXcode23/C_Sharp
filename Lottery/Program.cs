using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();      //Create an instance of a Random class
            int rndNum1, rndNum2, rndNum3;
            const int NO_MATCHES = 0;
            const int ONE_MATCH = 10;
            const int TWO_MATCHES = 100;
            const int THREE_MATCHES_OUT_ORDER = 1000;
            const int THREE_MATCHES_IN_ORDER = 10000;
            string userInput1, userInput2, userInput3;
            int digit1, digit2, digit3, matches;

            rndNum1 = rnd.Next(1, 5);       // the first number will pick between 1-4
            rndNum2 = rnd.Next(1, 5);       // the second number will pick between 1-4
            rndNum3 = rnd.Next(1, 5);       // the third number will pick between 1-4

            WriteLine("Lottery Game: Pick numbers between 1-4");
            Write("Enter your first number: ");
            userInput1 = ReadLine();
            digit1 = Convert.ToInt32(userInput1);
            Write("Enter your second number: ");
            userInput2 = ReadLine();
            digit2 = Convert.ToInt32(userInput2);
            Write("Enter your third number: ");
            userInput3 = ReadLine();
            digit3 = Convert.ToInt32(userInput3);

            WriteLine("\nYour numbers: {0}-{1}-{2} / Lotto numbers: {3}-{4}-{5}", digit1, digit2, digit3, rndNum1, rndNum2, rndNum3);

            matches = 0;                    // the user hasn't match with any number. so the value is left 0

            /*   if (digit1 == rndNum1 || digit1 == rndNum2 || digit1 == rndNum3)    // This will indicate if the first input matches with any of the 3 digits
                 { matches += 1; }
                 if (digit2 == rndNum1 || digit2 == rndNum2 || digit2 == rndNum3)    // This will indicate if the second input matches with any of the 3 digits
                 { matches += 1; }
                 if (digit3 == rndNum1 || digit3 == rndNum2 || digit3 == rndNum3)    // This will indicate if the third input matches with any of the 3 digits
                 { matches += 1; }
                 if (digit1 == rndNum1 && digit2 == rndNum2 && digit3 == rndNum3)    // This will indicate if all 3 digits match sequentially
                 { matches = 4; } */

            if (digit1 == rndNum1 && digit2 == rndNum2 && digit3 == rndNum3)
            { matches = 4; }
            else
            {

                // FIRST MATCH
                if (digit1 == rndNum1)
                {
                    rndNum1 = 0;    // Changing the first random number to 0 will stop the user's secondary & tertiary number to match the first lotto number.
                    ++matches;
                }
                else if (digit1 == rndNum2)
                {
                    rndNum2 = 0;    // Changing the second random number to 0 will stop the user's secondary & tertiary number to match the second lotto number.
                    ++matches;
                }
                else if (digit1 == rndNum3)
                {
                    rndNum3 = 0;    // Changing the third random number to 0 will stop the user's secondary & tertiary number to match the third lotto number.
                    ++matches;
                }

                // SECOND MATCH
                if (digit2 == rndNum1)
                {
                    rndNum1 = 0;    // Changing the first random number to 0 so the user's tertiary number won't match the first lotto number.
                    ++matches;
                }
                else if (digit2 == rndNum2)
                {
                    rndNum2 = 0;    // Changing the second random number to 0 so the user's tertiary number won't match the second lotto number.
                    ++matches;
                }
                else if (digit2 == rndNum3)
                {
                    rndNum3 = 0;    // Changing the third random number to 0 so the user's tertiary number won't match the third lotto number.
                    ++matches;
                }

                // THIRD MATCH
                if (digit3 == rndNum1)
                {
                    rndNum1 = 0;    // Changing the first random number to 0 will stop the user's secondary & tertiary number to match the first lotto number.
                    ++matches;
                }
                else if (digit3 == rndNum2)
                {
                    rndNum2 = 0;
                    ++matches;
                }
                else if (digit3 == rndNum3)
                {
                    rndNum3 = 0;
                    ++matches;
                }

            }

            switch (matches)
            {
                case 1:
                    WriteLine("\nCongratulations! You've won {0:c}.", ONE_MATCH);
                    break;

                case 2:
                    WriteLine("\nCongratulations! You've won {0:c}.", TWO_MATCHES);
                    break;

                case 3:
                    WriteLine("\nCongratulations! You've won {0:c}.", THREE_MATCHES_OUT_ORDER);
                    break;

                case 4:
                    WriteLine("\nJackpot!!! You've won {0:c}.", THREE_MATCHES_IN_ORDER);
                    break;

                default:
                    WriteLine("\nBetter Luck Next Time... You've won {0:c}.",NO_MATCHES);
                    break;
            }


        }
    }
}
