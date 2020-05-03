using OOD.RPG.FluentInterface.Types.ExpressionBuilder;
using System;

namespace OOD.RPG.FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random((int)DateTime.Now.Ticks);
            var builder = new CharacterBuilder();
            builder
                .Create("Valient")
                .As(Types.ClassType.Fighter)
                .WithAge(22)
                .HP(20)
                .Strength(18)
                .Agi(14)
                .Int(12);
            var hero = builder.Value();
            while (hero.IsAlive)
            {
                builder.Create(CommonHelper.GenerateRandomName())
                    .As((Types.ClassType)ran.Next(4))
                    .WithAge(ran.Next(12,200))
                    .HP(ran.Next(5,12))
                    .Strength(ran.Next(21))
                    .Agi(ran.Next(21))
                    .Int(12)
                    .Gold(ran.Next(50));

                var enemy = builder.Value();
                CommonHelper.DisplayStartOfBattle(hero, enemy);
                CommonHelper.Battle(hero, enemy);
            }
            Console.ReadKey();
        }
    }
}
