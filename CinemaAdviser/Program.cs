using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            string genre;

            WriteLine("An utility that helps to find some movie for an evening");
            WriteLine("Please enter your name:");
            string name = ReadLine();
            WriteLine("Hello {0}!", name);

            //if (genre != null || genre != "comedy" || genre != "dramma")
            WriteLine("Please enter what kind of movie you prefer, [comedy], [dramma], [adult] movie?");
            do
            {
                genre = ReadLine();
                if (genre == "comedy")
                {
                    WriteLine("Comdey A");
                    WriteLine("Comdey B");
                    WriteLine("Comdey C");
                    WriteLine("Comdey D");
                    break;
                } else
                if (genre == "dramma")
                {
                    WriteLine("Dramma A");
                    WriteLine("Dramma B");
                    WriteLine("Dramma C");
                    WriteLine("Dramma D");
                    break;
                }
                else if(genre == "adult")
                {
                    WriteLine("How old are you?");
                    string years_s = ReadLine();
                    int years = Int32.Parse(years_s);
                    if (years < 18)
                    {
                        WriteLine("You're to young, come back after "+(18-years)+" years");
                        break;
                    }
                    else
                    {
                        WriteLine("Adult A");
                        WriteLine("Adult B");
                        WriteLine("Adult C");
                        WriteLine("Adult D");
                        break;
                    }
                }

                WriteLine("Please enter only comedy, dramma or adult");
            }
            while (genre == null || genre != "comedy" || genre != "dramma" || genre != "adult");            

            ReadLine();
        }
    }
}