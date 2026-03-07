using System;
using System.Collections.Generic;
using System.Text;

namespace Next_Consonant_or_vowel
{
    internal class UserProgramCode
    {
        public static string nextString(string input1)
        {
            string vowels = "aeiou";
            string VOWELS = "AEIOU";
            string result = "";

            foreach (char ch in input1)
            {
                // Business rule 1
                if (!char.IsLetter(ch))
                    return "Invalid input";

                // lowercase vowel
                if (vowels.Contains(ch))
                {
                    int idx = vowels.IndexOf(ch);
                    result += (idx == 4) ? 'a' : vowels[idx + 1];
                }
                // uppercase vowel
                else if (VOWELS.Contains(ch))
                {
                    int idx = VOWELS.IndexOf(ch);
                    result += (idx == 4) ? 'A' : VOWELS[idx + 1];
                }
                // lowercase consonant
                else if (char.IsLower(ch))
                {
                    result += 'a';
                }
                // uppercase consonant
                else
                {
                    result += 'A';
                }
            }

            return result;
        }
    }
}
