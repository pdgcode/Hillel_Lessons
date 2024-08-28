﻿using System.Threading.Channels;

namespace Hillel_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "John Sohnson";

            int spaceIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }
            char firstLetterOfFirstName = input[0];
            char firstLetterOfLastName = input[spaceIndex + 1];

            if (firstLetterOfFirstName == firstLetterOfLastName)
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
            }
            else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
            }

        }
    }
}
