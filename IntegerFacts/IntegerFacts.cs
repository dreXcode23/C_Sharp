using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class IntegerFacts
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[20];
            int high, low, total;
            double avg;
            DisplayArray(arrayInt);
            DisplayArrayValues(out high, out low, out total, out avg, arrayInt);
            WriteLine("\nHighest: {0}", high);
            WriteLine("Lowest: {0}", low);
            WriteLine("Total: {0}", total);
            WriteLine("Average: {0}", avg);
        }
        private static void DisplayArray(params int[] numbers)
        {
            string userInput;
            int numInput = 0;
            int score;
            int index = 0;
            WriteLine("Type -999 to quit\n");
            while (numInput != -999 && index < 20)
            {
                Write("Enter a number for position {0}: ", index + 1);
                userInput = ReadLine();
                while (!int.TryParse(userInput, out score))
                {
                    WriteLine("Invalid input! Please type in an integer.\n");
                    Write("Enter a number: ");
                    userInput = ReadLine();
                }
                numInput = int.Parse(userInput);
                if (numInput != -999)
                {
                    numbers[index] = numInput;
                    ++index;
                }
            }
        }

        private static void DisplayArrayValues(out int big, out int lil, out int sum, out double mid, params int[] numbers)
        {
            int counter;
            int counter1 = 0;
            sum = 0;
            Array.Sort(numbers);
            big = numbers[numbers.Length - 1];

            for (counter = 0; counter < numbers.Length; ++counter)
            {
                if (numbers[counter] == 0)
                {
                    ++counter1;
                }
                else
                {
                    sum += numbers[counter];
                }
            }
            mid = sum / (double)(counter - counter1);
            lil = numbers[counter1];
        }
    }
}
