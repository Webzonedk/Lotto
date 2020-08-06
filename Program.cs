using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                int[] lottonumbers = new int[7];
                int[] userCoupon = new int[7];
                int[] winnerNumbersAmount = new int[1];
                int[] winnerPrice = new int[1];

                Console.WriteLine("Welcome to the Lotto lottery");

                Console.WriteLine("Choose your 7 numbers between 1 and 20");




                Methods.UserCoupon(userCoupon);

                Methods.RandomLottoNumbersGenerator(lottonumbers);

                Methods.CompareNumbers(winnerNumbersAmount, lottonumbers, userCoupon);

                Methods.CalculatePrice(winnerNumbersAmount, winnerPrice);




                Console.WriteLine("This weeks lottonumbers");
                for (int i = 0; i < lottonumbers.Length; i++)
                {
                    Console.Write($"{lottonumbers[i],4}");
                }
                Console.WriteLine("\n");




                Console.WriteLine("You have chosen the following 7 numbers.");
                for (int i = 0; i < userCoupon.Length; i++)
                {
                    Console.Write($"{userCoupon[i],4}");
                }
                Console.WriteLine("\n");




                if (winnerNumbersAmount[0] < 1)
                {
                    Console.WriteLine($"You have {winnerNumbersAmount[0]} numbers correct. You might be the most unlucky person in the world.");
                }
                else if (winnerNumbersAmount[0] == 1)
                {
                    Console.WriteLine($"You have {winnerNumbersAmount[0]} number correct. Unfortunately that is not enough to win the lottery.");
                }
                else if (winnerNumbersAmount[0] > 1)
                {
                    Console.WriteLine($"Congratulation. You have {winnerNumbersAmount[0]} numbers correct at your lotto coupon. You have won {winnerPrice[0]} $ in the lotto lottery");
                }




                Console.WriteLine("Try again press 1 | end game: pres anything else");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        break;
                    default:
                        run = false;
                        break;
                }
            }
        }
    }
}
