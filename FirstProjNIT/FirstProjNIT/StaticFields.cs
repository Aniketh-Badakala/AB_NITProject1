using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class StaticFields
    {
        static int x;
        int xx;
      

        static void Main()
        {
            wow w = new wow(10,20);

            Console.WriteLine(wow.x);
            Console.WriteLine(w.xx);

            StaticFields sf = new StaticFields();  
            
            Console.WriteLine(StaticFields.x);
            Console.WriteLine(sf.xx);

            StaticFields.x = 111;
            sf.xx = 222;

            Console.WriteLine(StaticFields.x);
            Console.WriteLine(sf.xx);

            StaticFields.x = 11111111;
            sf.xx = 22222222;

            Console.WriteLine(StaticFields.x);
            Console.WriteLine(sf.xx);
        }
        class wow
        {
            public static int x;
            public int xx;

            public wow(int a,int b)
            {
                x = a;
                xx = b;
            }
        }
    }
}
