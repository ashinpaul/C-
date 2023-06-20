using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public partial class partMeth
    {
        public int empno;
        partial void first()
        {
            Console.WriteLine("inside partial method");
        }
        public void display()
        {
            Console.WriteLine("inside dislay");
            partMeth p = new partMeth();
            p.first();
        }
    }
}
