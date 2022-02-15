using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class Params
    {
        //without params normal procedure nonstatic methods
        public void withoutParams(string[] arr)
        {
            string output=null;
            foreach (string item in arr)
            {
                output = output + item;
            }
            Console.WriteLine(output);
        }

        //with params keyword non static method
        public void withParams(params string[] arr)
        {
            string output = null;
            foreach (string item in arr)
            {
                output = output + item;
            }
            Console.WriteLine(output);
        }

        static void Main()
        {
            Params p = new Params();

            //without params
            string[] s = { "hi", " dude", " whats up", " gona come", " home?" };
            p.withoutParams(s);

            //with params
            p.withParams("hi", " dude", " whats up", " gona come", " home?");

        }
    }
}
