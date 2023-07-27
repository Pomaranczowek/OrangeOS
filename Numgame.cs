using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realos
{
    internal class Numgame
    {
        public static void launch()
        {
            Console.Clear();
            Console.WriteLine("Funny Number Game");
            Console.WriteLine("Made by Blizzardfur-Maxxx, ported by Pomaranczowek");
            Console.WriteLine("(in fact this is a worse version of it)");
            Random random = new Random();
            int number = random.Next(1, 10);
            if (number >= 5 || number == 5)
            {
                Console.WriteLine("Guess the number (hint: it is 5 or above 5): ");
                var numguess = Console.ReadLine();
                int guess;
                if (int.TryParse(numguess, out guess))
                    if (guess == number)
                    {
                        Console.WriteLine("Congratulations! You Win!");
                    }
                    else if (guess != number)
                    {
                        Console.WriteLine("You lose... Better luck next time ;)");
                    }
            }
            if (number <= 5)
            {
                Console.WriteLine("Guess the number (hint: it is below 5): ");
                var numguess = Console.ReadLine();
                int guess;
                if (int.TryParse(numguess, out guess))
                    if (guess == number)
                    {
                        Console.WriteLine("Congratulations! You Win!");
                    } 
                    else if (guess != number)
                    {
                        Console.WriteLine("You lose... Better luck next time ;)");
                    }
            }
        }
    }
}
