using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_结构体的定义与使用
{
    struct CustomerName
    {
        public string firstName;
        public string lastName;
        public string getName()
        {
            return firstName + " " + lastName;
        }
    }
    struct MyVector3
    {
        public float x;
        public float y;
        public float z;
        public double distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerName customer;
            //customer.firstName = "xiaoye";
            //customer.lastName = "Yang";
            //Console.WriteLine("My name is " + customer.firstName + " " + customer.lastName);
            //Console.WriteLine("My name is " + customer.getName());
            MyVector3 vector3;
            vector3.x = 5;
            vector3.y = 4;
            vector3.z = 3;
            Console.WriteLine(vector3.distance());
            Console.ReadKey();
        }
    }
}
