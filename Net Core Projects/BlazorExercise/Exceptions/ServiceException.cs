﻿using System;
namespace BlazorExercise.Exceptions
{
    [Serializable]
    public class ServiceException : Exception
    {
        public ServiceException()
        {

        }
        public ServiceException(string message) : base(message)
        {

        }
    }
}

