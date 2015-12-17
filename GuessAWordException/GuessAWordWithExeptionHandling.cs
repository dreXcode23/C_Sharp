using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class GuessAWordWithExeptionHandling
    {
        static void Main(string[] args)
        {
            string[] words = {"apricot", "elephant", "tigress",
                              "fortunate", "impossible", "historical",
                              "colorful", "science"};
            Random RandomClass = new Random();
            int randomNumber;
            randomNumber = RandomClass.Next(0, words.Length);
            string selectedWord = words[randomNumber];
            string guessedWord = "";
            string originalWord = selectedWord;
            string guess;
            char letter;
            int pos;
            char tempChar;
            int foundCount = 0;
            bool letterInWord;
            for (int a = 0; a < selectedWord.Length; ++a)
                guessedWord = guessedWord + "*";
            while (foundCount < selectedWord.Length)
            {
                try
                {
                    WriteLine("Word: {0}", guessedWord);
                    Write("Guess a letter >> ");
                    guess = ReadLine().ToLower();
                    //If the user guess is not a single character or is between the characters a-z
                    //The NonLetterException obj is thrown
                    if (!char.TryParse(guess, out letter) || (letter < 'a' || letter > 'z'))
                    {
                        NonLetterException non = new NonLetterException(guess);
                        throw (non);
                    }
                    else
                        letter = Convert.ToChar(guess.Substring(0, 1));
                    letterInWord = false;
                    for (pos = 0; pos < selectedWord.Length; ++pos)
                    {
                        tempChar = Convert.ToChar(selectedWord.Substring(pos, 1));
                        if (tempChar == letter)
                        {
                            guessedWord = guessedWord.Substring(0, pos) + letter + guessedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            selectedWord = selectedWord.Substring(0, pos) + '?' + selectedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            ++foundCount;
                            letterInWord = true;
                        }

                    }
                    if (letterInWord)
                        WriteLine("Yes! {0} is in the word", letter);
                    else
                        WriteLine("Sorry. {0} is not in the word", letter);
                }
                catch (NonLetterException e)
                {
                    WriteLine(e.Message);
                }
            }
            WriteLine("Good job! Word was {0}", originalWord);
        }
    }

    class NonLetterException : Exception
    {
        //Constructors
        public NonLetterException()
        {
        }
        //Once obj has been thrown, it will pass the guess word the user inputted
        public NonLetterException(string letter) : base(ErrMsg(letter))
        {
        }

        //Instance Method
        private static string ErrMsg(string letter)
        {
            return String.Format("The character \"" + letter + "\" is not a letter!");
        }
    }
}
