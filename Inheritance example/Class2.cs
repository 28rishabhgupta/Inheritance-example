using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_example
{
    class Class2 : Class1
    {

        public Class2(int a) : base(a)
        {
            // Console.WriteLine("Class 2 Constructor is called "+ a);
            Console.WriteLine("Class 2 Constructor is called now");
        }
        public void Test3()
        {
            Console.WriteLine("Method3");
        }
        static void Main()
        {
            // Object
            /*   Object obj = new Object();
               Console.WriteLine(obj.GetType());
               Class1 p = new Class1();
               Console.WriteLine(p.GetType());
               Class2 c = new Class2();
               Console.WriteLine(c.GetType()); */
            Class2 c = new Class2(50);
            Console.ReadLine();
        }
    }
}
