using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_枚举类型
{
    enum GameState
    {
        Pause,
        Failed,
        Success,
        start
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameState state = GameState.start;
            if (state == GameState.start)
            {
                Console.WriteLine("当前游戏状态式开始状态");
            }
            Console.WriteLine(state);
            Console.ReadKey();
        }
    }
}
