using System;
using System.Collections.Generic;

namespace GradeBook
{
    // To implement an interface we can add a comma and than the interface
    // To inherent a class we just add: and the name of the class
    public class InMemoryBook : Book
    {
        // this is how we generate a constructor in c#
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;

            }
        }

        public override Stats GetStats()
        {
            var result = new Stats();

            for (var index = 1; index < grades.Count; index +=1)
            {
                result.Add(grades[index]);
            }
            
            return result;
        }

        // its no longer a variable it is now called field in c#
        private List<double> grades;

        public override event GradeAddedDelegate GradeAdded;
    }
}