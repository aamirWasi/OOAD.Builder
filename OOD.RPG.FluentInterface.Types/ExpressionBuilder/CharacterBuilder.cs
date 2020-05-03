using OOD.RPG.FluentInterface.Types.ExpressionBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.RPG.FluentInterface.Types.ExpressionBuilder
{
    public class CharacterBuilder : ICharacterBuilderClassType, ICharacterBuilderAge, ICharacterBuilderStats
    {
        private Character _character;

        public CharacterBuilder Create(string name)
        {
            _character = new Character(name);
            return this;
        }
        public ICharacterBuilderStats Agi(int agility)
        {
            _character.Agility = agility;
            return this;
        }

        public ICharacterBuilderAge As(ClassType classType)
        {
            _character.ClassType = classType;
            return this;
        }

        public ICharacterBuilderStats Gold(int gold)
        {
            _character.Gold = gold;
            return this;
        }

        public ICharacterBuilderStats HP(int hp)
        {
            _character.HP = hp;
            _character.MaxHP = hp;
            return this;
        }

        public ICharacterBuilderStats Int(int intelligence)
        {
            _character.Intelligence = intelligence;
            return this;
        }

        public ICharacterBuilderStats Strength(int strength)
        {
            _character.Strength = strength;
            return this;
        }

        public ICharacterBuilderStats WithAge(int age)
        {
            _character.Age = age;
            return this;
        }
        public Character Value()
        {
            return _character;
        }
    }
}
