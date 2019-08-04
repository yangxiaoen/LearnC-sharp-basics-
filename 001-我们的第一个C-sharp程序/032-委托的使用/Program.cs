using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_委托的使用
{
    public delegate double MyDelegate(double param1, double param2);
    class Program
    {
        static double Multipy(double param1,double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1,double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            MyDelegate de;
            de = Multipy;
            Console.WriteLine(de(2.1, 3.2));
            de = Divide;
            Console.WriteLine(de(30.2, 5.2));
            Console.ReadKey();
        }
    }
}
