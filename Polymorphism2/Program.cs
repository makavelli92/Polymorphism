using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class X
    {
        public int a = 777;

        public void GigB()
        {
            Console.WriteLine("In baza");
        }
    }

    class Y : X
    {
        public int b = 69;

        public new void GigP()
        {
            Console.WriteLine("In proizvod");
        }
    }

    class Program
    {
        static void Fert(X x)
        {
            Y y = (Y)x;
        }
        static void Main(string[] args)
        {
            Y y = new Y(); y.GigB(); y.GigP();
            X x = y; x.GigB();
            Y k = (Y)x; k.GigB(); k.GigP();

            X f = new X();
            Console.WriteLine(k.b);


            Console.ReadLine();
        }
    }
}
