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

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        CompareNumbers(N);
    }
    
    public static void CompareNumbers(int n) 
    {   
        if (n % 2 == 1 )
        {
            Console.WriteLine("Weird");
        }
        else if (n >= 2 && n <= 5)
        {
            Console.WriteLine("Not Weird");
        }
        else if (n >= 6 && n <= 20 )
        {
            Console.WriteLine("Weird");
        }
        else if (n > 20) 
        {
            Console.WriteLine("Not Weird");
        }
    }
}
