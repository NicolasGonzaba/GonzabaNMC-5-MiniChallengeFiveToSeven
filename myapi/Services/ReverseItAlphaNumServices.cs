using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class ReverseItAlphaNumServices
    {
        public string ReverseItAlphaNum(string LettersAndDigits)
        {
            string ReversedLettersAndDigits = "";

            bool hasLetter = LettersAndDigits.Any(char.IsLetter);
            bool hasNumber = LettersAndDigits.Any(char.IsDigit);

            if (hasNumber && hasLetter)
            {
                for (int i = LettersAndDigits.Length - 1; i >= 0; i--)
                {
                    ReversedLettersAndDigits += LettersAndDigits[i].ToString();
                }
                return $"The reverse of {LettersAndDigits} is {ReversedLettersAndDigits}.";
            }
            else { return "Please enter a response that has both numbers and letters."; }
        }
    }
}