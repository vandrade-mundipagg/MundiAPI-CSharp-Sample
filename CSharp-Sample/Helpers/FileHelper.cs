using MundiAPI.PCL.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Helpers
{
    internal static class FileHelper
    {

        private static readonly string filePath = @"C:\Users\andra\Desktop\SDKs\CSharp\Responses";

        internal static void SaveResponse(object response, string method)
        {
            var fileName = $"{DateTime.UtcNow.ToString("yyyyMMddTHHddss")} - RESPONSE {method}.txt";

            var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);

            File.AppendAllText($@"{filePath}\{fileName}", responseJson);
        }

        internal static void SaveApiError(ErrorException e, string method)
        {
            var fileName = $"{DateTime.UtcNow.ToString("yyyyMMddTHHmmss")} - ERROREXCEPTION {method}.txt";

            var error = new
            {
                Message = e.Message,
                Errors = e.Errors
            };

            var json = JsonConvert.SerializeObject(error, Formatting.Indented);

            File.AppendAllText($@"{filePath}\{fileName}", json);
        }

        internal static void SaveException(Exception e, string method)
        {
            var fileName = $"{DateTime.UtcNow.ToString("yyyyMMddTHHddss")} - UNKNOWNEXCEPTION {method}.txt";


            var exception = new
            {
                Message = e.Message,
                StackTrace = e.StackTrace,
                InnerException = e.InnerException
            };

            var json = JsonConvert.SerializeObject(exception, Formatting.Indented);

            File.AppendAllText($@"{filePath}\{fileName}", json);
        }

    }
}
