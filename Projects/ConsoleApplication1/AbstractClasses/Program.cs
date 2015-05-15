using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList animaList = new ArrayList();
            animaList.Add(new Dog());
            animaList.Add(new Cat());
            foreach (FourLeggedAnimal animal in animaList)
            {
                Console.WriteLine(animal.Describe());
            }
            Console.ReadKey();
        }
    }

    abstract class FourLeggedAnimal
    {
        public abstract string Describe();
    }

    class Dog : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "I'm a Dog.";
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "I'm a Cat.";
        }
    }
}
