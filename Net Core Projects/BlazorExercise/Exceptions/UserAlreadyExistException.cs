using System;
namespace BlazorExercise.Exceptions
{
    [Serializable]
    public class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException()
        {

        }
        public UserAlreadyExistException(string email)
             : base(String.Format("User Already Exist with this email ", email))
        {

        }
    }
}

