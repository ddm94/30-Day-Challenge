using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    public string PrintEven(string s)
    {
		// Break down string into a sequence of characters 
        char[] c = s.ToCharArray();
        // String of even-indexed characters
        string even = "";
                                
        for(int i = 0; i < s.Length; i++)
        {
			// Even index
            if (i % 2 == 0)
            {
				// Assign the value with even index to our string
				even += c[i].ToString();
            }
        }
        
        return even;
    }
    
	// Same process as before, except we are checking for odd index
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
    
    public void Print(string s)
    {
        Console.WriteLine(PrintEven(s) + " " + PrintOdd(s));
    }
        
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) 
        {
            string s = Console.ReadLine();
        
            Solution solution = new Solution();
            solution.Print(s);
        }
    }
}
