using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    /// <summary>
    /// An Algorithm to check if a number is prime or not
    /// </summary>
    /// <param name="n">An integer to be tested for primality</param>
    /// <returns>True if n is a prime number, false otherwise</returns>
    public static bool PrimalityAlgorithm(int n)
    {
        // Simplest case
        // 2 and 3 are prime numbers      
        if (n == 2 || n == 3)
        {
            return true;
        }

        // If n = 0 OR n is an even number OR n is an odd number divisible by 3
        if (n <= 1 || n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        // If n < i we skip
        // E.g. let n = 25
        // When i = 5; 5 * 5 = 25 <= n; i next cycle will be 11
        // 25 % 5 = 0 so we retun false
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        // In all other cases
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