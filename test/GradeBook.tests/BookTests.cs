using System;
using Xunit;

namespace GradeBook.tests
{
    /*
    // Guideline to writing good unit tests:
    // arrange the test
    // act - the actual actions
    // assert - the values that are computed in the act section
   */
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book(" ");
            book.AddGrade(85.6);
            book.AddGrade(90.6);
            book.AddGrade(87.3);
            
            // act
            var result = book.GetStats();

            //assert
            Assert.Equal(87.8,result.Average, 1);
            Assert.Equal(90.6, result.High, 1);
            Assert.Equal(85.6, result.Low, 1);
        }
    }
}

