using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01
{
    class Program:Object
    {
        static void Main(string[] args)
        {//derived class
            Console.WriteLine("------------------------Class with Inheritance----------------");
          C c= new C(6);
          
          c.Getall();
          c.Public_Member();

          C c1 = new C(1);
          c1.Getall();
         
         
            Console.ReadKey();
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
  public  class A
    { 
        public  A(int x)//COnstructor
        {
            Console.WriteLine("A is created with "+ x );
        }
        
        public virtual void Public_Member()
        {
            Console.WriteLine("I'm public of A");
        }
        private void private_Member()
        {
            Console.WriteLine("I'm private");
        }
        protected void protected_Member()
        {
            Console.WriteLine("I'm protected");
        }
        internal void internal_Member()
        {
            Console.WriteLine("I'm internal");
        }

    }
    public class B: A
    {

        public B(int x):base( x/2)
        {
            Console.WriteLine("B is created with " + x );
        }
       
    }
    public class C : B
    {
        public C(int y):base(y)
        {

            Console.WriteLine("C is created with " + y/4.00);
        }
        public void Getall()
        {
            Public_Member();
            internal_Member();
            protected_Member();
          //  private_Member();
        }

        public override void Public_Member()
        {
            // ploymorphism
            Console.WriteLine("I'm Public member of " + this.GetType().Name);
        }
    }

}
