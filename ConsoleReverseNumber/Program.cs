using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(num));
        }
        static int ReverseNumber(int num)
        {
            int i = 0;
            while (num > 0)
            {
                i = i*10 + num % 10;
                num /= 10;
            }
            return i;
        }
    }
}
