using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_练习4_7
{
    class Program
    {
        struct  Student
        {
            public int num;
            public string name;
            public char sex;
            public double garde;
            public void show()
            {
                Console.WriteLine(name + "的学号为" + num + "是一个" + sex + "生，程序设计成绩为" + garde);
            }
        }
        static void Main(string[] args)
        {
            //8，编一个程序，定义结构类型（有学号、姓名、性别和程序设计成绩四个字段），声明该结构类型变量，用赋值语句对该变量赋值以后再输出。
            Student student;
            student.name = "xiaobawang";
            student.sex = '男';
            student.num = 1605112473;
            student.garde = 85.5;
            //Console.WriteLine(student.name + "的学号为" + student.num + "是一个" + student.sex + "生，程序设计成绩为" + student.garde);
            student.show();
            Console.ReadKey();
        }
    }
}
