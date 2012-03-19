using System;
using System.Collections.Generic;

namespace RandomStringGenerator
{
    public partial class StringGenerator
    {
        public int MinUpperCaseChars { get; set; }

        public int MinLowerCaseChars { get; set; }

        public int MinNumericChars { get; set; }

        public int MinSpecialChars { get; set; }

        public CharType FillRest { get; set; }

        public StringGenerator()
        {
        }

        public StringGenerator(int minUpperCaseChars, int minLowerCaseChars, 
            int minNumericChars, int minSpecialChars, CharType fillRest)
        {
            this.MinUpperCaseChars = minUpperCaseChars;
            this.MinLowerCaseChars = minLowerCaseChars;
            this.MinNumericChars = minNumericChars;
            this.MinSpecialChars = minSpecialChars;
            this.FillRest = fillRest;
        }

        public string GenerateString(int length)
        {
            int sum = this.MinUpperCaseChars + this.MinLowerCaseChars +
                this.MinNumericChars + this.MinSpecialChars;

            if (length < sum)
                throw new ArgumentException("length parameter must be valid!");

            List<char> chars = new List<char>();

            if (this.MinUpperCaseChars > 0)
            {
                chars.AddRange(GetUpperCaseChars(this.MinUpperCaseChars));
            }

            if (this.MinLowerCaseChars > 0)
            {
                chars.AddRange(GetLowerCaseChars(this.MinLowerCaseChars));
            }

            if (this.MinNumericChars > 0)
            {
                chars.AddRange(GetNumericChars(this.MinNumericChars));
            }

            if (this.MinSpecialChars > 0)
            {
                chars.AddRange(GetSpecialChars(this.MinSpecialChars));
            }

            int restLength = length - chars.Count;

            switch (this.FillRest)
            {
                case (CharType.UpperCase):
                    chars.AddRange(GetUpperCaseChars(restLength));
                    break;
                case (CharType.LowerCase):
                    chars.AddRange(GetLowerCaseChars(restLength));
                    break;
                case CharType.Numeric:
                    chars.AddRange(GetNumericChars(restLength));
                    break;
                case CharType.Special:
                    chars.AddRange(GetSpecialChars(restLength));
                    break;
                default:
                    chars.AddRange(GetLowerCaseChars(restLength));
                    break;
            }

            return GenerateStringFromList(chars);
        }
    }
}
