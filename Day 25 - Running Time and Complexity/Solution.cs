using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    public static bool PrimalityAlgorithm(int n)
    {
        if (n == 2 || n == 3)
        {
            return true;
        }

        if (n <= 1 || n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int n = Int32.Parse(Console.ReadLine());

            if (PrimalityAlgorithm(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}