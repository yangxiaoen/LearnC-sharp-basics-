using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_获取键盘的字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //Console.WriteLine(str);

            string str1 = "123";
            int num = Convert.ToInt32(str1);
            num++;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
