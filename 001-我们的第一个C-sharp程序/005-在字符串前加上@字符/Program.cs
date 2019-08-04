using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_在字符串前加上_字符
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I'm a good man. \n You are bad girl!";
            Console.WriteLine(str1);
            string str2=@"I'm a good man. \n You are bad girl!";
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
