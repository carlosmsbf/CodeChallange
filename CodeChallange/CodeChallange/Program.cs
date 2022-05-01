using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallange
{
    class Program
    {




        static void Main(string[] args)
        {

            int menuOption = 0;
            bool isEnd = false;
            // bool menuOption = false;



            Console.WriteLine("Code Challange");

            while (isEnd == false)
            {
                //   while (menuOption == true) { 
                Console.WriteLine("\n Select the options below to see the test the code.");
                Console.WriteLine("1.Multiples of 3 or 5.");
                Console.WriteLine("2.Return the number(count) of vowels in the given string.");
                Console.WriteLine("3.Returning a string without vowel.");
                Console.WriteLine("4.Create Phone Number");



                try
                {
                    menuOption = int.Parse(Console.ReadLine());

                }
                catch {
                    menuOption = 0;
                }

                switch (menuOption)
                {

                    // 1. Multiples of 3 or 5.
                    case 1:
                        FirstCase();
               
                        break;


                    //Return the number(count) of vowels in the given string.

                    case 2:
                        SecondCase();
   
                        break;

                    //Returning a string without vowel.
                    case 3:
                        ThirdCase();
         
                        break;

                    case 4:
                        FourthCase();

                        break;

                    case 99:

                        isEnd = true;
                        break;
                    default:

                        Console.WriteLine("\n Please, select again.");
                        break;

                }

                // };
            };



        }

        //Multiples of 3 or 5."
        private static void FirstCase()
        {
            int userInput = 0;
            bool isNumber = false;
            List<int> result = new List<int>();

            int numbers = 0;


            while (isNumber == false)
            {
                Console.WriteLine("Pick a number");
                try
                {
                    userInput = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= userInput; i++)
                        if ((i % 3 == 0) || (i % 5 == 0))
                            result.Add(i);


                    Console.WriteLine("The Numbers are:");
                    foreach (int number in result)
                    {
                        numbers += +number;
                        Console.WriteLine($"{number}");
                    }
                    isNumber = true;
                    Console.WriteLine($"The sum of numbers is:{numbers}");

                }
                catch
                {

                    isNumber = false;
                    Console.WriteLine("It has to be a numbers");
                }

            }

            


        }

        private static void SecondCase()
        {

            char[] charArray = new char[0];
            int quantity = 0;
            int letterCount = 0;


            string userInput;

            Console.WriteLine("Please, write word or a phrase.");
            userInput = Console.ReadLine();

            quantity = (userInput.ToCharArray()).Length;

            Array.Resize<char>(ref charArray, quantity);

            charArray = userInput.ToCharArray();

            foreach (char letters in charArray)
            {
                if (letters == 'a' || letters == 'e' || letters == 'i'
                       || letters == 'o' || letters == 'u' ||
                       letters == 'A' || letters == 'E' || letters == 'I'
                       || letters == 'O' || letters == 'U')
                    letterCount++;
            }

            Console.WriteLine($"{letterCount}");
        }

        //Returning a string without vowel.
        private static void ThirdCase()
        {
            char[] charArray = new char[0];
            int quantity = 0;
            string word = "";
            string pattern = @"[AEIOU-aeiou]";

            string userInput;

            Console.WriteLine("Please, write word or a phrase.");
            userInput = Console.ReadLine();



            quantity = (userInput.ToCharArray()).Length;
            Array.Resize<char>(ref charArray, quantity);

            charArray = userInput.ToCharArray();

            foreach (char letters in charArray)
            {
                string letter = letters.ToString();
                word += Regex.Replace(letter, pattern, "");
            }

            Console.WriteLine($"{word}");
        }

        //Create Phone Number
        private static void FourthCase()
        {
            char[] charArray = new char[0];
            string userInput;
            bool Has10digitis = false;
            int quantity = 0;
            string pattern = @"[a-zA-Z]";
            string phoneNumber ="";

            while (Has10digitis == false)
            {
                try
                {
                    Console.WriteLine("Please, write a phone number of 10 digits");
                    userInput =Console.ReadLine();
                    quantity = (userInput.Length);
                    if (quantity < 10)
                    {
                        Has10digitis = false;
                        Console.WriteLine("It has to be 10 digits");
                    }
                    else
                    {
                        if(Regex.IsMatch(userInput,pattern))
                        {
                            Has10digitis = false;
                            Console.WriteLine("It has to be numbers instead of letters");
                        }
                        else
                        {
                            int turns = 0;
                            Has10digitis = true;
                            Array.Resize<char>(ref charArray, quantity);
                            charArray = userInput.ToCharArray();
                            foreach(char number in charArray)
                            {
                                turns++;

                                if (turns == 1)
                                    phoneNumber += "(";
                                else if(turns == 4)
                                    phoneNumber += ")";
                                else if (turns == 7)
                                    phoneNumber += "-";

                                phoneNumber += number;

                            }
                            Has10digitis = true;
                        }

                    }
                }
                catch { Has10digitis = false; }

            }



            Console.WriteLine($"{phoneNumber}");
        }


    }


}

