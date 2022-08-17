using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace HW13.Task2
{
    internal static class NewtonFunctions
    {
        public static string NewtonSerialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }
}