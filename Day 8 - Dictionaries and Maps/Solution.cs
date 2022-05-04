using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. 
        Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        for (int i = 0; i < n; i++) 
        {   
            string[] entry = Console.ReadLine().Split(' ');
            
            phoneBook.Add(entry[0], entry[1]);
        }
        
        string name;
        
        while ((name = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }               
    }
}