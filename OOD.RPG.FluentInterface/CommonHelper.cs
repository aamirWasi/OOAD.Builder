using OOD.RPG.FluentInterface.Types;
using System;
using System.Threading;

namespace OOD.RPG.FluentInterface
{
    public static class CommonHelper
    {
        private static string[] _firstNames =
        {
            "Destro","Victo","Mozri","Fang","Ovi","Hell","Syth","End"
        };
        private static string[] _lastNames =
        {
            "math","rin","sith","icous","ravage","wrath","ryn","less"
        };
        private static string[] _attackVerbs =
        {
              "Slashes","Stabs","Smashes","Impales","Poisons","Shoots","Incinerates","Destroys"
        };

        public static  string GenerateRandomName()
        {
            string result = "";
            Random ran = new Random((int)DateTime.Now.Ticks);
            result = _firstNames[ran.Next(_firstNames.Length)] + _lastNames[ran.Next(_lastNames.Length)];
            return result;
        }

        public static void DisplayStartOfBattle(Character hero,Character enemy)
        {
            Console.WriteLine("=Starting Battle=");
            Console.WriteLine(hero.ToString());
            Console.WriteLine();
            Console.WriteLine("VS."); 
            Console.WriteLine();
            Console.WriteLine(enemy.ToString());
            Console.WriteLine();
            Console.WriteLine("An enemy approaches >");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Battle(Character hero,Character enemy)
        {
            while (hero.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"{hero.QuickStats()} / {enemy.QuickStats()}");
                Thread.Sleep(1000);
                Console.WriteLine(Attack(hero,enemy));
                Thread.Sleep(1000);
                Console.WriteLine(Attack(enemy,hero));
                if (hero.IsAlive)
                {
                    Console.Write(">");
                    Console.ReadKey();
                }
                Console.WriteLine();
            }
            if (hero.IsAlive)
            {
                hero.Gold += enemy.Gold;
                Console.WriteLine($"Our hero survives to fight another battle!Won {enemy.Gold} gold");
                Console.WriteLine(">");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Our hero has fallen with {hero.Gold} gold! .The world is covered in darkness once again");
            }
        }

        private static string Attack(Character attacker, Character defender)
        {
            string result = "";
            Random ran = new Random((int)DateTime.Now.Ticks);
            int damage = ran.Next(10);
            defender.HP -= damage;
            string verbs = _attackVerbs[ran.Next(_attackVerbs.Length)];
            result = $"{attacker.Name} {verbs} {defender.Name} for {damage} damage";
            return result;
        }
    }
}
