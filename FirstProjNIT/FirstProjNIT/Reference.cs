using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Reference
    {
        int x = 100;
        static void Main()
        {
            Reference instance = new Reference();
            Reference classVariable = instance;
            //initial values of instance and reference
            Console.WriteLine("instance value of x  -  " + instance.x);
            Console.WriteLine("reference value of x  -  " + classVariable.x);

            //instance members modification
            instance.x = 222;
            Console.WriteLine("instance value of x after instance modification -  " + instance.x);
            Console.WriteLine("reference value of x after instance modification -  " + classVariable.x);

            //reference members modification
            classVariable.x = 333;
            Console.WriteLine("instance value of x after reference modification -  " + instance.x);
            Console.WriteLine("reference value of x after reference modification -  " + classVariable.x);

            //------------------------------------------------------

            Reference f1 = new Reference();
            Reference f2 = f1;

            Console.WriteLine(f1.x + " " + f2.x);
            f1.x = 200;
            Console.WriteLine(f1.x + " " + f2.x);
            f2.x = 300;
            Console.WriteLine(f1.x + " " + f2.x);

            //---------------------------------------------------------
            //de-referencing 
            Reference r1 = new Reference();
            Reference r2 = r1;
            Console.WriteLine("-----------"+r1.x);
            Console.WriteLine("-----------"+r2.x);
            r2 = null;
            Console.WriteLine("-----------" + r1.x);
            Console.WriteLine("-----------" + r2.x);
        }
    }
}
