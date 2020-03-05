using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Tests.Exceptions
{
   public class InvalidCredentialsException:Exception
    {
        public string Messages = "Please enter valid usename & password";

        public InvalidCredentialsException(string message)
        {
            Messages = message;
        }
    }
}