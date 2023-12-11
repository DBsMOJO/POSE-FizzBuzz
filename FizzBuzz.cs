/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 05.12.2023
 *--------------------------------------------------------------
 * Description:
 * ...
 *--------------------------------------------------------------
*/

using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write(" Buzz");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(" " + i);
                }
                Console.Write(",");

            }
            Console.WriteLine();
        }
    }
}
