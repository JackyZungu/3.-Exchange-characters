using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exchange_characters
{
    public class Program
    {
        public static string ExchangeCharacters(string str)
        {
            if (str.Length <= 1)
            {
                return str;
            }

            char firstCharacter = str[0];
            char lastCharacter = str[str.Length - 1];

            string newString = str.Substring(1, str.Length - 2);

            return lastCharacter + newString + firstCharacter;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("This program exchange the first and last characters");
            string[] letters = { " abcd", " a", " xy" };

            foreach (string letter in letters)
            {
                string newString = ExchangeCharacters(letter);
                Console.WriteLine($"{newString}");
            }
            Console.ReadLine();
        }
    }

}
