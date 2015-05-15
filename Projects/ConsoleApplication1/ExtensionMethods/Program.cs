using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a test string: ");
            string test = Console.ReadLine();
            Console.WriteLine(test.IsNumeric() ? "It's a number." : "It's not a number.");
            Console.ReadKey();
        }
    }

    public static class MyExtensionMethods
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}
