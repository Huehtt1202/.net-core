using System;
namespace MyExceptions
{
    public class EmptyException : Exception
    {
        public EmptyException() : base("Field is not empty") { }
    }
    public class IncorrectFomatException : Exception
    {
        public IncorrectFomatException() : base("Data is not incorrect format")
        {

        }
    }
}
