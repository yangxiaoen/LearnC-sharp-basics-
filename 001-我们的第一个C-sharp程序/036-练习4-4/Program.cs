using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_练习4_4
{
    class Program
    {
        static void Ball(double num,int num2)
        {
            double luCheng = 0;
            double lastHight = num;
            for(int i = 0; i < num2; i++)
            {
                luCheng += lastHight;
                lastHight /=  2;
                //Console.WriteLine(lastHight);
                if (i == num2-1)
                {
                    Console.WriteLine("第" + num2 + "次反弹" + lastHight/2 + "米");
                }
            }
            Console.WriteLine("共经过" + luCheng + "米");
           
        }
        static void Main(string[] args)
        {
            //5，一球从100米高度自由落下，每次落地后反跳回原高度的一半；再落下，求它在第10次落地时，共经过多少米？第10次反弹多高？
            Ball(100,10);
            Console.ReadKey();
        }
    }
}
