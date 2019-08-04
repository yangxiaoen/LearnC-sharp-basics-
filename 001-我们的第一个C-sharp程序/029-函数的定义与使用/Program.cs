using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_函数的定义与使用
{
    class Program
    {
        static int[] GetDivisor(int number)
        {
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] array = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }
        static int Max(int[] number)
        {
            int max = number[0];
            for(int i = 1; i < number.Length; i++)
            {
                if (max < number[i])
                {
                    max = number[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] intArray = GetDivisor(num);
            //foreach(int temp in intArray)
            //{
            //    Console.Write(temp + " ");
            //}
            int[] num = { 1, 15, 24, 3, 4, 5, 6, 54, 4 };
            int max=Max(num);
            Console.Write(max);
            Console.ReadKey();
        }
    }
}
