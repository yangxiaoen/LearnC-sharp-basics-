using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4_1
{
    class Program
    {
        static int DiGui(int num)
        {
            if (num ==0)//这两个是结束函数递归的条件
            {
                return 2;
            }
            if (num == 1)
            {
                return 3;
            }
            return DiGui(num - 1) + DiGui(num - 2);//函数调用自身 递归调用
        }
        static void Main(string[] args)
        {
            //2，f(n)=f(n-1)+f(n-2) f(0)=2 f(1)=3 ,用程序求得f(40)
            int res = DiGui(40);
            Console.WriteLine(res);
            int res2 = DiGui(2);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
