using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Class2Inheritance:Class1Inheritance
    {
        public Class2Inheritance()
        {
            Console.WriteLine("class2 constructor called");
        }
        public void Add2()
        {
            Console.WriteLine("child class add2 method");
        }
        public string Mul2()
        {
            return "child class mul2 method";
        }

        static void Main()
        {
            Class2Inheritance ci2R1 = new Class2Inheritance();
            ci2R1.Add1();
            Console.WriteLine(ci2R1.Mul1());
            ci2R1.Add2();
            Console.WriteLine(ci2R1.Mul2());
            Console.WriteLine("---------------------------------");
            //RULE#2
            Class1Inheritance ci1R2 = new Class1Inheritance();
            
            ci1R2.Add1();
            Console.WriteLine(ci1R2.Mul1());
            //ci1.Mul2(); we cannot access a child class mem using parent class instance
            Console.WriteLine("---------------------------------");
            //RULE#3
            //p class var= c class instance
            Class2Inheritance ci2R3 = new Class2Inheritance();
            Class1Inheritance ci1R3 = ci2R3;


            //c class var=p class instance  XXXXX
            //Class1Inheritance ci1R22 = new Class1Inheritance();
            //Class2Inheritance a = ci1R2;//implicit conversion
            //Class2Inheritance a = (Class2Inheritance)ci1R22;
            //we cannot init a c class var with p 
            //class instance-conversion error we cant expicitly or impicitly

            ci1R3.Add1();
            Console.WriteLine(ci1R3.Mul1());
            //ci1R3.Add2();
            //Console.WriteLine(ci1R3.Mul2());even if parent class reference is initialized
            //by the child class instance not possible to
            //access the member's which are purely defined under the child class

            Console.WriteLine("---------------------------------");
            //init c c var with (p c ref (which is init by c c class instance))
            Class2Inheritance ci2newInstance = new Class2Inheritance();
            Class1Inheritance ci1newVar = ci2newInstance;//p c var init with c class instance

            Class2Inheritance c12newVar = (Class2Inheritance)ci1newVar;
            c12newVar.Add1();
            c12newVar.Add2();
            Console.WriteLine(c12newVar.Mul1());
            Console.WriteLine(c12newVar.Mul2());
            Console.WriteLine("---------------------------------");
            //RULE#4
            Object obj = new object();
            Console.WriteLine(obj.GetType());
            Class2Inheritance ci2GetType = new Class2Inheritance();
            Console.WriteLine(ci2GetType.GetType());
            Class1Inheritance ci1GetType = new Class2Inheritance();
            Console.WriteLine(ci1GetType.GetType());
        }


    }
}
