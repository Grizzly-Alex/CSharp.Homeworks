using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace HW15.Task2
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class CreditCardAttribute: Attribute
    {
        public bool IsValidCard(string numCard)
        {
            if (string.IsNullOrEmpty(numCard))
            {
                return true;
            }
            
            Regex regN = new(@"\d{4}([\s-]\d{4}){3}");
            Regex regL = new(@"\d{16}");
            if (regN.Match(numCard).Success || regL.Match(numCard).Success)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }      
    }
}