using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_练习3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine("请输入第二个数字");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            Console.WriteLine("请输入第三个数字");
            string str3 = Console.ReadLine();
            int num3 = Convert.ToInt32(str3);
            Console.WriteLine("请输入第四个数字");
            string str4 = Console.ReadLine();
            int num4 = Convert.ToInt32(str4);
            int sum = num1 * num2 * num3 * num4;
            Console.WriteLine("四个数的乘积为" + sum);
            Console.ReadKey();
        }
    }
}
