using System;

namespace GreetingConsole
{
    class GreetingConsole
    {
        static void Main(string[] args)
        {
            DateTime startMorn = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,6, 0, 0);//6 am
            DateTime endMorn = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);//12 pm
            DateTime startNight = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);//6 pm
            DateTime endNight = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 59, 59);//12 am

            DateTime now = DateTime.Now;

            if ((now > startMorn) && (now < endMorn))
            {
                Console.WriteLine("Good Morning");
            }
            if ((now > endMorn) && (now < startNight))
            {
                Console.WriteLine("Good Afternoon");
            }
            if ((now > startNight) && (now < endNight))
            {
                Console.WriteLine("Good Evening");
            }
            if (now > endNight)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
