using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjNIT
{

    //created a complex type to hold mul values
    class Emp
    {
        public int id;
        public int mNo;
        public string Name,Email;
        public bool status;
    }
    class UserDefType
    {
        //initializing the userdef type(class) and returning the type
        public Emp UserDefTypeMethod(int id) {
            Emp e = new Emp
            {
                id = id,
                mNo = 789456123,
                Name = "Dude",
                Email = "hbifb@hnbfvk",
                status = true
            };
            return e;
        }
        //calling the method that will init the userded type through instance creation
        //as the type has mul val we explicitly need to print those by calling
        static void Main()
        {
            UserDefType udt = new UserDefType();
            Emp ee=udt.UserDefTypeMethod(121);
            Console.WriteLine(ee.id + ee.mNo + ee.Name + ee.status + ee.Email);
        }
        
    }
      
}
