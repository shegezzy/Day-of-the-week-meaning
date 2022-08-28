using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ar day = DateTime.Now.DayOfWeek.ToString();

            Console.WriteLine("Meanings of the Names of the Days checker");
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome {name},How is your day !!!");


            Console.WriteLine("Enter the day...");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month...");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year...");
            var year = Console.ReadLine();

            DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine("\n The day is " + date.DayOfWeek);

            Console.WriteLine("Please re-enter the day to reveal Meanings of the Names of the Days \n");
            var enteredDay = Console.ReadLine();

            switch (enteredDay)
            {
                case "Sunday": Console.WriteLine("Day of the sun"); break;
                case "Monday": Console.WriteLine("Day of the Moon"); break;
                case "Tuesday": Console.WriteLine("Tiw's (Tiu's) Day"); break;
                case "Wednesday": Console.WriteLine("Woden's Day"); break;
                case "Thursday": Console.WriteLine("Thor's Day"); break;
                case "Friday": Console.WriteLine("Freya's day"); break;
                case "Saturday": Console.WriteLine("Saturn's day"); break;
            }
        }
    }
}
