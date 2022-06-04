using CodeChallange.Helpers;
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
                Console.WriteLine("5.Square Every Digit.");
                Console.WriteLine("6.Find the odd int");
                Console.WriteLine("7.Stop gninnipS My sdroW!");

                try
                {
                    menuOption = int.Parse(Console.ReadLine());

                }
                catch
                {
                    menuOption = 0;
                }

                switch (menuOption)
                {

                    // 1. Multiples of 3 or 5.
                    case 1:
                        FirstCase();

                        break;


                    //2.Return the number(count) of vowels in the given string.

                    case 2:
                        SecondCase();

                        break;

                    //3.Returning a string without vowel.
                    case 3:
                        ThirdCase();

                        break;

                    case 4:
                        FourthCase();

                        break;

                    //4.Square Every Digit
                    case 5:
                        Fifith();
                        break;
                    //5.Find the odd int
                    case 6:
                        Sixth();
                        break;

                    //6.Stop gninnipS My sdroW!
                    case 7:
                        Seventh();
                        break;


                    //7.End of Program
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
            string phoneNumber = "";

            while (Has10digitis == false)
            {
                try
                {
                    Console.WriteLine("Please, write a phone number of 10 digits");
                    userInput = Console.ReadLine();
                    quantity = (userInput.Length);
                    if (quantity < 10)
                    {
                        Has10digitis = false;
                        Console.WriteLine("It has to be 10 digits");
                    }
                    else
                    {
                        if (Regex.IsMatch(userInput, pattern))
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
                            foreach (char number in charArray)
                            {
                                turns++;

                                if (turns == 1)
                                    phoneNumber += "(";
                                else if (turns == 4)
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

        //Square Every Digit
        private static void Fifith()
        {

            string userInput;
            int quantity;
            char[] charArray = new char[0];
            string result = "";


            Console.WriteLine("Please, enter a integer number");

            userInput = Console.ReadLine();

            quantity = userInput.Length;
            Array.Resize<char>(ref charArray, quantity);
            charArray = userInput.ToCharArray();
            foreach (char number in charArray)
            {
                result += int.Parse(number.ToString()) * int.Parse(number.ToString());
            }


            Console.WriteLine($"{result}");
        }

        //Find the odd int
        private static void Sixth()
        {
            string userInput;
            int quantity;
            char[] charArray = new char[0];
            List<int> quantityResult = new List<int>();
            List<int> result = new List<int>();

            Console.WriteLine("Please, enter a integer number");

            userInput = Console.ReadLine();

            quantity = userInput.Length;
            Array.Resize<char>(ref charArray, quantity);
            charArray = userInput.ToCharArray();

            foreach (char number in charArray)
            {
                if (!result.Contains(int.Parse(number.ToString())))
                {
                    result.Add(int.Parse(number.ToString()));
                    quantityResult.Add(1);
                }
                else
                {
                    for (int x = 0; x < result.Count; x++)
                    {


                        if (result[x].Equals(int.Parse(number.ToString())))
                        {
                            quantityResult[x] = quantityResult[x] + 1;
                            break;
                        }
                    }
                }

            }

            for (int i = 0; i < result.Count; i++)
            {

                if (!(quantityResult[i] % 2 == 0))
                    if(quantityResult[i] == 1)
                    Console.WriteLine($"number: {result[i]} has {quantityResult[i]} odd number");
                    else
                    {
                        Console.WriteLine($"number: {result[i]} has {quantityResult[i]} odds numbers");
                    }
            }
        }

        //Stop gninnipS My sdroW!
        private static void Seventh()
        {

            string userInput;
            int quantity;
            string str = "";
            char[] charArray = new char[0];
            char[] wordArray = new char[0];
            //List<string> reverseWord = new List<string>();
            string reverseWord = "";
            List<string> words = new List<string>();
            int size = 0;
            string pattern = @"[a-zA-Z]";

            Random random = new Random();
            int num = 0;


            Console.WriteLine("Please, enter a phrase.");

            userInput = Console.ReadLine();

            quantity = userInput.Length;

            Array.Resize<char>(ref charArray, quantity);
            charArray = userInput.ToCharArray();

            size = charArray.Length;
            int a = 0;
            foreach(char letter in charArray)
            {
                a++;
                if (a == size)
                 { str += letter;
                     words.Add(str);
                     str = "";
                 }
                else if (Regex.IsMatch(letter.ToString(), pattern))
                {
                    str += letter;
                }
                
                else
                {
                    words.Add(str);
                    str = "";
                }
            }

            num = random.Next(0, words.Count);

            quantity = words[num].Length;
            Array.Resize<char>(ref wordArray, quantity);

            wordArray = words[num].ToCharArray();

                for (int i = wordArray.Length - 1; i >= 0; --i)
            {

                reverseWord += wordArray[i].ToString();
            }
            words[num] = reverseWord;


            str = "";

            foreach(string word in words)
            {
                str += word + " ";
            }

            Console.WriteLine($"{str.Trim()}");

        }
    }

}

