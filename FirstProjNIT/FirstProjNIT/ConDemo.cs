using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class ConDemo
    {
        int a;
        string b;
        bool c;
         
        public ConDemo()
        {
            Console.WriteLine("constructor called");
        }
        public void Demo()
        {
            Console.WriteLine("method called");
        }
        static void Main()
        {
            ConDemo cd1 = new ConDemo();
            ConDemo cd2 = new ConDemo();
            ConDemo cd3 = cd2;

            cd1.Demo();
            cd2.Demo();
            cd3.Demo();

        }
    }
}
