using System;
using System.Collections.Generic;
using System.IO;

public class Date
{
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public static int CalculateFine(Date r, Date d)
    {
        if (r.year - d.year > 0)
        {
            // Book is returned after the calendar year in which it was expected
            return 10000;
        }
        else if (r.year == d.year)
        {
            if (r.month - d.month > 0)
            {
                //  Book is returned after the expected return month but still within the same calendar year as the expected return date
                return (r.month - d.month) * 500;
            }
            else if (r.month == d.month)
            {
                if (r.day - d.day > 0)
                {
                    // Book is returned after the expected return day but still within the same calendar month and year as the expected return date
                    return (r.day - d.day) * 15;
                }
                else
                {
                    // Book is returned on or before the expected return date
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }
}

class Solution
{
    static void Main(String[] args)
    {
        int d1, m1, y1;
        int d2, m2, y2;

        int result;

        string[] split = Console.ReadLine().Split(' ');

        d1 = Int32.Parse(split[0]);
        m1 = Int32.Parse(split[1]);
        y1 = Int32.Parse(split[2]);

        Date r = new Date(d1, m1, y1);

        split = Console.ReadLine().Split(' ');

        d2 = Int32.Parse(split[0]);
        m2 = Int32.Parse(split[1]);
        y2 = Int32.Parse(split[2]);

        Date d = new Date(d2, m2, y2);

        result = Date.CalculateFine(r, d);
        Console.WriteLine(result);
    }
}