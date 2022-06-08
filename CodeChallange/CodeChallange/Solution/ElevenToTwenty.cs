using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Solution
{
   public  class ElevenToTwenty
    {

        //11. Takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
        public static void Eleventh()
        {
            int userInput = 0;
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            string time = "";
            int lenght = 0;
            List<string> timeList = new List<string>();


            try
            {
                Console.WriteLine("Please, enter a number");
                userInput = int.Parse(Console.ReadLine());

                for (int i = 1; i <= userInput; i++)
                {
                    if (seconds <= 59)
                    {
                        seconds++;
                        if (seconds == 60)
                        {
                            seconds = 0;
                            minutes++;
                        }
                    }
                    if (minutes == 60)
                    {
                        seconds = 0;
                        minutes = 0;
                        hours++;
                    }
                }


                timeList.Add(seconds.ToString());
                timeList.Add(minutes.ToString());
                timeList.Add(hours.ToString());


                for (int i = 0; i < timeList.Count; i++)
                {
                    lenght = timeList[i].Length;
                    if (lenght != 2)
                        timeList[i] = "0" + timeList[i];

                }


                time = $"{timeList[2]}:{timeList[1]}:{timeList[0]}";
                Console.WriteLine(time);


            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        //11. Takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
        public static void Twelveth()
        {
            int userInput = 0;
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            string time = "";
            int lenght = 0;
            List<string> timeList = new List<string>();


            try
            {
                Console.WriteLine("Please, enter a number");
                userInput = int.Parse(Console.ReadLine());

                for (int i = 1; i <= userInput; i++)
                {
                    if (seconds <= 59)
                    {
                        seconds++;
                        if (seconds == 60)
                        {
                            seconds = 0;
                            minutes++;
                        }
                    }
                    if (minutes == 60)
                    {
                        seconds = 0;
                        minutes = 0;
                        hours++;
                    }
                }

                if (seconds < 1)
                    timeList.Add($"{seconds.ToString()} second");
                else
                    timeList.Add($"{seconds.ToString()} seconds");

                if (minutes == 0) { }
                else if (minutes < 1)
                    timeList.Add($"{minutes.ToString()} minute");
                else
                    timeList.Add($"{minutes.ToString()} minutes");

                if (hours == 0) { }
                else if (hours < 1)
                    timeList.Add($"{hours.ToString()} hour,");
                else
                    timeList.Add($"{hours.ToString()} hours, ");

                for (int i = 0; i < timeList.Count; i++)
                {
                    lenght = timeList[i].Length;
                    if (lenght != 2)
                        timeList[i] = "0" + timeList[i];

                }


                time = $"{timeList[2]}:{timeList[1]}:{timeList[0]}";
                Console.WriteLine(time);


            }
            catch
            {
                Console.WriteLine("Error");

            }


        }
    }
}
