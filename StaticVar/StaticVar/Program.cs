using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVar
{
    class StaticVar
    {
        //可以使用 static 关键字把类成员定义为静态的。当声明一个类成员为静态时，无论有多少个类的对象被创建，只会有一个该静态成员的副本。
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticVarTest
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();

            s1.count();
            s2.count();

            Console.WriteLine("s1的变量num: {0}", s1.getNum());
            Console.WriteLine("s2的变量num: {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}
