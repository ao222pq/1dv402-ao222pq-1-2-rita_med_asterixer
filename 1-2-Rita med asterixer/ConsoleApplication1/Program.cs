using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int columns = 39;
            int rows = 25;
            int switchCase;

            for (int i = 1; i <= rows; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }

                switchCase = i % 3;
                switch (switchCase)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }


                for (int j = 1; j <= columns; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }

            Console.ResetColor();



        }
    }
}
