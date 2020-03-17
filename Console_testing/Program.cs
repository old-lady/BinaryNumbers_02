using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BinaryNumbers_Lib;
using static BinaryNumbers_Lib.Opgave01;

namespace Console_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = "Hello world";
            string hexLetter = ToHex(letter.ToCharArray());
            hexLetter = letter.StringToHexString();

            Console.WriteLine(hexLetter);

            string transLetter = Translator.HexStringToString(hexLetter);

            Console.WriteLine(transLetter);


            Console.ReadKey();
        }
    }
}
