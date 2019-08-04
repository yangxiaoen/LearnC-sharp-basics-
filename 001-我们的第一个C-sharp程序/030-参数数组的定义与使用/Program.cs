using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_参数数组的定义与使用
{
    class Program
    {
        static int Max(params int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Max(12, 5, 4, 5, 78, 48, 54, 21, 12); 
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
