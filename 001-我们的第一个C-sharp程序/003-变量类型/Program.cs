using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_变量类型
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 30;
            int score = 6000;
            long count = 100020002;
            Console.WriteLine("myByte={0},score={1},count={2}", myByte, score, count);
            float myFloat = 12.5f;
            double myDouble = 12.5;
            Console.WriteLine("myFloat:{0},myDouble:{1}", myFloat, myDouble);

            char myChar = 'a';
            string myString = "a";
            bool myBool = true;
            Console.WriteLine("myChar={0},myString={1},myBool={2}", myChar, myString, myBool);

            Console.ReadKey(); 

        }
    }
}
