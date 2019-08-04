using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_练习合集
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.比较大小
            //int num = 10;
            //int maxNum = num;
            //int minNum = num;
            //int num1 =0;
            //int count = 1;
            //while (count <= 3)
            //{
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //    if (num1 > maxNum)
            //    {
            //        maxNum = num1;
            //    }
            //    if (num1 < minNum)
            //    {
            //        minNum = num1;
            //    }
            //    count++;
            //}
            //Console.WriteLine("最大值为" + maxNum);
            //Console.WriteLine("最小值为" + minNum);
            //Console.ReadKey();

            //2.让用户输入两个整数，然后再输入0-3之间的一个数，0代表加法，1代表减法，2代表乘法，3代表除法,计算这两个数字的结果
            //int num1, num2,area=0;
            //Console.WriteLine("请输入两个整数");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("再输入0-3之间的一个数，0代表加法，1代表减法，2代表乘法，3代表除法");
            //string str = Console.ReadLine();
            //if (str == "0") //这里可以使用switch语句实现
            //{
            //    area = num1 + num2;
            //}
            //else if (str == "1")
            //{
            //    area = num1 - num2;
            //}else if (str == "2")
            //{
            //    area = num1 * num2;
            //}else if (str == "3")
            //{
            //    area = num1 / num2;
            //}
            //Console.WriteLine("结果为" + area);
            //Console.ReadKey();


            //3.求出1~1000之间的所有能被7整除的数，并计算和输出每5个的和。
            //int count = 0;
            //int sum = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        sum += i;
            //        if (count == 5)
            //        {
            //            Console.WriteLine(sum);
            //            sum = 0;
            //            count = 0;
            //        }
            //    }
            //}
            //Console.ReadKey();

            //4.编写一个控制台程序，分别输出1~100之间的平方、平方根。
            //for(int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i * i);
            //}
            //Console.ReadKey();

            //5.兔子繁殖问题。设有一对新生的兔子，从第三个月开始他们每个月都生一对兔子，
            //新生的兔子从第三个月开始又每个月生一对兔子。按此规律，并假定兔子没有死亡，
            //20个月后共有多少个兔子？要求编写为控制台程序。
            //int sum = 1;
            //for(int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum = sum *2;
            //    }
            //}
            //Console.WriteLine("共有兔子" + sum + "对");
            //Console.ReadKey();

            //6.编程输出1~100中能被3整除但不能被5整除的数,并统计有多少个这样的数。
            //int count = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        if (i % 5 != 0)
            //        {
            //            Console.WriteLine(i + "   ");
            //            count++;
            //        }
            //    }
            //}
            //Console.ReadKey();

            //7.编程输出1000以内的所有素数 //着重听
            //for (int i = 2; i <= 1000; i++)
            //{
            //    bool zhishu = true;
            //    for (int j = 2; j <= i -1; j++)
            //    {

            //        if (i % j == 0)
            //        {
            //            zhishu = false;
            //            break;
            //        }
            //    }
            //    if (zhishu)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadKey();

            //8.编程输出九九乘法表。
            //for(int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + "*" + j + "=" + i * j + "  ");
            //        if (i == j)
            //        {
            //            Console.WriteLine("\n");
            //        }
            //    }
            //}
            //Console.ReadKey();

            //9.编写一个掷筛子100次的程序，并打印出各种点数的出现次数。
            //Random random = new Random();//创建一个可以生成随机数的random

            //int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    int num = random.Next(1, 7);//包含最小值不包含最大值
            //    if (num == 1)
            //        num1++;
            //    if (num == 2)
            //        num2++;
            //    if (num == 3)
            //        num3++;
            //    if (num == 4)
            //        num4++;
            //    if (num == 5)
            //        num5++;
            //    if (num == 6)
            //        num6++;
            //}
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);
            //Console.WriteLine(num6);
            //Console.ReadKey();


            //10.一个控制台应用程序，输出1~5的平方值，要求：用for语句实现。用while语句实现。用do-while语句实现。
            //用for语句实现
            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i * i);
            //}
            //Console.ReadKey();

            //用while语句实现
            //int i = 1;
            //while(i <= 5){
            //    Console.WriteLine(i * i);
            //    i++;
            //}
            //Console.ReadKey();

            //用do-while语句实现
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i * i);
            //    i++;
            //} while (i <= 5);
            //Console.ReadKey();

            //11.一个控制台应用程序,要求用户输入5个大写字母，如果用户输入的信息不满足要求，提示帮助信息并要求重新输入。
            //    while (true) { 
            //    string str = Console.ReadLine();
            //    bool istrue = true;
            //    for (int i = 0; i <5; i++)
            //    {
            //        if (str[i] <= 'Z' && str[i] >= 'A')
            //        {

            //        }
            //        else
            //        {
            //            istrue = false;

            //            break;
            //        }
            //    }
            //    if (istrue==false)
            //    {
            //        Console.WriteLine("您输入的有误请重新输入");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            //12.一个控制台应用程序，要求完成写列功能。
            //1）接收一个整数n。
            //2）如果接收的值n为正数，输出1~n间的全部整数。
            //3）如果接收的值n为负值，用break或者return退出程序。
            //4）如何n为0的话 转到1继续接收下一个整数。
            //while (true) { 
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 0)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else if (num < 0)
            //{
            //    return;
            //}
            //}
            //Console.ReadKey();

            //13.一个控制台应用程序，求1000之内的所有“完数”。所谓“完数”是指一个数恰好等于它的所有因子之和。例如6是完数，因为6=1+2+3。
            
            for(int i = 1; i <= 1000; i++)
            {
                int sum = 1;
                for (int j = 2; j <i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i + "是完数");
                }
            }
            Console.ReadKey();
        }
    }
}
