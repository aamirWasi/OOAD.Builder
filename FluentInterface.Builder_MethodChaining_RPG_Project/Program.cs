using FluentInterface.Builder_MethodChaining_RPG_Project_Types.ExpressionBuilder;
using System;

namespace FluentInterface.Builder_MethodChaining_RPG_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random((int)DateTime.Now.Ticks);
            var builder = new CharacterBuilder();
            builder
                .Create("Valient")
                .As(Builder_MethodChaining_RPG_Project_Types.ClassType.Fighter)
                .WithAge(22)
                .SetHP(20)
                .SetIntelligence(12)
                .SetStrenght(18)
                .SetAgility(14)
                .SetGold(0);
            var hero = builder.CreateCharacter();
            while (hero.IsAlive)
            {
                builder
                .Create(CommonHelper.GenerateRandomName())
                .As((Builder_MethodChaining_RPG_Project_Types.ClassType)ran.Next(4))
                .WithAge(ran.Next(12,200))
                .SetHP(ran.Next(5,12))
                .SetIntelligence(ran.Next(21))
                .SetStrenght(ran.Next(21))
                .SetAgility(ran.Next(21))
                .SetGold(ran.Next(50));
                var enemy = builder.CreateCharacter();
                CommonHelper.DisplayStartOfBattle(hero, enemy);
                CommonHelper.Battle(hero, enemy);
            }
            Console.ReadKey();
        }
    }
}
