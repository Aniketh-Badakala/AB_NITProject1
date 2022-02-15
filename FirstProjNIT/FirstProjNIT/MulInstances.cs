using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class MulInstances
    {
        int x = 0;
        static void Main()
        {
            MulInstances mi1 = new MulInstances();
            MulInstances mi2 = new MulInstances();

            Console.WriteLine("Initial value 1st instance --  " + mi1.x);
            Console.WriteLine("Initial value 2nd instance --  " + mi2.x);

            //modifying the value of field for 1st instance
            mi1.x = 111;
            Console.WriteLine("Initial value 1st instance --  " + mi1.x);//111
            Console.WriteLine("Initial value 2nd instance --  " + mi2.x);//0

            //modifying the value of field for 2nd instance
            mi2.x = 222;
            Console.WriteLine("Initial value 1st instance --  " + mi1.x);//111
            Console.WriteLine("Initial value 2nd instance --  " + mi2.x);//222

        }
    }
}
