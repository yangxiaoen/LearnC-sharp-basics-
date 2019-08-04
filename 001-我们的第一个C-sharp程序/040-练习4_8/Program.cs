using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_练习4_8
{
    class Program
    {
        static int SiSheWuRu()
        {
            Console.WriteLine("请输入一个小数，我们将进行四舍五入计算");
            double num = Convert.ToDouble(Console.ReadLine());
            if ((num * 10) % 10 >= 5)
            {
                return (int)++num;
            }else
            {
                return (int)num;
            }
        }
        static void Main(string[] args)
        {
            //9，编一个程序，输入一个正数，对该数进行四舍五入到个位数的运算。
            //例如，实数12.56经过四舍五入运算，得到结果13；而12.46经过四舍五入运算，得到结果12
            //int num=SiSheWuRu();
            //Console.WriteLine(num);
            //Console.ReadKey();
            ////方法二
            //double number = Convert.ToDouble(Console.ReadLine());
            //int numberInteger = (int)number / 1;
            //double numberDouble = number - numberInteger;
            //if (numberDouble >= 0.5f)
            //{
            //    numberInteger++;
            //}
            //Console.WriteLine(numberInteger);
            //Console.ReadKey();
            //方法三
            double number = Convert.ToDouble(Console.ReadLine());
            int res =(int) (number + 0.5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
