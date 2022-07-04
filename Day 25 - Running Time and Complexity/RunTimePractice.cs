using System;
using System.Collections.Generic;
using System.IO;

class RunTimePractice
{
    // Linear Time: O(n)
    public static int FindNumsOfRepetitions(String s, char c)
    {
        // Repetition counter
        // O(1)
        int sum = 0;

        // O(n + 1)
        for (int i = 0; i < s.Length; i++)
        {
            // O(n)
            if (s[i] == c)
            {
                // O(n)
                sum++;
            }
        }

        // O(1)
        return sum;
    }

    // Quadratic Time: O(n * m)
    public static int[] FindNumsOfRepetitionsV1(String s, char[] c)
    {
        // O(1)
        int[] sums = new int[c.Length];

        // O(1); O(n + 1); O(n)
        for (int i = 0; i < s.Length; i++)
        {
            // O(n + 1); O(n * m) + 1; O(n * m)
            for (int j = 0; j < c.Length; j++)
            {
                // O(n * m)
                if (s[i] == c[j])
                {
                    // O(n * m)
                    sums[j] = sums[j] + 1;
                }
            }
        }

        // O(1)
        return sums;
    }

    // Optimal Time: O(n + m)
    public static int[] FindNumsOfRepetitionsV2(String s, char[] c)
    {
        // O(1)
        int[] sums = new int[c.Length];

        Dictionary<char, int> dict = new Dictionary<char, int>();

        // O(1); O(n + 1); O(n)
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], 1);
            }
            else
            {
                int sum = dict[s[i]];
                dict[s[i]] = sum + 1;
            }
        }

        for (int j = 0; j < c.Length; j++)
        {
            int sum;

            if (dict.ContainsKey(c[j]))
            {
                sums[j] = 0;
            }
            else
            {
                sums[j] = dict[c[j]];
            }
        }

        // O(1)
        return sums;
    }

    static void Main(String[] args)
    {
        // Get time in milliseconds
        long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        Console.WriteLine(FindNumsOfRepetitions("abca", 'a'));

        long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        long duration = endTime - startTime;

        Console.WriteLine("Test " + duration + "ms");


        char[] a = {'a', 'b'};

        // 1nd Test
        startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        foreach (int entryOne in FindNumsOfRepetitionsV1("abcalkh/'frlngfewbwiblbdLhn./fwvbwiclwjfhiwvgbf,.fvlojwopqdb,./fhofbhqwknw.,waebgv", a))
        {
            Console.WriteLine(entryOne);
        }

        endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        duration = endTime - startTime;

        Console.WriteLine("Test V1 " + duration + "ms");

        // 2nd Test
        startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        foreach (int entryTwo in FindNumsOfRepetitionsV1("abcalkh/'frlngfewbwiblbdLhn./fwvbwiclwjfhiwvgbf,.fvlojwopqdb,./fhofbhqwknw.,waebgv", a))
        {
            Console.WriteLine(entryTwo);
        }

        endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        duration = endTime - startTime;

        Console.WriteLine("Test V2 " + duration + "ms");
    }
}