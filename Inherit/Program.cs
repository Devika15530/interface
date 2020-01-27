using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Parent
    {
       protected internal int a;
       protected  internal string b;
        //public int A { get => a; set => a = value; }
        //public string B { get => b; set => b = value; }

        public void getValues(int x, string y)

        {
            this.a = x;
            this.b= y;


        }

        public void Display()
        {
            Console.WriteLine(this.a+ " " + this.b);
        }

    }
    class Child : Parent
    {


       public int c;
        public void Caluclate(int num)
        {
         c = this.a +num;
           
            Console.WriteLine(c);

        }
    }
   class GrandChild:Child
    {
       int d;
       public void Multiply(int num)
       {
            d = this.c* num;
            Console.WriteLine(d);
       }

   }

    class A
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child ch = new Child();
            GrandChild gc = new GrandChild();
            p.getValues(10, "dev");
           
            p.Display();
            ch.getValues(10, "dev");
            ch.Caluclate(4);
            gc.Caluclate(6);
            gc.Multiply(7);


            Console.ReadKey();

        }
    }
}

namespace Demo
{
    class ExChild : Inherit.Parent
    {
        public void ExDisplay()
        {
            Console.WriteLine(this.a + "" + this.b);
        }
    }
}