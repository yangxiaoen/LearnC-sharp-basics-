using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            //接受用户输入
            string str1 = Console.ReadLine();
            Console.WriteLine("请输入第二个数字");
            string str2 = Console.ReadLine();
            //字符串转换为整形
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);
            //求和并输出
            Console.Write("二个数字的和为");
            Console.WriteLine(num1 + num2);
            Console.ReadKey();
        }
    }
}
