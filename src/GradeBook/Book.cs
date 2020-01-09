using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // this is how we generate a constructor in c#
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine($"{name}'s new added grades is: {grade:N2}");
        }

        public void ShowStats()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                // log hightest grades
                highGrade = Math.Max(number, highGrade);
                result += number;

                // log lowest grades
                lowGrade = Math.Min(number, lowGrade);
            }
            result /= grades.Count;
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The average grade is: {result:N2}");
        }

        // its no longer a variable it is now called field in c#
        private List<double> grades;
        private string name;
    }
}