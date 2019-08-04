using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_练习3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int HP = 100;
            double MP = 25.2;
            float score = 15.5f;
            string name = "siki";
            Console.WriteLine("{0}的血量为{1}，MP值为{2}，分数值为{3}", name, HP, MP, score);
            Console.ReadKey();
        }
    }
}
