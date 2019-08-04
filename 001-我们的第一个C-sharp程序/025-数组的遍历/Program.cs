using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 0, 1, 25, 45, 1, 4, 52, 45, 2452, 5 };
            //scores.Length//可以获取数组的长度
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]) ;
            //}

            //int i = 0;
            //while (i < scores.Length)
            //{
            //    Console.WriteLine(scores[i]);
            //    i++;
            //}

            foreach(int temp in scores)//foreach会依次取到数组中的值，然后赋值给temp,然后执行循环体
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
