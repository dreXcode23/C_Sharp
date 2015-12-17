using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class FortuneTeller
    {
        private static void FortuneStory(string foresight1, string foresight2)
        {
            WriteLine("Come and let me read your fortune!\n");
            WriteLine("{0}", foresight1);
            WriteLine("{0}", foresight2);
        }
        static void Main(string[] args)
        {
            string[] fortunes = {"You will gain a companion in the near future...", "Your time will be cut short by a crazy phenomenon...",
                                 "I see fame and glory in your future...", "I see birds flying, bells ringing, and hands clapping in the background...",
                                 "Beware of the beast that lurks in the shadows...", "Your dreams will be fulfilled in the later future..."};
            Random ranNumberGenerator = new Random();
            int min = 0, max = 6;
            int randomNumber1 = ranNumberGenerator.Next(min, max);
            int randomNumber2 = ranNumberGenerator.Next(min, max);
            while (fortunes[randomNumber1].Equals(fortunes[randomNumber2]))
            {
                randomNumber2 = ranNumberGenerator.Next(min, max);
            }
            FortuneStory(fortunes[randomNumber1], fortunes[randomNumber2]);
        }
    }
}
