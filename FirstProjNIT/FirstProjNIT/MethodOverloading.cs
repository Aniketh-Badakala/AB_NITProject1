using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class MethodOverloading
    {
        public void method1Parent()
        {
            Console.WriteLine("1");
        }
        public string method1Parent(int x,long g)
        {
            Console.WriteLine("2");
            return "2";
        }
        public void method1Parent(string s)
        {
            Console.WriteLine("3");
        }
        public void method1Parent(int x, string s)
        {
            Console.WriteLine("4");
        }
        public void method1Parent(string s, int x)
        {
            Console.WriteLine("5");
        }
        static void Main()
        {
            MethodOverloading mo = new MethodOverloading();
            mo.method1Parent();
            mo.method1Parent(1,11);
            mo.method1Parent("abc");
            mo.method1Parent(1,"abc");
            mo.method1Parent("abc",1);
        }
    }
}
