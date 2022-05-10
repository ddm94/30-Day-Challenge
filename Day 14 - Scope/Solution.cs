using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] elements)
    {
        this.elements = elements;
    }
    
    public void computeDifference()
    {
        for(int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++) 
            {
                int tempDifference = 0;
                
                tempDifference = Math.Abs(elements[i] - elements[j]);
                
                if (tempDifference > maximumDifference)
                {
                    maximumDifference = tempDifference;
                }
            }
        }
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}