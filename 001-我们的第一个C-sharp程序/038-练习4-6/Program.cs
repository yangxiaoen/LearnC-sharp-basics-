using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_练习4_6
{
    class Program
    {
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * F(n - 1);
        }
        static void Main(string[] args)
        {
            //7，利用递归方法求5!。 f(n)=n*f(n-1)
            //F(5);
            Console.Write(F(5));
            Console.ReadKey();
        }
    }
}
