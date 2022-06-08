using CodeChallange.Helpers;
using CodeChallange.Solution;
using CodeChallange.View;
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

            int menuOption;
            bool isEnd = false;



            Console.WriteLine("Code Challange");

            while (isEnd == false)
            {
               
                //Menu of Code challange
                Interface.Menu();


                try
                {
                    menuOption = int.Parse(Console.ReadLine());
                }
                catch
                {
                    menuOption = 0;
                }

                SelectCodeChallange.Menu(menuOption, isEnd);


            };
        }

       

       

    }
}

