using System;
using System.Collections.Generic;
using System.Text;

namespace project_euler_cs
{
    class Program
    {
        public static void Main()
        {
            long selection = 1;
            long result;

            while(selection != 0)
            {
                Console.Write("Enter problem number (0 to exit): ");
                selection = Convert.ToInt64(Console.ReadLine());

                switch(selection)
                {
                    case 3:
                        result = Problem3.Run();
                        Console.WriteLine(Problem3.statement);
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 2:
                        result = Problem2.Run();
                        Console.WriteLine(Problem2.statement);
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 1:
                        result = Problem1.Run();
                        Console.WriteLine(Problem1.statement);
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 0:
                        break;
                }
            }

            Console.Write("Press <ENTER> to exit . . . ");
            Console.ReadLine();
        }
    }
}
