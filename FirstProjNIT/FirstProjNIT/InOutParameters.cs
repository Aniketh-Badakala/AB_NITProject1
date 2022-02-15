using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class InOutParameters
    {
        public void Factorial(ref uint fact)
        {
            if (fact == 0 || fact == 1)
            {
                fact = 1;
            }
            else
            {
                uint prod = 1;
                for (uint i = 2; i <= fact; i++)
                {
                    prod = prod * i;
                }
                fact = prod;
            }
        }
        static void Main()
        {
            InOutParameters p = new InOutParameters();
            uint num = 8;
            Console.Write($"Factorial of {num} is: ");
            p.Factorial(ref num);
            Console.WriteLine(num);
            Console.ReadLine();

        }
    }
}
