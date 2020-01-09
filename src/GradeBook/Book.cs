using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // this is how we generate a constructor in c#
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine($"A new added grade: {grade:N2}");
        }

        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                // log hightest grades
                result.High = Math.Max(grade, result.High);
                // log lowest grades
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;

            }
            result.Average /= grades.Count;

            return result;
        }

        // its no longer a variable it is now called field in c#
        private List<double> grades;
        public string Name;
    }
}