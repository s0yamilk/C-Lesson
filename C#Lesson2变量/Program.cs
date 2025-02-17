using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
                {    
            #region 知识点一 折叠代码
            //用于规范管理代码，看起来不长，能折叠起来，想个文件夹
            #endregion
            #region 知识点二 如何申明变量
            int i = 1;
            // 14个变量类型
            // 变量类型 变量名 = 初始值
            // 变量名是自定义 初始值和变量类型相匹配

            //变量类型总结
            ///有符号的整形变量（能存储正负数 一定范围 包括0的变量类型）符号就是说带个负数
            ///1.sbyte 范围 -128到127
            sbyte a = 112;
            //初始值要在范围里面

            ///writeline 里 可以写成"文字"+变量名
            ///Console.WriteLine("yes"+a);
            ///Console.ReadLine();

            ///2.int   范围 -21亿到21亿多
            int b = 2;
            ///3.short 范围 -32768到32767
            short xiao = 3;
            ///4.long  范围 -900万兆到900万兆
            long chang = 4;
            
            ///无符号的整形变量 (能存储 大于等于0的变量类型）无符号就是都是正数
            ///1.byte 范围 0到255
            byte bbb = 233;
            ///2.uint 范围 0到42亿多
            uint bbbb = 29348234;
            ///3.ushort 范围 0到65535
            ushort bbbbb = 23423;
            ///4.ulong 范围 0到18百万兆
            ulong bbbbbb = 102931802491820;
            ///
            ///浮点数（小数）
            ///float 范围7到8位数字 根据编译器不同 数字可能不一样
            ///数字后面加f，否则默认是double类型
            float ss = 0.12345678f;

            ///double 存储15到17位有效数字 多出来的数字会四舍五入
            double sss = 0.123123123121;

            ///decimal 存储27到28位的有效数字 不建议使用 最后加一个m 否则默认是double类型
            decimal ssss = 0.321321321313213131313213113113131313131123m;

            ///特殊类型
            ///bool true false 表示真假的数据类型
            bool aaa = true;
            bool aaaa = false;

            ///char 存储单个字符的变量类型
            char cc = 'T';
            

            ///string 字符串 用来存储多个字符
            string str = "势力扩大飞机送到覅就";
            Console.WriteLine(str);
            #endregion
            #region 知识点三 为什么有这么多不同的变量类型
            //不同的变量 存储范围和类型不同 占用的内存空间不同
            //选择不同的变量类型，就是用来装载对应的数据
            //口诀 数字用int 小数用float 字符串用string 真假用bool
            #endregion
            #region 知识点四 多个相同类型变量 同时申明
            int c = 123, cccc =1234, ccc =12345;
            float a1 = 0.124f, a2 = 0.12345123f;
            //可以用逗号来分开，同时对多个变量赋值，用逗号空格 开始写下一项
            //公式：变量类型 变量名 = 初始值，变量名 =初始值，变量名 = 初始值;
            #endregion
            #region 知识点五 变量申明时，可以不设置初始值（不建议）
            int a35;//光这样写会报错
            a35 = 1323;//这里另起一行 给变量名一个值
            Console.WriteLine(a35);
            #endregion
            #region 练习
            // Console.WriteLine("个人资料");
            // string name = "soymilk";
            // int age = 28;
            // bool sex = true;
            // int height = 172;
            // float weight = 62.5f;
            // string adress = "shanghai";
            // Console.WriteLine("name"+name);
            // Console.WriteLine("age"+age);
            // Console.WriteLine("ture=male false=female"+sex);
            // Console.WriteLine(height+"cm");
            // Console.WriteLine(weight+"kg");
            // Console.WriteLine(adress+"china");
            // Console.ReadLine();
            #endregion


        }
    }
}