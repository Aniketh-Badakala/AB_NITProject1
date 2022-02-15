using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Class1Inheritance
    {
        public Class1Inheritance()//RULE#1 parent class con should be accessible
            //to inheriting classess
        {
            Console.WriteLine("class1 constructor called");
        }
        public void Add1()
        {
            Console.WriteLine("parent class add1 method");
        }
        public string Mul1()
        {
            return "parent class mul1 method";
        }
    }
}
