using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms1
{
    class PrimeNumInRange
    {
        int end=1000,count=0;
        public void FindPrime()
        {
            for (int i = 1; i < end; i++)
            {
                for (int j = 1; j < end; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(i + " ");
                }
                count = 0;
            }
        }
    }
}