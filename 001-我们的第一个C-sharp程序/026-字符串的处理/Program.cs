using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_字符串的处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "www.baidu.com";
            //str.Length//获取字符串长度
            //for(int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            string res = str.ToLower();
            res = str.ToUpper();
            Console.WriteLine(str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
