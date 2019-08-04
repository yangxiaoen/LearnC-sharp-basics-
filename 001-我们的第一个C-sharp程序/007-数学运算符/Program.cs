using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int result;
            result = num1 + num2;
            int res1 = num1 - num2;
            int res2 = num1 * num2;
            int res3 = num1 / num2;
            Console.WriteLine("加法的效果{0}，减法的效果{1}，乘法的效果{2}，除法的效果{3}", result, res1, res2, res3);
            Console.ReadKey();
        }
    }
}
