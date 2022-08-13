using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Task1
{
    internal static class StringExtension
    {
        public static string CutString(string text) => $"{text[..9]}...";

        public static int DiffConverter(string text)
        {
            return text switch
            {
                "TRUE" => 1,
                "FALSE" => 0,
                _ => throw new ArgumentException("Argument is not TRUE or FALSE"),
            };
        }
    }
}
