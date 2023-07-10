using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Decorator
{
    public class CustomExceptionHandler
    {
        public static void HandleException(Exception exe)
        {
            throw new CustomException("Error Occured");
        }
    }
}
