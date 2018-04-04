using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_example3
{
    public enum TypeEmployee
    {
        Manager = 1,
        SalesPerson = 2
    }


    abstract class Employee
    {
        public TypeEmployee Type { get; set; }
        public double Pay { get; set; }


        public Employee(TypeEmployee type, double pay)
        {
            Type = type;
            Pay = pay;

        }

        public abstract void GiveBonus(int amount);

        public abstract void TakeBonus(int amount);
    }

    class Manager : Employee
    {

        public Manager(TypeEmployee type, double pay) : base(type, pay)
        {

        }

        public override void GiveBonus(int amount)
        {
            if (amount > 10)
                Pay += 100;
        }

        public override void TakeBonus(int amount)
        {
            if (amount == 0)
                Pay -= 100;
        }
    }

    class SalesPerson : Employee
    {

        public SalesPerson(TypeEmployee type, double pay) : base(type, pay)
        {

        }

        public override void GiveBonus(int amount)
        {
            if (amount > 10)
                Pay += 150;
        }

        public override void TakeBonus(int amount)
        {
            if (amount == 0)
                Pay -= 150;
        }
    }


    class Program
    {
        static Employee GetEmployee(TypeEmployee e)
        {
            switch (e)
            {
                case TypeEmployee.Manager:
                    return new Manager(TypeEmployee.Manager, 1000);
                case TypeEmployee.SalesPerson:
                    return new SalesPerson(TypeEmployee.SalesPerson, 1500);
            }

            return null;
        }


        static void Main(string[] args)
        {
            Employee emp = GetEmployee(TypeEmployee.Manager);
            emp.GiveBonus(15);
            Console.WriteLine($"{emp.Type}, {emp.Pay}");

            emp = GetEmployee(TypeEmployee.SalesPerson);
            emp.GiveBonus(20);
            Console.WriteLine($"{emp.Type}, {emp.Pay}");

            Console.ReadLine();
        }
    }
}
