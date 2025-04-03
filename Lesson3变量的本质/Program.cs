using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

    namespace Lesson3
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("变量的本质");
                
                #region 知识点一 变量的存储空间（内存中）
                /// 1byte = 8bit
                /// 1KB = 1024byte
                /// 1MB = 1024KB
                /// 1GB = 1024MB
                /// 1TB = 1024GB
                /// 通过sizeof方法 可以获得变量类型所占的内存空间（单位：字节）
                // 有符号
                int sbyteSize = sizeof(sbyte);
                Console.WriteLine("sbyte 所占的字节数为："+sbyteSize);
                int intSize = sizeof(int);
                Console.WriteLine("int 所占的字节数为："+intSize);
                int shortSize = sizeof(short);
                Console.WriteLine("short 所占的字节数为："+shortSize);
                int longSize = sizeof(long);
                Console.WriteLine("long 所占的字节数为："+longSize);
                Console.WriteLine("---------------------");
                //Console.ReadKey();
                // 无符号
                int byteSize = sizeof(byte);
                Console.WriteLine("byte 所占的字节数为："+byteSize);
                int uintintSize = sizeof(uint);
                Console.WriteLine("uint 所占的字节数为："+uintintSize);
                int ushortSize = sizeof(ushort);
                Console.WriteLine("ushort 所占的字节数为："+ushortSize);
                int ulongSize = sizeof(ulong);
                Console.WriteLine("ulong 所占的字节数为："+ulongSize);
                Console.WriteLine("---------------------");
                Console.WriteLine("@@总结就是数字串位数越多 占用的内存也就越大");
                Console.WriteLine("string因为是多个字符 是可变的内容 所以不能用sizeof方法来看占多少内存@@");
                Console.ReadKey();
                #endregion

                #region 知识点二 变量的本质
                ///变量的本质是2进制--计算机中所有的数据本质都是一堆0和1
                ///实际上是电信号，所以0和1分别表示开和关两种状态
                ///存储单位最小单位是bit 只能表示0和1
                ///为了方便数据表示 有了byte的单位，是由8个bit组成的
                ///****一个字节为8位********
                ///1byte = 00000000 就是8个0和1的排列组合
                ///

                    
                #endregion
            }
        }
    }