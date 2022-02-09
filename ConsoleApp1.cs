/*
 1.What type would you choose for the following “numbers”?
 A person’s telephone number
 -A string as many phone numbers can actually exceed int or longs.
 A person’s height
 -Integer
 A person’s age
 -Integer
 A person’s gender (Male, Female, Prefer Not To Answer)
 -String (m),(f),(n/a)
 A person’s salary
 -Decimal
 A book’s ISBN
 -Long
 A book’s price
 -Decimal
 A book’s shipping weight
 -Float Point
 A country’s population
 -Long
 The number of stars in the universe
 -Ulong
 The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)
 -Int
 
 2.What are the difference between value type and reference type variables? What is boxing and unboxing?
 -Boxing is taking a value type and making it an object or a reference type variable.  Unboxing is the opposite of this process.
  A value type is a set value and a reference type can be seen as an object.

 3.What is meant by the terms managed resource and unmanaged resource in .NET
 -Managed resources are within .Net
 -Unmanaged are not.
 
 4.Whats the purpose of Garbage Collector in .NET?
 -Its to free up memory.
 */

using System;

namespace ConsoleApp1
{
    class ConsoleApp1
    {
        static void Main(string[] args)
        {
            //Hacker name example!
            Console.WriteLine("What is your favorite color? \n");
            String favColor = Console.ReadLine();
            Console.WriteLine("What is your Astrology Sign? \n");
            String aSign = Console.ReadLine();
            Console.WriteLine("What is the number of your street address? \n");
            String aNum = Console.ReadLine();
            Console.WriteLine("Your hacker name is " + favColor + aSign + aNum);
        }
    }
}
