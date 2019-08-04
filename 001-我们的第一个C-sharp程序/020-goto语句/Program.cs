using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 50;
            goto mylable;//代码运行直接跳转到标签那执行
            myInteger++;
            mylable: Console.WriteLine(myInteger);//mylable为标签（一定要加上冒号）
            Console.ReadKey();
        }
    }
}
