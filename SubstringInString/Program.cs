using System.Data.SqlTypes;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace SubstringInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string initialText = "Ana are mere. Merele sunt rosii.";
            Console.WriteLine(initialText);

            string subString;
            Console.Write("Introdu substringul: ");
            subString = Console.ReadLine();

            int count = Regex.Matches(initialText.ToLower(), subString).Count();

            Console.WriteLine("Substringul a aparut de " + count + " ori in text");

        }
    }
}