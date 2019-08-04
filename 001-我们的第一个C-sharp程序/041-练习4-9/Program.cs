using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_练习4_9
{
    class Program
    {
        static int QiuZuiDaKZhi(int num)
        {
            int j = 0;
            int i = 1;
            
            for(i=0; j < num; )
            {
                i++;
                j += i * i;
            }
            return i-1;
        }
        static void Main(string[] args)
        {
            //有关系式1 * 1 + 2 * 2 + 3 * 3 +...+ k * k < 2000,编一个程序，求出满足此关系式的k的最大值
            //int num = QiuZuiDaKZhi(2000);
            //Console.WriteLine(num);
            //方法二
            int sum = 0;
            int k = 0;
            while (sum < 2000)
            {
                k++;
                sum += k * k;
            }
            Console.WriteLine(k-1);
            Console.ReadKey();

        }
    }
}
