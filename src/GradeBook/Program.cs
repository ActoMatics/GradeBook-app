using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dan's Grade Book");
            book.AddGrade(72.3);
            book.AddGrade(92.3);
            book.AddGrade(85.3);
            
            var stats = book.GetStats();

            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The average grade is: {stats.Average:N2}");
        }
    }
}