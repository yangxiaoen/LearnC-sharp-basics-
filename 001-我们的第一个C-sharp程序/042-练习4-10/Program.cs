using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_练习4_10
{
    class Program
    {
        static void MaiJi(int num)
        {
            for(int i = 0; i < num / 5; i++)
            {
                for(int j = 0; j < (num - 5 * i) / 3; j++)
                {
                    int xiaoJi = (num - 5 * i - 3 * j) * 3;
                    if (xiaoJi + i + j == num)
                    {
                        Console.WriteLine("公鸡" + i + "只  母鸡" + j + "只 小鸡" + xiaoJi + "只");
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            //11，编一个程序，解决百钱买百鸡问题。
            //某人有100元钱，要买100只鸡。公鸡5元钱一只，母鸡3元钱一只，小鸡一元钱3只。
            //问可买到公鸡，母鸡，小鸡各为多少只。把所有的可能性打印出来。
            MaiJi(100);
            Console.ReadKey();
        }
    }
}
