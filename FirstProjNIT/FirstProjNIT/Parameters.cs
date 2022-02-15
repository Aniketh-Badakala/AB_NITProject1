using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class OutParameters
    {
        //in+out param
        public void Math1(int a, int b, out int c, out int d)
        { //Before C# 7.0
            c = a + b;
            d = a * b;
        }
        public (int, int) Math2(int a, int b)
        { //From C# 7.0
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
        public (int, int) Math3()
        {
            int a = 10;int b = 20;
            return (a, b);
        }
        static void Main()
        {
            OutParameters obj = new OutParameters();
            (int aa, int bb) = obj.Math3();
            Console.WriteLine(aa +" "+ bb);

            Console.WriteLine("-------------------------------------------------------------------------");
            int Sum1, Product1;
            obj.Math1(100, 25, out Sum1, out Product1);
            Console.WriteLine("Sum of given no's is: " + Sum1);
            Console.WriteLine("Product of given no's is: " + Product1);
            Console.WriteLine("-------------------------------------------------------------------------");
            
            obj.Math1(100, 25, out int Sum2, out int Product2); //From C# 7.0
            Console.WriteLine("Sum of given no's is: " + Sum2);
            Console.WriteLine("Product of given no's is: " + Product2);
            Console.WriteLine("------------------------------------------------------------------------");
            
            var (Sum3, Product3) = obj.Math2(100, 25);
            Console.WriteLine("Sum of given no's is: " + Sum3);
            Console.WriteLine("Product of given no's is: " + Product3);
            Console.WriteLine("---------------------------------------------------------------------");

            (int Sum4, int Product4) = obj.Math2(100, 25);
            Console.WriteLine("Sum of given no's is: " + Sum4);
            Console.WriteLine("Product of given no's is: " + Product4);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
