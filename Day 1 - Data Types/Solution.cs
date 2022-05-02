        // Declare second integer, double, and String variables.
        int secondInt;
        double secondDouble;
        string secondString;
        
        // Read and save an integer, double, and String to your variables.
        secondInt = Convert.ToInt32(Console.ReadLine());
        secondDouble = Convert.ToDouble(Console.ReadLine());
        secondString = Console.ReadLine();
            
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + secondInt);
        
        // Print the sum of the double variables on a new line. 
        Console.WriteLine("{0:F1}", d + secondDouble);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + secondString);