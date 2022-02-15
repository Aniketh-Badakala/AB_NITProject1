using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class MethodOLChild:MethodOverloading
    {
        //overloading the method of parent class
        public void method1Parent(string s,bool b)
        {
            Console.WriteLine("Child class overloaded method of parent class");
        }
        static void Main()
        {
            MethodOLChild mc = new MethodOLChild();
            //c class can inherit all the mem of p class except private mem
            mc.method1Parent("eff",true);
            mc.method1Parent();//Executes parent class method
        }
    }
}
