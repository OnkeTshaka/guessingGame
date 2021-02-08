using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = 1;
            int guess = 0;
            int guestCount = 0;
            int guestLimit = 3;
            bool outOfGuesses = false;
            while(secret != guess && !outOfGuesses)
            {
                if(guestCount < guestLimit)
                {
                    Console.Write("Enter a number between 1-10: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guestCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
              
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
                Console.ReadLine();
            }
            else
            {
                Console.Write("You Win!");
                Console.ReadLine();
            }

        }
    }
}
