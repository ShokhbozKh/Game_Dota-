using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Murlock:Hero
    {
        public Murlock(string name)
            :base(name)
        {
            
        }
        public Murlock(string name , int attack)
            : base(name , attack)
        {

        }
        public override void Attack()
        {
            if (DateTime.Now.Hour > 13)
            {
                Console.WriteLine($"{Name} Attacking with strength {AttackStrength+100}");
            }
            else
            {
                Console.WriteLine($"{Name} Attacking with strength {AttackStrength}");
            }
        }

        /*
         * 
         * Murlock sinfini tuzing, bu sinfda NightAttack, NightSpeed xusisiyati bo'lsin. 
Attack metodi kech vaqt bo'lsa "{Name} Attacking with strength {NightAttack}" yozuvini, 
        agar kech vaq bo'lmasa "{Name} attacking with strength {AttackStrength}" yozuvini ekranga chiqarsin.
Run -> Agar kech vaqt bo'lsa NightSpeed bilan yugursin, kunduz bo'lsa oddiy tezlik bilan.
         * 
         */
    }
}
