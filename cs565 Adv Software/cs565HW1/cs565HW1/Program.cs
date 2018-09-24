using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs565HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Holiday determination App. What this does is determine when an employee gets the holiday hours based on their work" +
                " schedule and what day the Holiday falls on. Input would be the employees work schedule, and the day of the holiday. Be sure to include if the " +
                "employee is swapping a day off for a regular non-workday.");

            Console.WriteLine("\n Enter the day of the week the holiday lands on:(Su/M/T/W/Th/F/S)");
            string holiday = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the days the employee works seperated by a space: (Su M T W Th F S)");
            string workWeek = Console.ReadLine().ToUpper();

            List<string> WorkWeek = new List<string>();
            WorkWeek = workWeek.Split(' ').ToList();
            List<string> regWeek = new List<string> { "SU", "M", "T", "W", "TH", "F", "S" };

            bool takesHoliday = false;
            while(!takesHoliday)
            {
                foreach(var day in regWeek)
                {
                    if(day.Equals(holiday) && workWeek.Contains(day))
                    {
                        takesHoliday = true;
                        break;
                    }
                }
                if (!takesHoliday)
                {
                    holiday = regWeek[(regWeek.IndexOf(holiday) + 1) % 7];
                }
                
            }

            Console.WriteLine("Employee will take the holiday on: {0}", holiday);
            Console.ReadLine();
        }
    }
}
