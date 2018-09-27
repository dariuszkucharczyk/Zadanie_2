using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    public interface IAnimal
    {
        void Speak();
    }

    class Animal : IAnimal
    {
        public string name { get; set; }
        public int nr { get; set; }

        public Animal(int nr1, string name1)
        {
            nr = nr1;
            name = name1;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal voice");
        }

        public void PrintNrlnPopulation()
        {
            Console.WriteLine(nr+ " "+ name);
            Speak();

        }

    }

    class Cat : Animal
    {

        public Cat(int nr1, string n1) : base(nr1, n1) { }
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

    }


    class Dog : Animal
    {

        public Dog(int nr1, string n1) : base(nr1, n1) { }
        public override void Speak()
        {
            Console.WriteLine("Bark!");
        }
    }

}
