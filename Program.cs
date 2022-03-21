using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number;
            int reminder;
            int sum = 0;
            int temp;
           Console.Write("Enter the Number= ");
           number = int.Parse(Console.ReadLine());
           temp = number;
           while (number > 0)
           {
               reminder = number % 10;
               sum = sum + (reminder * reminder * reminder* reminder);
                number = number / 10;
           }
           if (temp == sum)
               Console.Write("Armstrong Number.");
           else
               Console.Write("Not Armstrong Number.");
         
        }
    }
}
