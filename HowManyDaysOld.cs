using System;

namespace HowManyDaysOld
{
    class HowManyDaysOld
    {
        static void Main(string[] args)
        {
            int useryear, usermonth, userday;
            Console.WriteLine("Select birth year");
            useryear = int.Parse(Console.ReadLine());
            Console.WriteLine("Select birth month");
            usermonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Select birth day");
            userday = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime userDOB = new DateTime(useryear, usermonth, userday);
            var dayslived = today - userDOB;
            Console.WriteLine("You have lived for " + dayslived + " days");
        }
    }
}
