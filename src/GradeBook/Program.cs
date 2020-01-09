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
            book.ShowStats();


        }
    }
}