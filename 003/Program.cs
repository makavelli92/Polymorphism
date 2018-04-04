using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public enum TypeFighter
    {
        Voin,
        Vedmak
    }
    class Fighter
    {
        protected string name;
        protected int health;
        protected int powerHit;

        public Fighter(string name)
        {
            Name = name;
        }
        public Fighter(string name, int health, int powerHit)
        {
            Name = name;
            Health = health;
            PowerHit = powerHit;
        }
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                if (value.Length > 0)
                    name = value;
                else
                    Console.WriteLine("Не введено имя воина!");
            }
        }
        public virtual int Health
        {
            get
            {
                return health;
            }
            protected set
            {
                if (value > 0)
                    health = value;
                else if (value <= 0)
                {
                    Console.WriteLine("Воин {0} мертв!", Name);
                    health = value;
                }

                else
                    Console.WriteLine("Неверно введено значение здоровья воина!");
            }
        }
        public virtual int PowerHit
        {
            get
            {
                return powerHit;
            }
            protected set
            {
                if (value > 0)
                    powerHit = value;
                else
                    Console.WriteLine("Неверно введено значение силы удара воина!");
            }
        }
        public string DeclareWinner(Fighter fighter2)
        {
            bool count = true;
            if (Name == fighter2.Name)
                count = false;
            while (Health > 0 && fighter2.Health > 0)
            {
                if (Health < 20)
                    AddHealt();
                else if (fighter2.Health < 20)
                    AddHealt();
                if (count)
                {
                    fighter2.Health = fighter2.Health - PowerHit;
                    count = false;
                    continue;
                }
                else
                {
                    Health = Health - fighter2.PowerHit;
                    count = true;
                    continue;
                }
            }
            if (Health > 0)
                return Name;
            else
                return fighter2.Name;
        }
        public void AddHealt()
        {
            Console.WriteLine("Здоровье {0} меньше 20 %. Хотите восстановть здоровье? y/n", Name);
            string answer = Console.ReadLine();
            if (answer == "y")
                Health += 10;
        }
    }
    class Vedmak : Fighter
    {
        public Vedmak(string name): base(name)
        {
            Health = 110;
            PowerHit = 11;
        }
        public Vedmak(string name, int health, int powerHit) : base(name, health, powerHit)
        {
        }
        public new string DeclareWinner(Fighter fighter2)
        {
            return base.DeclareWinner(fighter2);
        }
        public new void AddHealt()
        {
            base.AddHealt();
        }
    }
    class Voin : Fighter
    {
        
        public Voin(string name, int health, int powerHit) : base(name, health, powerHit)
        {
        }
        public new string DeclareWinner(Fighter fighter2)
        {
            return base.DeclareWinner(fighter2);
        }
        public new void AddHealt()
        {
            base.AddHealt();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Voin fighter1 = new Voin("Воин", 100, 10);
            Vedmak fighter2 = new Vedmak("Ведьмак");
            Console.WriteLine("В сражении победил воин {0}", fighter2.DeclareWinner(fighter1));

            Console.ReadLine();
        }
    }
}
