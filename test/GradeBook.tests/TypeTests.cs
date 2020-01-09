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
    public class TypeTests
    {

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            string name = "Kyle";
            name = MakeUpperCase(name);

            Assert.Equal("KYLE", name);
        }

        private string MakeUpperCase(string param)
        {
            return param.ToUpper();
        }

        [Fact]
        public void getInt()
        {
            // shows pass by reference
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByReference()
        {
            var book1 = GetBook("My Book");
            GetBookSetName(book1, "New Book Name!");

            Assert.Equal("My Book", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("My Book");
            GetBookSetName(book1, "New Book Name!");

            Assert.Equal("My Book", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("My Book");
            SetName(book1, "New Book Name!");

            Assert.Equal("New Book Name!", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("My Book");
            var book2 = GetBook("My Other Book");

            //assert
            Assert.Equal("My Book", book1.Name);
            Assert.Equal("My Other Book", book2.Name);
            Assert.NotSame(book1, book2);
        }


        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

