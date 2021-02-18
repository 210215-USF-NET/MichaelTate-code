using System;
using ToHModels;
using ToHBL;
namespace ToHUI
{
    class Program
    {
        private static IHeroBL heroBL = new HeroBL();
        static void Main(string[] args)
        {
            //Creat Hero method/logic
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter HP Value: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower Name: ");
            SuperPower newSuperPower = new SuperPower();
            newSuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower Description: ");
            newSuperPower.Description = Console.ReadLine();
            Console.WriteLine("Enter SuperPower Damage: ");
            newSuperPower.Damage = int.Parse(Console.ReadLine());
            newHero.SuperPower = newSuperPower;
            Console.WriteLine("Enter SuperPower Element: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());
            
            heroBL.AddHero(newHero);
            foreach (var item in heroBL.GetHeroes())
            {
                Console.WriteLine("Hero Detalis: \n\t name:", item.HeroName, "\n\t SuperPower:", item.SuperPower.Name, "\n\t Type:", item.ElementType );

            }

            
        }
    }
}
