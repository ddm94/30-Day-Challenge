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
    public static void HourglassMaxSum(List<List<int>> arr)
    {                
        int maxSum = Int32.MinValue;
        
        for(int x = 0; x < 4; x++)
        {   
            for (int y = 0; y < 4; y++)
            {
                int tempSum = 0;
                
                //Top
                tempSum += arr[x][y];
                tempSum += arr[x][y + 1];
                tempSum += arr[x][y + 2];
                
                // Middle
                tempSum += arr[x + 1][y + 1];
                
                // Bottom
                tempSum += arr[x + 2][y];
                tempSum += arr[x + 2][y + 1];
                tempSum += arr[x + 2][y + 2];
                                
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
        }
        
        Console.WriteLine(maxSum);
    }
    
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        
        HourglassMaxSum(arr);
    }
}