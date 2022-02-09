using System;

namespace Print_A_Pyramid
{
    class Print_A_Pyramid
    {
        static void Main(string[] args)
        {
            int layernum = 5;
            int Space;
            int Number;
            for (int i = 1; i <= layernum;i++)
            {
                for (Space = 1; Space <= (layernum - i); Space++)
                {
                    Console.Write(" ");
                }
                for (Number = 1; Number <= i; Number++)
                {
                    Console.Write('*');
                }
                for (Number = (i-1); Number >= 1; Number--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
