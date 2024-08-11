
using System;
namespace BlazorExercise.Exceptions
{
	
        [Serializable]
        public class InvalidFormatException : Exception
        {

            public InvalidFormatException() { }
            public InvalidFormatException(string message)
            : base(message)
            {
            }
        }
    
}

