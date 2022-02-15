using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Class4Inheritance:Class3Inheritance
    {
        
        public Class4Inheritance(int x):base(x)
        {
            //this.x = x;
            Console.WriteLine("c4 consatructor called" + "value--"+x);
            Console.WriteLine("c4 consatructor called" + "value--" +x);
        }
        static void Main()
        {
            Class4Inheritance c4 = new Class4Inheritance(101);
            c4.add();
           
        }
    }
}
