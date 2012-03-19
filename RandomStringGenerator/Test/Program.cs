using System;
using RandomStringGenerator;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Random String Generator for .NET";

            StringGenerator generator = new StringGenerator();

            generator.MinLowerCaseChars = 2;
            generator.MinUpperCaseChars = 1;
            generator.MinNumericChars = 3;
            generator.MinSpecialChars = 2;
            generator.FillRest = CharType.LowerCase;

            Console.WriteLine(string.Format("Random string generated: {0}", generator.GenerateString(10)));

            Console.ReadLine();
        }
    }
}
