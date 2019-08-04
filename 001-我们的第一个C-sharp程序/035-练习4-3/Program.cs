using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_练习4_3
{
    class Program
    {
        static void GongYueShu(int num1, int num2)
        {
            int  gongyueshu = 1;
            int x = num1 > num2 ? num2 : num1;
            //Console.Write("x"+x);
            for (int i = 1; i <= x; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gongyueshu = i;
                    //Console.Write(gongyueshu+"公约数");
                }
            }
            Console.WriteLine("公约数为" +gongyueshu);
        }
        static void GongBeiShu(int num1, int num2)
        {
            int da = num1 > num2 ? num1 : num2;
            //Console.WriteLine(da);
            int xiao = num1 < num2 ? num1 : num2;
           // Console.WriteLine(xiao);
            if (num1 % num2 == 0)
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }
            else
            {
                for (int i = 2; i <= xiao; i++)
                {
                    int gongbeishu = da * i;
                    if (gongbeishu % xiao == 0)
                    {
                        Console.WriteLine(gongbeishu);
                        break;
                    }
                }
            }
           

        }
        static void Main(string[] args)
        {
            //4，输入两个正整数m和n，求其最大公约数和最小公倍数。
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            GongBeiShu(num1, num2);
            GongYueShu(num1, num2);
            Console.ReadKey();
        }
    }
}
