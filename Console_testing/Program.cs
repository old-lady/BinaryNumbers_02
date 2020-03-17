using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BinaryNumbers_Lib;

namespace Console_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Julia";
            string hexTest = Translator.ToHex(test.ToCharArray());
            Console.WriteLine(hexTest);
            byte[] byteTest = Translator.HexToBytesV2(hexTest);
            hexTest = Translator.HexStringToString(hexTest);
            Console.WriteLine(hexTest);



            Console.ReadKey();
        }
    }
}
