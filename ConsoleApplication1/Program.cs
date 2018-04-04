using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum TypeAnimals
    {
        Cat,
        Dog
    }
    class Animals
    {
        public TypeAnimals Type { get; private set; }
        public string Name { get; set; }
        public string Breed { get; private set; }
        public bool Hanger { get; protected set; }

        public Animals (TypeAnimals type, string name, string breed)
        {
            Type = type;
            Name = name;
            Breed = breed;
        }

        public override string ToString()
        {
            return string.Format($"Я {Type} {Name} {Breed}");
        }
        public virtual void Feed(bool feed)
        {
        }
    }

    class Dog : Animals
    {
        public Dog (TypeAnimals type, string name, string breed): base(type, name, breed)
        {
        }
        public override void Feed(bool feed)
        {
            Console.WriteLine("Кормим собаку...");
            Hanger = feed;
        }
    }
    class Cat : Animals
    {
        public Cat (TypeAnimals type, string name, string breed): base(type, name, breed)
        {
        }
        public override void Feed(bool feed)
        {
            Console.WriteLine("Кормим кота...");
            Hanger = feed;
        }
    }
    

    class Petshop
    {
        private Animals[] container;
        private int index;

        public Petshop()
        {
            container = new Animals[10];
        }

        public void AddPet(Animals newPet)
        {
            container[index++] = newPet;
        }

        public void IntroduceAll()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(container[i]);
            }
        }
    }
    
    class Program
    {
        static void Fert()
        {
        }
        static void Main(string[] args)
        {
            Cat murzic = new Cat(TypeAnimals.Cat, "Murzic", "Sibirskaiya");
            Dog dzheck = new Dog(TypeAnimals.Dog, "Dzheck", "Ovcharka");
            Petshop petshop = new Petshop();
            petshop.AddPet(murzic);
            petshop.AddPet(dzheck);
            petshop.IntroduceAll();

            Console.ReadLine();
        }
    }
}
