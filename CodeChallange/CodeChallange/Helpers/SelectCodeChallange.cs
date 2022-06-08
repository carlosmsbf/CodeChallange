using CodeChallange.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Helpers
{
   public class SelectCodeChallange
    {

        public static void Menu(int input, bool isEnd)
        {
            switch (input)
            {

                // 1. Multiples of 3 or 5.
                case 1:
                    OneToTen.FirstCase();
                    break;

                //2.Return the number(count) of vowels in the given string.

                case 2:
                    OneToTen.SecondCase();

                    break;

                //3.Returning a string without vowel.
                case 3:
                    OneToTen.ThirdCase();

                    break;
                // 4.Create Phone Number"
                case 4:
                    OneToTen.FourthCase();

                    break;

                //5.Square Every Digit
                case 5:
                    OneToTen.Fifith();
                    break;
                //6.Find the odd int
                case 6:
                    OneToTen.Sixth();
                    break;

                //7.Stop gninnipS My sdroW!
                case 7:
                    OneToTen.Seventh();
                    break;

                //8. Find the smallest integer in the array
                case 8:
                    OneToTen.Eighth();
                    break;
                //9. Given an array of integers, return a new array with each value doubled.
                case 9:
                    OneToTen.Nineth();
                    break;

                //10. Replace every letter with its position in the alphabet.
                case 10:
                    OneToTen.Tenth();
                    break;

                //11. Takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
                case 11:
                    ElevenToTwenty.Eleventh();
                    break;
                //12. Takes a non-negative integer (seconds) formats a duration, given as a number of seconds, in a human-friendly way.
                case 12:
                    ElevenToTwenty.Twelveth();
                    break;
                //99.End of Program
                case 99:

                    isEnd = true;
                    break;
                default:

                    Console.WriteLine("\n Please, select again.");
                    break;
            }
        }
    }
}
