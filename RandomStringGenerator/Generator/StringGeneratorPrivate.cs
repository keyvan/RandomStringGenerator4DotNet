using System;
using System.Collections.Generic;

namespace RandomStringGenerator
{
    public partial class StringGenerator
    {
        private List<char> GetUpperCaseChars(int count)
        {
            List<char> result = new List<char>();

            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                result.Add(Char.ToUpper(Convert.ToChar(random.Next(65, 90))));
            }

            return result;
        }

        private List<char> GetLowerCaseChars(int count)
        {
            List<char> result = new List<char>();

            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                result.Add(Char.ToLower(Convert.ToChar(random.Next(97, 122))));
            }

            return result;
        }

        private List<char> GetNumericChars(int count)
        {
            List<char> result = new List<char>();

            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                result.Add(Convert.ToChar(random.Next(0, 9).ToString()));
            }

            return result;
        }

        private List<char> GetSpecialChars(int count)
        {
            List<char> result = new List<char>();

            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                result.Add(Char.ToLower(Convert.ToChar(random.Next(35, 38))));
            }

            return result;
        }

        private string GenerateStringFromList(List<char> chars)
        {
            string result = string.Empty;

            Random random = new Random();

            while (chars.Count > 0)
            {
                int randomIndex = random.Next(0, chars.Count);
                result += chars[randomIndex];
                chars.RemoveAt(randomIndex);
            }

            return result;
        }
    }
}
