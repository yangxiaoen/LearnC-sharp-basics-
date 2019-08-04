using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_练习3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine("请输入另一个数字");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("交换后的num1为" + num1 + "\t num2为" + num2);
            Console.ReadKey();
        }
    }
}
