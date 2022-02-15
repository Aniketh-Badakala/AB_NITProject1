using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
    class MethodORParent
    {       
        public virtual void Show()//can be overridden in c class using override keyword
        {
            Console.WriteLine("Parent Class Show Method Is Called.");
        }
        public void Shadowing()
        {
            Console.WriteLine("p class shadowing");
        }
    }
}
