using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Class1
    {
        static void Main()
        {
            //non-static method calling
            Program pp = new Program();
            pp.add(1, 1);
            pp.mul(2, 5);
          
            Console.WriteLine("2nd class");            
        }
        
        
    }
}
