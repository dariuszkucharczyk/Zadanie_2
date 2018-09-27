using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listAnimals = new List<Animal>();
            listAnimals.Add(new Cat(1, "a"));
            listAnimals.Add(new Cat(2, "b"));
            listAnimals.Add(new Cat(3, "c"));
            listAnimals.Add(new Dog(1, "d"));
            listAnimals.Add(new Dog(2, "e"));
            listAnimals.Add(new Dog(3, "f"));
            foreach(Animal a1 in listAnimals)
            {
                a1.PrintNrlnPopulation();
                    
                
            }


            Console.ReadKey();
        }
    }
}
