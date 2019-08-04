using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_赋值运算
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 35;
            num += 12;
            num -= 12;
            num *= 2;
            num /= 2;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
