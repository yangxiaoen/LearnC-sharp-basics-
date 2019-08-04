using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_练习3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个圆形的半径");
            string str =Console.ReadLine();
            int num = Convert.ToInt32(str);
            double area = num * num * 3.1415926;
            double zhouchang = 2 * num * 3.1415926;
            Console.WriteLine("圆的面积是" + area + "\n圆的周长是" + zhouchang);
            Console.ReadKey();
        }
    }
}
