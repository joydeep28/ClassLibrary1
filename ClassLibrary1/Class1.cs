using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Class1 : Interface2,Interface3
    {
        public int test()
        {
            return 0;
        }

        public int test1()
        {
            return 1;
        }

        public abstract int test3();

        public int test4()
        {
            return 4;
        }
        public int test5()
        {
            return 4;
        }
    }

    public class Class2: Class1
    {
        public override int test3()
        {
            return 3;
        }
       
    }

    public class Class3
    {
        public static void main(String[] args)
        {
            Class2 obj = new Class2();
            Console.WriteLine(obj.test());
            Console.WriteLine(obj.test1());
            Console.WriteLine(obj.test3());
            Console.WriteLine(obj.test4());
            Console.WriteLine(obj.test5());
        }
    }
}
