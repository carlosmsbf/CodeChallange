using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallange.Solution
{
    public class OneToTen
    {

        // 1. Multiples of 3 or 5.
        public static void FirstCase()
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

        //Multiples of 3 or 5."


        public static void SecondCase()
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
        public static void ThirdCase()
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
        public static void FourthCase()
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
        public static void Fifith()
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
        public static void Sixth()
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
                    if (quantityResult[i] == 1)
                        Console.WriteLine($"number: {result[i]} has {quantityResult[i]} odd number");
                    else
                    {
                        Console.WriteLine($"number: {result[i]} has {quantityResult[i]} odds numbers");
                    }
            }
        }

        //Stop gninnipS My sdroW!
        public static void Seventh()
        {

            string userInput;
            int quantity;
            string str = "";
            char[] wordArray = new char[0];
            List<string> words = new List<string>();
            Random random = new Random();
            int num = 0;


            Console.WriteLine("Please, enter a phrase.");

            userInput = Console.ReadLine();

            words = userInput.Split(' ').ToList();

            num = random.Next(0, words.Count);

            quantity = words[num].Length;
            Array.Resize<char>(ref wordArray, quantity);

            wordArray = words[num].ToCharArray();

            Array.Reverse(wordArray);

            words[num] = "";

            foreach (char c in wordArray)
                words[num] += c.ToString();

            str = "";

            foreach (string word in words)
                str += word + " ";

            Console.WriteLine($"{str.Trim()}");

        }

        //8. Find the smallest integer in the array
        public static void Eighth()
        {
            int userInput = 0;
            int smallestNumber = 0;
            int biggestNumber = 0;
            string str = "";
            List<int> intList = new List<int>();

            while (userInput > 10 || userInput <= 2)

                try
                {
                    Console.WriteLine("Please, how many array slot do you want to create between 2 to 10.");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput <= 2 || userInput > 10)
                        Console.WriteLine("Sorry, we could not process");
                    else
                    {
                        for (int i = 1; i <= userInput; i++)
                        {
                            Console.WriteLine("Please, digit your number");
                            intList.Add(int.Parse(Console.ReadLine()));
                        }

                        smallestNumber = intList[0];
                        foreach (int i in intList)
                        {
                            if (i < smallestNumber)
                                smallestNumber = i;

                            if (i > biggestNumber)
                                biggestNumber = i;
                        }
                        Console.WriteLine($"Smallest number: {smallestNumber } and the biggest number: {biggestNumber}");
                        foreach (int i in intList)
                        {
                            str += i + " ";
                        }
                        Console.WriteLine($"All the inputs: {str.Trim()}");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input.");
                }
        }
        // 9. Given an array of integers, return a new array with each value doubled.
        public static void Nineth()
        {
            int userInput = 0;
            List<int> intList = new List<int>();
            string strIntList = "";
            string strNewIntList = "";
            List<int> newIntList = new List<int>();


            while (userInput > 10 || userInput <= 2)

                try
                {
                    Console.WriteLine("Please, how many array slot do you want to create between 2 to 10.");
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput <= 2 || userInput > 10)
                        Console.WriteLine("Sorry, we could not process");

                    else
                    {
                        for (int i = 0; i <= userInput - 1; i++)
                        {
                            Console.WriteLine("Please, digit your number");
                            intList.Add(int.Parse(Console.ReadLine()));
                            strIntList += $"[{intList[i]}] ";
                        }


                        foreach (int i in intList)
                        {
                            strNewIntList += $"[{i * 2}] ";
                        }

                        Console.WriteLine($"The result of the old digits was: {strIntList} and the new digits is: {strNewIntList}");

                    }
                }



                catch (Exception)
                {
                    Console.WriteLine("Wrong input.");
                }
        }


        // 9. Given a string, replace every letter with its position in the alphabet
        public static void Tenth()
        {
            string userInput = "";
            char[] charArray = new char[0];
            List<char> charList = new List<char>();
            int quantity = 0;
            string str = "";


            try
            {
                Console.WriteLine("Please, enter a phrase");
                userInput = Console.ReadLine();

                quantity = (userInput.ToCharArray()).Length;
                Array.Resize<char>(ref charArray, quantity);
                string pattern = @"[a-zA-Z]";

                charArray = userInput.ToCharArray();

                foreach (char c in charArray)
                {
                    if (Regex.IsMatch(c.ToString(), pattern))
                        charList.Add(c);
                }

                foreach (char c in charList)
                {
                    str += $"{((byte)c) - 96} ";
                }

                Console.WriteLine(str);

            }
            catch { Console.WriteLine("Error."); }

        }



    }
}
