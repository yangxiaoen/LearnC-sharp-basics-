using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_函数的定义
{
    class Program
    {
        static void Write()
        {
            Console.WriteLine("这是定义了一个函数的方法");
        }
        static int Plus(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Write();
            int sum=Plus(15, 20);
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
