using System;
using System.Collections.Generic;
using System.Text;

namespace project_euler_cs
{
    class Problem3
    {
        public static string statement = "What is the largest prime factor of the number 600851475143 ?";

        public static long Run()
        {
            long num = 600851475143;
            long result = 0;

            for(long i = 0; i < num; ++i)
            {
                if(Snippets.IsPrime(i))
                {
                    if(i % num == 0)
                    {
                        result = i;
                    }
                }
                Console.WriteLine(i);
            }

            return result;
        }
    }
}
