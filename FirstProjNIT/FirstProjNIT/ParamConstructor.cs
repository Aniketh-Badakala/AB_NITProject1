using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class ParamConstructor
    {
        //int x = 100;
        int x1;

        public ParamConstructor(int x1)
        {
            this.x1 = x1;
        }

        static void Main()
        {
            ParamConstructor pc11 = new ParamConstructor(10);
            ParamConstructor pc12 = new ParamConstructor(20);
            ParamConstructor pc13 = new ParamConstructor(30);

            Console.WriteLine(pc11.x1); Console.WriteLine(pc12.x1);
            Console.WriteLine(pc13.x1);


            //Console.WriteLine(pc11.x); Console.WriteLine(pc12.x);
            //Console.WriteLine(pc13.x);

            //ParamConstructor pc21 = new ParamConstructor();
            //ParamConstructor pc22 = new ParamConstructor();
            //ParamConstructor pc23 = new ParamConstructor();

            //Console.WriteLine(pc21.x1); Console.WriteLine(pc22.x1);
            //Console.WriteLine(pc23.x1);


        }
    }
}
