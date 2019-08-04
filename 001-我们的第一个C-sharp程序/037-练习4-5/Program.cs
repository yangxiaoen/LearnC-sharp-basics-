using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_练习4_5
{
    class Program
    {
        static void JieCheng(int num)
        {
            int count = 0;
            int temp = 1;
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    temp *= j;                  
                }
                count += temp;
                temp = 1;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            // 6，题目：求1 + 2!+3!+...+ 20!的和 ?
            JieCheng(20);
            Console.ReadKey();
        }
    }
}
