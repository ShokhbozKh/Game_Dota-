using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1._2
{
    internal class Lion:Hero
    {
        

        /*
         * Lion sinfini tuzing. bu sinfda NormalHealth xususiyati bo'lsin.
Run -> metodi agarda Health xususiyati NormalHealthdan past bo'lsa Speed xususiyatidan 40% kam bo'lishi kerak.
         */
        public int NormalHealth { get; set; }
        public Lion(string name) :
            base(name)
        { 
        }
        public Lion(string name, int attack)
            : base(name, attack)
        {

        }
        public double Run()
        {
            if (NormalHealth > Health) 
            {
               
                return Spead;
            }
            return Spead;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Run {Run()}");
        }
    }
}
