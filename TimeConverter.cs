using System;

namespace TimeConverter
{
    class TimeConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the amount of centuries to convert.");
            String result = Console.ReadLine();
            int centuries = Int32.Parse(result);
            int years = centuries * 100;
            int days = years * 365;
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long miliseconds = seconds * 1000;
            ulong nanoseconds = (ulong)miliseconds * 1000000;
            Console.WriteLine(centuries + " centuries = " + years + " years = " + days + " days = " + hours + " hours = " + minutes + " minutes = " + seconds + " seconds = " + miliseconds + " miliseconds = " + nanoseconds + " nanoseconds");
        }
    }
}
