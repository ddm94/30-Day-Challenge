using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// Solution using regualr expressions
class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        Regex regex = new Regex(@"^([a-z]+)\s.+@gmail\.com$");

        List<string> users = new List<string>();

        for (int NItr = 0; NItr < N; NItr++)
        {
            string input = Console.ReadLine();

            Match match = regex.Match(input);

            if (match.Success)
            {
                users.Add(match.Groups[1].Value);
            }
        }

        users.Sort();

        foreach (string name in users)
        {
            Console.WriteLine(name);
        }
    }
}

// Solution without using regular expressions
/*
class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<string> users = new List<string>();

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];
            
            if(emailID.Contains("@gmail.com"))     
            {
               users.Add(firstName); 
            }
        }
        
        users.Sort();
        
        foreach(string name in users)
        {
            Console.WriteLine(name);
        }
    }
}
*/
