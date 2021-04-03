using System;

namespace EnumsAndProperties
{
    enum DayWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class Demo
    {
        
        public DayWeek DayOfWeek { get; set; }

        void PrintGreetings()
        {

            if (DayOfWeek == DayWeek.Sunday)
            {
                Console.WriteLine("Thank god its sunday");
            }

            else if (DayOfWeek == DayWeek.Saturday)
            {
                Console.WriteLine("It nis holiday");
            }
            else
            {
                Console.WriteLine("It is Working day");
            }
        }
    }
}