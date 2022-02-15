using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class DefaultParameterValues
    {
        //no default value, non-static method, non-value returning method
        public void  add(int x, int y,int z)
        {
            Console.WriteLine("General procedure"+ " -- "+(x + y + z));
        }

        //1 default valued parameter, static method, non-value returning method
        public static void add2(int x, int y, int z = 20)
        {
            Console.WriteLine("1 default value" + " -- " + (x + y + z));
        }

        //2 default values static and value returning
        public static int add3(int x, int y=20, int z = 20)
        {
            int xx = x + y + z;
            //Console.WriteLine("General procedure" + " -- " + (x + y + z));
            return xx;
        }

        //2 default values, non static, value returning,inout parameters
        public void add4(ref int x, int y = 20, int z = 20)
        {
             int xx = x + y + z;
            //Console.WriteLine("General procedure" + " -- " + (x + y + z));
            //return x;
            x = xx;
        }
        //3 default values, non static, non-value returning
        public void add5( int x=10, int y = 20, int z = 20)
        {
            
            Console.WriteLine("3 default" + " -- " + (x + y + z));
           
        }
        static void Main()
        {
            DefaultParameterValues dpv = new DefaultParameterValues();
            //General procedure
            dpv.add(10,20,20);

            //1 default valued parameter
            DefaultParameterValues.add2(10, 20);
            //1 default valued parameter, overriding the default value assigned
            //and assigning a new value
            DefaultParameterValues.add2(10, 20, 30);

            //2 default valued parameters,
            Console.WriteLine("2 default" + " -- " + DefaultParameterValues.add3(10));
            //2 default valued parameters, overriding the default value assigned
            Console.WriteLine("2 default" + " -- " + DefaultParameterValues.add3(10,20,20));
            //2 default valued parameters, overriding the default value assigned
            int inoutvar = 10;
            dpv.add4(ref inoutvar, 20, 20);
            Console.WriteLine("2 default with inout parameter" + " -- "+inoutvar);

            //3 default values,printing default values
            dpv.add5();
        }
    }
}
