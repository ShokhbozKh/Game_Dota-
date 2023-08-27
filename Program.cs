namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select hero");
            Console.WriteLine("1-HERO");
            Console.WriteLine("2-LION");
            Console.WriteLine("3-URSA");
            Console.WriteLine("4-MURLOCK");

            int selectHero = Choose();
            
            Hero hero = null;

            switch (selectHero)
            {
                case 0: Console.WriteLine("Game end"); return;
                case 1: hero = new Hero("Hero",32);break;
                case 2: hero = new Lion("Lion",12);break ;
                case 3: hero = new Ursa("Ursa",54); break;
                case 4: hero = new Murlock("Murlock",65); break;
                

                default: Console.WriteLine("Default");return;


            }
            hero.Attack();
            hero.DisplayInfo();
            Console.ReadKey();
            Console.Clear();
            Main(args);

        }
        static int Choose()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
    
}