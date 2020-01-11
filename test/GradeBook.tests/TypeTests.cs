using System;
using Xunit;

namespace GradeBook.tests
{
    public delegate string WriteLogDelegate(string logMessage);
    /*
    // Guideline to writing good unit tests:
    // arrange the test
    // act - the actual actions
    // assert - the values that are computed in the act section
   */
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount ;

            var result = log("Hi, I am a log message!");

            Assert.Equal(3, count);
        }

        private string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }
        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }

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
            var book1 = GetBook("My InMemoryBook");
            GetBookSetName(book1, "New InMemoryBook Name!");

            Assert.Equal("My InMemoryBook", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("My InMemoryBook");
            GetBookSetName(book1, "New InMemoryBook Name!");

            Assert.Equal("My InMemoryBook", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("My InMemoryBook");
            SetName(book1, "New InMemoryBook Name!");

            Assert.Equal("New InMemoryBook Name!", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("My InMemoryBook");
            var book2 = GetBook("My Other InMemoryBook");

            //assert
            Assert.Equal("My InMemoryBook", book1.Name);
            Assert.Equal("My Other InMemoryBook", book2.Name);
            Assert.NotSame(book1, book2);
        }


        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("InMemoryBook 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}

