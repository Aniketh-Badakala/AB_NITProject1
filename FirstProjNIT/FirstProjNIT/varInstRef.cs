using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class varInstRef
    {
        int x = 100;
        static void Main()
        {
            varInstRef vir = new varInstRef();
            
            //calling a nonstatic member of the class using instance
            Console.WriteLine(vir.x);
            Console.WriteLine(vir);

            //de-referencing
            vir = null;
            //Console.WriteLine(vir.x);
            Console.WriteLine(vir);
        }
    }
}
