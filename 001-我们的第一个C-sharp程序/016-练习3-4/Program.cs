using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_练习3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个三位数的数字");
            string str1 = Console.ReadLine();
            int num = Convert.ToInt32(str1);
            int num1 = num / 100;
            int num2 = (num / 10) - num1*10;
            int num3 = num % 10;
            Console.WriteLine("新的数字为" + num3 + num2 + num1);
            Console.ReadKey();
        }
    }
}
