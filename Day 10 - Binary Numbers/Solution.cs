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
    
    public static void PrintConsecutive(int n)
    {        
        int consecutive = 0;
        int count = 0;
        
        while (n > 0)
        {
            int remainder = n % 2;
            
            n = n / 2;
            
            if (remainder == 1)
            {
                consecutive++;
                
                if (consecutive >= count)
                {
                    count = consecutive;
                }
            }
            else 
            {
                consecutive = 0;
            }
        }
                
        Console.WriteLine(count);
    }
        
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        PrintConsecutive(n);
    }
}