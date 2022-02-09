using System;

namespace CountingUpTo24
{
    class CountingUpTo24
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 0; j <= 24; j += i)
                {
                    Console.Write(j.ToString()+",");
                }
                Console.WriteLine();
            }
        }
    }
}
