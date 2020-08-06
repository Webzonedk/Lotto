using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Methods
    {
        /// <summary>
        /// Generates the random lotto winner numbers, and ensures that the numbers are only picked once
        /// </summary>
        /// <param name="newLottonumbers"></param>
        /// <returns></returns>
        public static int[] RandomLottoNumbersGenerator(int[] newLottonumbers)
        {
            Random random = new Random();

            for (int i = 0; i < newLottonumbers.Length; i++)
            {
                int randomNumber = random.Next(1, 21);

                for (int j = 0; j < newLottonumbers.Length; j++)
                {
                    if (randomNumber == newLottonumbers[j])
                    {
                        i--;
                        j = 7;
                    }
                    else if (randomNumber != newLottonumbers[j] && j == 6)
                    {
                        newLottonumbers[i] = randomNumber;

                    }

                }
            }
            return newLottonumbers;
        }




        /// <summary>
        /// Creating User coupon from numbers chosen by the user
        /// and compares them with every time the number is chosen to ensure that it is a number
        /// and it is within the range, and it is not already used
        /// </summary>
        /// <param name="userCoupon"></param>
        /// <returns></returns>
        public static int[] UserCoupon(int[] userCoupon)
        {
            for (int i = 0; i < userCoupon.Length; i++)
            {
                try
                {
                    int tempNumber = int.Parse(Console.ReadLine());
                    for (int j = 0; j < userCoupon.Length; j++)
                    {
                        if (tempNumber == userCoupon[j])
                        {
                            i--;
                            j = 7;
                            Console.WriteLine("You cant choose the same number twice");
                        }
                        else if (tempNumber < 1 || tempNumber > 20)
                        {
                            Console.WriteLine("You need to choose numbers between 1 and 20");
                            i--;
                            j = 7;
                        }
                        else if (tempNumber != userCoupon[j] && tempNumber >= 1 && tempNumber <= 20 && j == 6)
                        {
                            userCoupon[i] = tempNumber;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You need to pick a number needs to be between 1 and 20");
                    i--;
                }
            }
            return userCoupon;
        }




        /// <summary>
        /// Compares the picked numbers by the user, with the weeks picked numbers by the random generator, '
        /// to see if the user is a winner.
        /// </summary>
        /// <param name="lottoNumbers"></param>
        /// <param name="userNumbers"></param>
        /// <returns></returns>
        public static int[] CompareNumbers(int[] winnerNumbersAmount, int[] lottoNumbers, int[] userNumbers)
        {
           int tempWinnerAmount = 0;
            for (int i = 0; i < userNumbers.Length; i++)
            {
                for (int j = 0; j < userNumbers.Length; j++)
                {
                    if (userNumbers[i] == lottoNumbers[j])
                    {
                        tempWinnerAmount++;
                        winnerNumbersAmount[0]= tempWinnerAmount;
                        j = userNumbers.Length;
                    }
                }
            }
          return winnerNumbersAmount;
        }




        /// <summary>
        /// Calculating the winning price, based on amount of correct numbers
        /// </summary>
        /// <param name="winnerNumbersAmount"></param>
        /// <param name="winnerPrice"></param>
        /// <returns></returns>
        public static int[] CalculatePrice(int[] winnerNumbersAmount, int[] winnerPrice)
        {
            switch (winnerNumbersAmount[0])
            {
                case 0:
                    winnerPrice[0] = 0;
                    break;
                case 1:
                    winnerPrice[0] = 0;
                    break;
                case 2:
                    winnerPrice[0] = 42;
                    break;
                case 3:
                    winnerPrice[0] = 219;
                    break;
                case 4:
                    winnerPrice[0] = 2195;
                    break;
                case 5:
                    winnerPrice[0] = 46325;
                    break;
                case 6:
                    winnerPrice[0] = 159357;
                    break;
                case 7:
                    winnerPrice[0] = 120963254;
                    break;
            }
            return winnerPrice;
        }
    }
}


