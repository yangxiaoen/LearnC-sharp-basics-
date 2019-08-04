using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4_2
{
    class Program
    {
        private static void FenJieZhiYinShu()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int res = num;
            List<int> a = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    num /= i;
                    a.Add(i);
                    i--;//防止一个质因数只出现一次
                }
            }
            Console.WriteLine("{0}={1}", res, string.Join("*", a.ToArray()));
        }
        static void Main(string[] args)
        {
            //3，将一个正整数分解质因数。例如：输入90,打印出90=2*3*3*5。测试数据有多组
            FenJieZhiYinShu();
            Console.ReadKey();
        }
    }
}
