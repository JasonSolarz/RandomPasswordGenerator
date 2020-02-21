using System;
using System.Collections.Generic;

namespace Passphrase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------/Password Phrase Generator/------\n\n");
            Console.Title = "Password Phrase Generator";

            List<char> ASCII = new List<char>();
            Random rand = new Random();
            int userInput = 1;

            //Add Invidual ASCII Characters
            ASCII.Add(Convert.ToChar(33)); // !
            ASCII.Add(Convert.ToChar(63)); // ?
            ASCII.Add(Convert.ToChar(36)); // $

            //Add the ASCII Characters A - Z
            for (int lcv = 65; lcv <= 90; lcv++)
            {
                ASCII.Add(Convert.ToChar(lcv));
            }

            //Add the ASCII Numbers 1 - 9
            for(int lcv = 49; lcv <= 57; lcv++)
            {
                ASCII.Add(Convert.ToChar(lcv));
            }

            //Add the ASCII Lower Characters a - z
            for(int lcv = 97; lcv <= 122; lcv++)
            {
                ASCII.Add(Convert.ToChar(lcv));
            }

            Console.WriteLine("How many passwords would you like to generator? ( 1 -> 20)");
            Console.Write(": ");
            userInput = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n\nYour Randomly Generated Passwords:\n\n");
            for (int lcv = 0; lcv < userInput; lcv++)
            {
                Console.Write(lcv + 1 + ". ");
                for(int lcv2 = 0; lcv2 < 14; lcv2++)
                {
                    Console.Write(ASCII[rand.Next(0, ASCII.Count)]);
                }
                Console.WriteLine();
            }



        }
    }
}
