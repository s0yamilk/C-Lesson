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
                Console.ReadKey();

                
                #endregion
            }
        }
    }