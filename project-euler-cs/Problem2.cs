using System;
using System.Collections.Generic;
using System.Text;

namespace project_euler_cs
{
    class Problem2
    {
        public static string statement = "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";

        public static long Run()
        {
            long sum = 0;

            List<long> fib = Snippets.GenerateFibonacci(4000000);

            foreach(long l in fib)
            {
                if(l % 2 == 0)
                {
                    sum += l;
                }
            }

            return sum;
        }
    }
}
