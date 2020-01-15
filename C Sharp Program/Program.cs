using System;

namespace C_Sharp_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            Console.WriteLine();
            string Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("So your name is " + Name + "?");
            Console.WriteLine();
            string Check = Console.ReadLine().ToLower();
            if(Check=="Yes".ToLower())
            {
                Console.WriteLine();
                Console.WriteLine("Welcome " + Name);
            }
            else if (Check=="No".ToLower())
            {
                Console.WriteLine();
                Console.WriteLine("ERROR, application is malfunctioning!");
                Console.ReadKey();
                Environment.Exit(2);
            }
            if(Check=="Yes".ToLower())
            {
                Console.Clear();
                Console.WriteLine("So not to be a creep or anything " + Name + " \nWhen is your birthday?");
                Console.Write("Please enter the day you were born: ");
                int BirthDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the month (number) you were born: ");
                int BirthMonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the age you were born: ");
                int BirthYear = Convert.ToInt32(Console.ReadLine());

                var BirthDayWrite= new DateTime(BirthYear,BirthDay,BirthMonth,DateTime.Now,Convert.ToInt32(DateTime.Now),Convert.ToInt32(DateTime.Now));
                BirthDayWrite.ToString();
                Console.WriteLine("So your birthday is: " + BirthDayWrite+" yes?");
            }

            Console.ReadKey();
        }
    }
}
