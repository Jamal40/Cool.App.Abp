using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cool.App.Services;

internal class ExceptionsHnadler
{
    public void HandleException(
    Dictionary<string, string> placeholders,
    string errorCode)
    {
        switch (errorCode)
        {
            case "ERR-001":
                string formattedMessage = string.Format((errorCode),
                    placeholders["name"], placeholders["age"]);
                throw new Exception(formattedMessage);

            case "ERR-002":
                string formattedMessage2 = string.Format((errorCode),
                    placeholders["phonenumber"]);
                throw new Exception(formattedMessage2);

            case "ERR-003":
                string formattedMessage3 = string.Format((errorCode),
                    placeholders["username"]);
                throw new Exception(formattedMessage3);
            
            case "ERR-004":
                string formattedMessage4 = string.Format((errorCode),
                    placeholders["username"]);
                throw new Exception(formattedMessage4);

            default:
                // do something
                break;
        }
    }
}

// &, &, &,    [a, b, c]