using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            dogs.Sort();
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Describe());
            }
            Console.ReadKey();
        }
    }

    interface IAnimal
    {
        string Describe();

        string Name { get; set; }
    }

    class Dog : IAnimal, IComparable
    {
        public Dog(string name)
        {
            Name = name;
        }
        public string Describe()
        {
            return "Hello, I'm a dog and my name is " + Name;
        }

        public string Name { get; set; }
        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return Name.CompareTo((obj as IAnimal).Name);
            return 0;
        }
    }
}
