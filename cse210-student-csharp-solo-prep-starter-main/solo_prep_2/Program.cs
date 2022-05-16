using System;

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            if (x > y)
            {
                Console.WriteLine("Greater");
            }
            else if (x < y)
            {
                Console.WriteLine("Less");
            }
            else
            {
                Console.WriteLine("Not Greater");
            }
        }
    }
}
