using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class MethodTypes
    {
        //non-value returning without param
        public void type1()//static behavior//we can print only 5 table till 10
        {
            int x = 5;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }
        //non-value returning with 1 param
        public void type2(int x)//partially static behavior//we can print any table but till 10
        {
            
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }
        //non-value returning with 1 param
        public void type3(int x,int y)//dynamic behavior//we can print any table till any no
        {

            for (int i = 0; i <= y; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }
        //value returning without param
        public string type4()//static behavior //we can convert only valorant
        {
            string s = "valorant";
            s = s.ToUpper();
            return s;           
        }
        //value returning with param
        public string type5(string s)//dynamic behavior// we can convert any string
        {            
            s = s.ToUpper();
            return s;
        }
        static void Main()
        {
            MethodTypes m = new MethodTypes();
            m.type1();
            Console.WriteLine("----------");
            m.type2(6);
            Console.WriteLine("----------");
            m.type3(6,5);
            Console.WriteLine("----------");
            string s1=m.type4();
            Console.WriteLine(s1);
            Console.WriteLine("----------");
            string s2 = m.type5("call of duty");
            Console.WriteLine(s2);
            Console.WriteLine("----------");
        }
    }
}
