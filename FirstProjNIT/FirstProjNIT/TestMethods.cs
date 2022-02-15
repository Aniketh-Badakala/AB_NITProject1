using System;
 namespace FirstProjNIT
{
    class TestMethods
    {
        int x = 111;//non static field
        static int y = 222;//static field

        public void Add()//non-static method
        {
        //accessing static and non-static mem inside a non-static block
            Console.WriteLine(x + y);
        }
        public static void mul()//static method
        {
            //accessing static and non-static mem inside a static block
            //Console.WriteLine(x + y);//error//we cannot access a non-static
            //mem directly inisde a static block X//use instance
            TestMethods tm = new TestMethods();
            Console.WriteLine(tm.x * y);
        }
        static void Main()
        {
            //we can call static mem directly or with class name
            TestMethods.mul();

            //we call non-static mem using instance creation
            TestMethods tm = new TestMethods();
            tm.Add();
        }

    }
}