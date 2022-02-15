using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
//    class SConvsNonSCon
//    {
//        #region static field test
//        int x;
//        static int y;

//        public SConvsNonSCon(int x)
//        {
//            y = x;
//        }

//        static void Main()
//        {
//            Console.WriteLine("main method starting");
//            Console.WriteLine(y);
//            Console.WriteLine("main method end");
//            SConvsNonSCon ss = new SConvsNonSCon(10);
//            Console.WriteLine(y);
//            Console.WriteLine("main method end");
//            //Console.WriteLine(xx);
//        }
//    }
//    #endregion


//}
class Constructors
    {

        static Constructors()
        {
            Console.WriteLine("Static constructor is called.");
        }
        Constructors()
        {
            Console.WriteLine("Non-static constructor is called.");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called.");
            Constructors c1 = new Constructors();
            Constructors c2 = new Constructors();
            Constructors c3 = new Constructors();
            Console.ReadLine();
        }
    }
}

