using System.IO;
using System;

namespace GradeBook
{
    public class DiskBook : Book, IBook
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            // when invoking using statement  Provides a convenient syntax that ensures the correct use of IDisposable objects. Meaning, since we are unaware WHEN will the garbage collector will free us the resources, we are making sure that .NET will free it when we are reaching the end of the lines inside the using statement.
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Stats GetStats()
        {
            var result = new Stats();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while(line!= null ) {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                } 
            }
            return result;
        }
    }
}