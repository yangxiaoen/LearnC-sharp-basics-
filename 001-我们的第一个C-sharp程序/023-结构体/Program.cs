using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_结构体
{
    struct position
    {
        public float x;
        public float y;
        public float z;
    }
    enum Direction
    {
        south,
        east,
        west,
        north
    }
    struct path
    {
        public float distance;
        public Direction dir;
    }
    class Program
    {
        static void Main(string[] args)
        {
            path path1;
            path1.dir = Direction.east;
            path1.distance = 1000;

        }
    }
} 
