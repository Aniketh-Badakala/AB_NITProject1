using System;

namespace FirstProjNIT
{
    class Program
    {
        static int a;
        static bool b;
        static void Main(string[] args)
        {
            Console.WriteLine(Program.a + "----------" + Program.b);
            Console.WriteLine("Hello World!");
           
            Console.ReadLine();            
        }
        //non-static method
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //static method
        internal void mul(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
