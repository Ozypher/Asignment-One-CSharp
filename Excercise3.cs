using System;



/*
 1. What happens when you divide an int variable by 0? 
 -A divide by 0 error
 2. What happens when you divide a double variable by 0? 
 -A divide by 0 error
 3.What happens when you overflow an int variable, that is, set it to a value beyond its range?
 -It resets to the negative value
 4.What is the difference between x = y++; and x = ++y;? 
 -It changes the order that 1 is added to Y.  ++y makes 1 get added BEFORE it is given value to X, and vice versa for y++
 5.What is the difference between break, continue, and return when used inside a loop statement?
 -Break stops loop, continue goes to next iteration, and return stops with a return
 6.What are the three parts of a for statement and which of them are required? 
 -an initializer a condition and an iterator.  The only required fields are initializer and condition
 7.What is the difference between the = and == operators? 
 -'=' is setting a value, while '==' is checking the value to a comparator.
 8.Does the following statement compile? for ( ; true; );
 -yes.
 9.What does the underscore _ represent in a switch expression?
 -It represents the default value
10.What interface must an object implement to be enumerated over by using the foreach statement?
 -IEnumerable interface
 */
namespace Excercise3
{
    class Excercise3
    {
        static void Main(string[] args)
        {
            for(int i=1; i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if(i%3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
