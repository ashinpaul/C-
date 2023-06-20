using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface inter
    {
        void add();
    }
    interface inter1 : inter
    {
        void sub();
    }
    public class A : inter1
    {
        public void add()
        {
            Console.WriteLine("add method");
        }
        public void sub()
        {
            Console.WriteLine("sub method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            inter1 i1 = new A();
            i1.add();
            i1.sub();
        }
    }
}
