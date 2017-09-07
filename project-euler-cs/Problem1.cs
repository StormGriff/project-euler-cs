using System;
using System.Collections.Generic;
using System.Text;

namespace project_euler_cs
{
    class Problem1
    {
        public static string statement = "Find the sum of all the multiples of 3 or 5 below 1000.";

        public static long Run()
        {
            long max = 1000;

            List<long> multiples = new List<long>();
            multiples.Add(3);
            multiples.Add(5);

            List<long> values = Snippets.ReturnAllMultiples(multiples, max);

            long sum = Snippets.Sum(values);

            return sum;
        }
    }
}
