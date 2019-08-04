using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_练习3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个梯形的上底");
            string str1 = Console.ReadLine();
            int num = Convert.ToInt32(str1);
            Console.WriteLine("请输入一个梯形的下底");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            Console.WriteLine("请输入一个梯形的高");
            string str3 = Console.ReadLine();
            int num3 = Convert.ToInt32(str3);
            int area = (num + num2) * num3 / 2;
            Console.WriteLine("梯形的面积为" + area);
            Console.ReadKey();
        }
    }
}
