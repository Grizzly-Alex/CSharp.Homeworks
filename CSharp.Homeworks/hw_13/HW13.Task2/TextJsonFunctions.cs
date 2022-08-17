using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HW13.Task2
{
    internal static class TextJsonFunctions
    {
        public static string TextSerialize(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}