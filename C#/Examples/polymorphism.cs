using System;

namespace polymorphism 
{
    //Static or Compile Time Polymorphism
    class StaticPolymorphism
    {
        public class TestOverloading
        {

            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String :" + a1 + a2);
            }

            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer :" + a1 + a2);
            }

        }

        static void Main(string[] args)
        {
            TestOverloading obj = new TestOverloading();

            obj.Add("Manish ", "Agrahari");

            obj.Add(5, 10);

            Console.ReadLine();
        }
    }

    //Dynamic or Runtime Polymorphism

    class RuntimePolymorphismProgram
    {
        public class Base
        {

            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {
            public override void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            Base objBase;
            objBase = new Base();
            objBase.Show();//    Output ----> Show From Base Class.

            objBase = new Derived();
            objBase.Show();//Output--> Show From Derived Class.

            Console.ReadLine();
        }
    }
    //

    class Program
    {
        public class Base
        {

            public void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {
            //Following line will Give an Warning
            /*
             'polymorphism.Program.Derived.Show()'
  hides  inherited member
             'polymorphism.Program.Base.Show()'.
              Use the new keyword if hiding was intended.
            */
            public void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            Base objBase = new Base();
            objBase.Show();//    Output ----> Show From Base Class.

            Derived objDerived = new Derived();
            objDerived.Show();//Output--> Show From Derived Class.


            Base objBaseRefToDerived = new Derived();
            objBaseRefToDerived.Show();//Output--> Show From Base Class.

            Console.ReadLine();
        }
    }

    //Method Overriding

    class MethodOverridingProgram
    {
        public class Base
        {

            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {
            //the keyword "override" change the base class method.
            public override void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            Base objBaseRefToDerived = new Derived();
            objBaseRefToDerived.Show();//Output--> Show From Derived Class.

            Console.ReadLine();
        }
    }


    //Method Hiding


    class MethodHidingProgram
    {
        public class Base
        {

            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {

            //Following Line will give error. if base class show() is not marked virtual
            /*
             * Error:- 'polymorphism.MethodHidingProgram.Derived.Show()'
             * cannot override inherited member  'polymorphism.MethodHidingProgram.Base.Show()'
             * because it is not marked virtual, abstract, or override
             */
            public new void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            Base objBaseRefToDerived = new Derived();
            objBaseRefToDerived.Show();//Output--> Show From Base Class.

            Console.ReadLine();
        }
    }
    //Sealed Keyword
    class SealedKeywordProgram
    {
        public class Base
        {

            public virtual void Show()
            {
                //This Line will give an error if its sealed instead of virtual - "cannot be sealed because it is not an override"
                Console.WriteLine("This is Base Class.");
            }
        }

        public class Derived : Base
        {
            public override sealed void Show()
            {
                // rather selead here.
                Console.WriteLine("This is Derived Class.");
            }
        }

        static void Main(string[] args)
        {
            Base objBaseReference = new Derived();
            objBaseReference.Show();// Output ---> This is Derived Class.

            Console.ReadLine();
        }
    }

}
/* Output
 * 
*/
