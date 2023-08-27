using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Hero
    {
        public string Name { get; set; }
        public int AttackStrength { get; set; }
        public int Spead { get; set; } = 0;
        public int Health { get; set; } = 100;
        /*
         * 
         * Hero sinfini tuzing.
Xusisiyatlar: Name, AttackStrength, Speed, Health
Metodlar: Attack, Run, Defend, Display.
Attack metodi -> "{Name} Attacking with strength {AttackStrength}" yozuvini ekranga chiqarsin.
Run -> "{Name} is running"
Defend -> "{Name} is defending"
Display -> Barcha xususiyatlrani ekranga chiqarib beradi
         * 
         */
        public Hero(string name)
        {
            Name = name;
        }
        public Hero(string name, int attackStrength)
            : this(name)
        {
            AttackStrength = attackStrength;
        }
        public Hero(string name, int attackStrength,int spead,int health)
            :this(name,attackStrength)
        {
            Spead = spead;
            Health = health;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name} Attacking with strength {AttackStrength}");
        }
        public void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
        public void Defend()
        {
            Console.WriteLine($"{Name} is defending");
        }
        public void  DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}\nAttack strength:{AttackStrength}\nRun:{Spead}\nHealth:{Health}");
            Console.WriteLine();
        }

    }
}
