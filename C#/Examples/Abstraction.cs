using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Describe());
            Console.ReadKey();

        }
    }

    abstract class FourLeggedAnimal
    {
        public virtual string Describe()
        {
            return "Not much is known! This animal has four legs.";
        }
    }

    class Dog : FourLeggedAnimal
    {
        public override string Describe()
        {
            string result = base.Describe();
            result += " In fact, it's a dog!";
            return result;
        }

        public string HasTail()
        {
            return "has tail";
        }
    }

    public abstract class A
    {
        public abstract void DoWork(int i);
    }

    // compile with: /target:library
    public class D
    {
        public virtual void DoWork(int i)
        {
            // Original implementation.
        }
    }

    public abstract class E : D
    {
        public abstract override void DoWork(int i);
    }

    public class F : E
    {
        public override void DoWork(int i)
        {
            // New implementation.
        }
    }

}
/* Output
 * 
*/
