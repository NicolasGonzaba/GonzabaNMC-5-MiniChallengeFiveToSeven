using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class ReverseItNumServices
    {
        public string ReverseItNum(int digits)
        {
            string reverseDigits="";
             for (int i =digits.ToString().Length - 1; i >= 0; i--)
                {
                    reverseDigits +=digits.ToString()[i];
                }
                return $"The reverse of {digits} is {reverseDigits}.";
        }
    }
}