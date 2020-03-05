using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Tests.Exceptions
{
   public class ImportDataFormat :Exception
    {
        public string Messages = "Need to be in Excel format";

        public ImportDataFormat(string message)
        {
            Messages = message;
        }

    }
}
