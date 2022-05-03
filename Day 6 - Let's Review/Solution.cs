using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
	// Return a string of even-indexed characters
    public string PrintEven(string s)
    {
		// Break down s string into its character components
        char[] c = s.ToCharArray();
        
        string even = "";
                                
        for(int i = 0; i < s.Length; i++)
        {
			// Even
            if (i % 2 == 0)
            {
				// Add the even-indexed value converted to a string
				// and assign the result to even
				even += c[i].ToString();
            }
        }
        
        return even;
    }
    
	// Same process as PrintEven, except we check for odd index
    public string PrintOdd(string s)
    {
        char[] c = s.ToCharArray();
        
        string odd = "";
                                
        for(int i = 0; i < s.Length; i++)
        {
            if (i % 2 != 0)
            {
				odd += c[i].ToString();
            }
        }
        
        return odd;
    }
    
	// Print the even and odd string separated by an empty space
    public void Print(string s)
    {
        Console.WriteLine(PrintEven(s) + " " + PrintOdd(s));
    }
        
    static void Main(String[] args) {
		
        /* Enter your code here. Read input from STDIN.
		Print output to STDOUT. Your class should be named Solution */   
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) 
        {
            string s = Console.ReadLine();
        
            Solution solution = new Solution();
            solution.Print(s);
        }
    }
}