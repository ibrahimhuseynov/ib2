using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "azad";
            int count = 21;
            Console.WriteLine(ExtentionMethods.IsOdd(count));
            Console.WriteLine(ExtentionMethods.IsEven(count));
            Console.WriteLine(ExtentionMethods.IsContainsDigit(name));
            Console.WriteLine(ExtentionMethods.ToCapitalize(name));
            Console.WriteLine(ExtentionMethods.GetValueIndexes(name, 'a'));


            Console.ReadLine();
        }
    }
}
