using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_练习变量合集
{
    class Program
    {
        static void Main(string[] args)
        {
            //1，找出100到999之间的水仙花数；"153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3"
            //for(int i = 100; i < 1000; i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;
            //    if (i == ge * ge * ge + bai * bai * bai + shi * shi * shi)
            //    {
            //        Console.WriteLine(i+"="+ge+"*" + ge + "*" + ge + "+" + shi + "*" + shi + "*" + shi + "+" + bai + "*" + bai + "*" + bai );
            //    }
            //}
            //Console.ReadKey();

            //2，3个可乐瓶可以换一瓶可乐，现在有364瓶可乐。
            //问一共可以喝多少瓶可乐，剩下几个空瓶！
            //int num = 364;
            //int count = 0;
            //int temp = num;
            //while (num > 3)
            //{
            //    count += temp;
            //    temp = num / 3;
            //    num = temp + num % 3;
            //}
            //Console.WriteLine(count);
            //Console.ReadKey();

            //3，猜数字游戏，我有一个数，请您猜猜是多少？
            //请您输入一个0-50之间的数：20（用户输入数字）
            //您猜小了，这个数字比20大：30
            //您猜大了，这个数字比30小：25
            //恭喜您猜对了，这个数字为：25
            //用户猜错了就继续猜，猜对了就停止游戏。
            //bool istrue = true;
            //Random random = new Random();
            //int number = random.Next(1, 50);
            //Console.WriteLine("请您输入一个0-50之间的数");
            //while (istrue)
            //{

            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < number)
            //    {
            //        Console.WriteLine("您猜小了，这个数字比"+num+"大");
            //    }
            //    if (num > number)
            //    {
            //        Console.WriteLine("您猜大了，这个数字比" + num + "小");
            //    }
            //    if (num == number)
            //    {
            //        istrue = false;
            //        Console.WriteLine("恭喜您猜对了，这个数字是" + number);
            //        break;
            //    }
            //}
            //Console.ReadKey();

            //4，编写一个应用程序用来输入的字符串进行加密，对于字母字符串加密规则如下：‘a’→’d’ ‘b’→’e’ ‘w’→’z’ …… 
            //‘x’→’a’ ‘y’→’b’ ‘z’→’c’‘A’→’D’ ‘B’→’E’ ‘W’→’Z’ …… ‘X’→’A’ ‘Y’→’B’ ‘Z’→’C’?对于其他字符，不进行加密。
            //string str = Console.ReadLine();
            //string tempstr = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        int num = (int)str[i];
            //        char temp = (char)(num + 3);
            //        if (temp > 'z')
            //        {
            //            temp =(char) (temp - 'z' + 'a' - 1);
            //        }
            //        tempstr += temp;
            //    }
            //    else if (str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        int num = (int)str[i];
            //        char temp = (char)(num + 3);
            //        if (temp > 'Z')
            //        {
            //            temp = (char)(temp - 'z' + 'a' - 1);
            //        }
            //        tempstr += temp;
            //    }
            //    else
            //    {
            //        tempstr += str[i];
            //    }

            //}
            //Console.Write(tempstr);
            //Console.ReadKey();

            //5.编写一个控制台程序，要求用户输入一组数字用空格间隔，对用户输入的数字从小到大输出。(Array.Sort方法和冒泡排序)
            //string str = Console.ReadLine();
            //string[] stringArray = str.Split(' ');
            //Array.Sort(stringArray);
            //foreach(string temp in stringArray)
            //{
            //    Console.Write(temp);
            //}
            //Console.ReadKey();


            //string str = Console.ReadLine();
            //string[] stringArray = str.Split(' ');
            //int[] numArray = new int[stringArray.Length];
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    int temp = Convert.ToInt32(stringArray[i]);
            //    numArray[i] = temp;
            //}
            //Array.Sort(numArray);//这是快速排序
            /*
             这是冒泡排序 冒泡排序依次比较两位数 前一位比后一位大 则交换 这样一次冒泡排序就能得到一个最大值
             */
            //for(int j = 1; j <=  numArray.Length - 1; j++)
            //{
            //    for (int i = 0; i < stringArray.Length - 1-j+1; i++)
            //    {
            //        if (numArray[i] > numArray[i + 1])
            //        {
            //            int temp = numArray[i + 1];
            //            numArray[i + 1] = numArray[i];
            //            numArray[i] = temp;
            //        }
            //    }
            //}
            //foreach (int temp in numArray)
            //{
            //    Console.Write(temp+" ");
            //}
            //Console.ReadKey();

            /*
            6.喜欢西游记的同学肯定都知道悟空偷吃蟠桃的故事，你们一定都觉得这猴子太闹腾了，其实你们是有所不知：悟空是在研究一个数学问题！
            什么问题？他研究的问题是蟠桃一共有多少个！
            不过，到最后，他还是没能解决这个难题，呵呵^-^
            当时的情况是这样的：
            第一天悟空吃掉桃子总数一半多一个，第二天又将剩下的桃子吃掉一半多一个，以后每天吃掉前一天剩下的一半多一个，
            到第n天准备吃的时候只剩下一个桃子。聪明的你，请帮悟空算一下，他第一天开始吃的时候桃子一共有多少个呢？
            用户输入n的值，计算出来他第一天吃的时候桃子是多少个
             */
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 1; 
            //for (int i = 1; i <num; i++)
            //{
            //    sum = (sum + 1) * 2;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //7.输入n(n<100)个数，找出其中最小的数，将它与最前面的数交换后输出这些数。
            //string str = Console.ReadLine();
            //String[] strArray = str.Split(' ');
            //int[] intArray = new int[strArray.Length];
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    int temp = Convert.ToInt32(strArray[i]);
            //    intArray[i] = temp;
            //}
            //int minNum = intArray[0];
            //int count = 0;
            //for (int j = 0; j < intArray.Length; j++)
            //{
            //    if (minNum > intArray[j])
            //    {
            //        minNum = intArray[j];
            //        count = j;
            //    }
            //}
            //Console.WriteLine(count);
            //int temp1 = intArray[0];
            //intArray[0] = minNum;
            //intArray[count] = temp1;
            //foreach(int temp in intArray)
            //{
            //    Console.Write(temp + " ");
            //}
            //Console.ReadKey();

            //8.有n(n<=100)个整数，已经按照从小到大顺序排列好，现在另外给一个整数x，请将该数插入到序列中，并使新的序列仍然有序。
            //输出新的序列
            //int[] intArray = { 1, 2, 6, 7, 8 };
            //int[] newIntArray = new int[intArray.Length + 1];
            //int x = 3;
            //newIntArray[0] = x;
            //for(int i = 1; i < newIntArray.Length; i++)
            //{
            //    newIntArray[i] = intArray[i - 1];
            //}
            //Array.Sort(newIntArray);
            //foreach(int temp in newIntArray)
            //{
            //    Console.Write(temp + " ");
            //}
            //Console.ReadKey();

            /*9.作为泰课的老师，最盼望的日子就是每月的8号了，因为这一天是发工资的日子，养家糊口就靠它了，呵呵
            但是对于泰课财务处的工作人员来说，这一天则是很忙碌的一天，财务处的小云老师最近就在考虑一个问题：如果每个老师的工资额都知道，
            最少需要准备多少张人民币，才能在给每位老师发工资的时候都不用老师找零呢？
            这里假设老师的工资都是正整数，单位元，人民币一共有100元、50元、10元、5元、2元和1元六种。*/
            //int salary = Convert.ToInt32(Console.ReadLine());
            //int bai, wushi, shi, wu, er, yi;
            //bai = salary / 100;
            //int temp = salary - bai * 100;
            //wushi = temp / 50;
            //temp -= wushi * 50;
            //shi = temp / 10;
            //temp -= shi * 10;
            //wu = temp / 5;
            //temp -= wu * 5;
            //er = temp / 2;
            //temp -=er * 2;
            //yi = temp;
            //Console.WriteLine(bai + "张一百元 " + wushi + " 张五十元  " + shi + "张十元 " + wu + "张五元 " + er + "张二元 " + yi + "张一元 ");
            //Console.ReadKey();

            //10.输入一个字符串，判断其是否是C#的合法标识符。
            //string str = Console.ReadLine();
            //bool istrue = true;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[0] >= '0' && str[0] <= '9')
            //    {
            //        istrue = false;
            //        break;
            //    }
            //    if (str[i] >= '0' && str[i] <= '9' || str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z' || str[i] == '_'|| str[i]=='@')
            //    {
            //        istrue = true;
            //    }
            //    else
            //    {
            //        istrue = false;
            //        break;
            //    }
            //}
            //if (istrue)
            //{
            //    Console.Write("合法");
            //}
            //else
            //{
            //    Console.Write("不合法");
            //}
            //Console.ReadKey();

            //11.“回文串”是一个正读和反读都一样的字符串，比如“level”或者“noon”等等就是回文串。请写一个程序判断读入的字符串是否是“回文”。
            //string str = "noon1";
            //bool istrue = true;
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == str[str.Length -1- i])
            //    {
            //        istrue = true;
            //    }
            //    else
            //    {
            //        istrue = false;
            //        break;
            //    }
            //}
            //if (istrue)
            //{
            //    Console.Write(str + "是回文");
            //}
            //else
            //{
            //    Console.Write(str + "不是回文");
            //}
            //Console.ReadKey();

            /*12.
            网上流传一句话:"常在网上飘啊，哪能不挨刀啊～"。其实要想能安安心心地上网其实也不难，学点安全知识就可以。
            首先，我们就要设置一个安全的密码。那什么样的密码才叫安全的呢？一般来说一个比较安全的密码至少应该满足下面两个条件：
            (1).密码长度大于等于8，且不要超过16。
            (2).密码中的字符应该来自下面“字符类别”中四组中的至少三组。

            这四个字符类别分别为：
            1.大写字母：A,B,C...Z;
            2.小写字母：a,b,c...z;
            3.数字：0,1,2...9;
            4.特殊符号：~,!,@,#,$,%,^;

            给你一个密码，你的任务就是判断它是不是一个安全的密码。
             */
            //string str = Console.ReadLine();
            //bool istrue = true;
            //bool isA=false,isa=false,is0=false,isteshu= false;
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if(str.Length<8 || str.Length > 16)
            //    {
            //        istrue = false;
            //        break;
            //    }
            //    if (str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        isa = true;
            //    }
            //    if (str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        isA = true;
            //    }
            //    if (str[i] >= '0' && str[i] <= '9')
            //    {
            //        is0 = true;
            //    }
            //    if(str[i]=='~' && str[i] == '!' && str[i] == '@' && str[i] == '#' && str[i] == '%' && str[i] == '^')
            //    {
            //        isteshu = true;
            //    }
            //}
            //if (istrue)
            //{
            //    if (isa || isA || is0 || isteshu)
            //    {
            //        if (isa || isA || is0)
            //        {
            //            if (isa || isA)
            //            {
            //                Console.Write("安全");
            //            }
            //            else
            //            {
            //                Console.Write("不安全");
            //            }
            //        }
            //        else
            //        {
            //            Console.Write("不安全");
            //        }
            //    }
            //    else
            //    {
            //        Console.Write("不安全");
            //    }

            //}
            //else
            //{
            //    Console.Write("不安全");
            //}
            //Console.ReadKey();
        }
    }
}
