using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 引入命名空间

namespace Program //命名空间
{
    class Program //类
    {
        static void Main(string[] args)//函数
        {
            Console.WriteLine("随便什么");
            Console.Write("随便写什么");
            Console.Write("随便写什么");
            //WriteLine会空一行
            //Write就是连续写下去
            Console.ReadLine();
            Console.ReadKey();
            //ReadLine是输入完后回车结束，ReadKey是检测到输入一下就结束，不需要回车
        }
    }
}