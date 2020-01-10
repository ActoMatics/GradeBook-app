using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dan's Grade Book");
            // handling the event
            book.GradeAdded += OnGradeAdded;

            while (true)
            {
                Console.WriteLine("Please add a grade, or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var stats = book.GetStats();

            Console.WriteLine($"For the book names: {book.Name}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The average grade is: {stats.Average:N2}");
            Console.WriteLine($"The grade is: {stats.Letter}");

            static void OnGradeAdded(object sender, EventArgs e)
            {
                Console.WriteLine($"A new grade was added");
            }
        }
    }
}