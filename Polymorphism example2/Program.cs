using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_example2
{
    class A
    {
        public virtual void Method()
        {
            Console.WriteLine("Method class A");
        }
    }

    class B : A
    {
        public virtual new void Method()
        {
            Console.WriteLine("Method class B");
        }
    }

    class C : B
    {
        public virtual new void Method()
        {
            Console.WriteLine("Method class C");
        }
    }
    class D : C
    {
        public virtual new void Method()
        {
            Console.WriteLine("Method class D");
        }
    }
    class F : D
    {
        public override void Method()
        {
            Console.WriteLine("Method class F");
        }
    }

    class Program
    {
        static void Method2(A link)
        {
            link.Method();
        }

        static void Main(string[] args)
        {
            A a = new F();
            B b = new F();
            C c2 = new C();
            C c = new F();
            D d = new F();
            F f = new F();
              a.Method();
              b.Method();
              c.Method();
              d.Method();
              f.Method();
            //a.Method();
          /*  Method2(a);
            Method2(b);
            Method2(c);
            Method2(d);
            Method2(f);
            Method2(c2);*/
            
            Console.ReadLine();
        }
    }
}
