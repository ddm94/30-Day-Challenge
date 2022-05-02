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
    public Solution() {
        
    }
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Solution loop = new Solution();
        loop.MultiplesOfNumber(n);
        // Multiples(n);
    }
    
    public void MultiplesOfNumber(int n) 
    {
        for(int i = 1; i < 11; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + n * i);
        }  
    }
    
    public static void Multiples(int n)
    {
        for(int i = 1; i < 11; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + n * i);
        }
    }
}
