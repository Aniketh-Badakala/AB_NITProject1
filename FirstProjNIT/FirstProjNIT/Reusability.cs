using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Reusability
    {

        //consuming a class from other classes so to reuse the code
        //using instance 
        //as we are creating instance of diff class we can create in any block
        public static void callMethods()//static method
        {
            MethodTypes mt = new MethodTypes();
            mt.type1();
            mt.type3(2, 5);

            Console.WriteLine(mt.type4());
            Console.WriteLine(mt.type5("Valorant"));
        }
        public void callMethods2()//non-static
        {
            MethodTypes mt = new MethodTypes();
            mt.type1();
            mt.type3(2, 5);

            Console.WriteLine(mt.type4());
            Console.WriteLine(mt.type5("Valorant"));
        }
        static void Main()
        {
            Reusability.callMethods();
            new Reusability().callMethods2();
        }
    }
}
