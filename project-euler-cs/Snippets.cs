using System;
using System.Collections.Generic;
using System.Text;

namespace project_euler_cs
{
    class Snippets
    {
        /// <summary>
        /// Calculates all multiples of the passed in values and returns a List containing all multiples
        /// </summary>
        /// <param name="multiples">A List containing the multiples</param>
        /// <param name="max">Long int for max value</param>
        /// <returns></returns>
        public static List<long> ReturnAllMultiples(List<long> multiples, long max)
        {
            List<long> ret = new List<long>();

            for(long i = 0; i < max; ++i)
            {
                foreach(long l in multiples)
                {
                    if (i % l == 0)
                    {
                        ret.Add(i);
                        break;
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// Calculates the sum of the provided list.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static long Sum(List<long> values)
        {
            long ret = 0;

            foreach(long l in values)
            {
                ret += l;
            }

            return ret;
        }

        /// <summary>
        /// Calculates and returns a list of fibonacci sequence numbers up to the given max.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<long> GenerateFibonacci(long max)
        {
            List<long> ret = new List<long>();

            ret.Add(1);
            ret.Add(2);

            while(ret[ret.Count-1] < max)
            {
                long current = ret[ret.Count - 1];
                long next = current + ret[ret.Count - 2];
                ret.Add(next);
            }

            return ret;
        }

        /// <summary>
        /// Determines if the passed number is prime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPrime(long value)
        {
            for(int i = 1; i < 11; ++i)
            {
                if(i > value)
                {
                    return true;
                }

                if(i == 1)
                {
                    continue;
                }
                else if(value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
