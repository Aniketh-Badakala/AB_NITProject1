using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{
   
    class MethodORChild:MethodORParent
    {        
        //Overriding parent's Show method in child class
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method Is Called.");
        }
        public new void Shadowing()
        {
            Console.WriteLine("c class shadowing");
        }
        //for base accessing p c methods from c c using base
        public void ParentShadowing()
        {
            base.Shadowing();
        }
        public void Parentshow()
        {
            base.Show();
        }
        static void Main()
        {
            MethodORChild c = new MethodORChild();
            c.Show();
            c.Shadowing();
            //accessing p c methods from c c using parent class instance
            MethodORParent cc = new MethodORParent();
            cc.Shadowing();
            Console.WriteLine("------------------------------");
            //accessing p c methods from c c using child instance
            MethodORChild cBase = new MethodORChild();
            cBase.ParentShadowing();//parent method
            cBase.Parentshow();//parent method
            cBase.Show();//child method
            cBase.Shadowing();//child methods
            //p c ref accessing c c mem which r not purely def
            MethodORChild c2c = new MethodORChild();
            MethodORParent c1cref = c2c;
            c1cref.Show();
            c1cref.Shadowing();
           
        }
    }
}
