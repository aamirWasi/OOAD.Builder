using FluentInterface.Builder_MethodChaining_RPG_Project_Types.ExpressionBuilder.Interfaces;

namespace FluentInterface.Builder_MethodChaining_RPG_Project_Types.ExpressionBuilder
{
    public class CharacterBuilder:ICharacterBuilderStats,ICharacterBuilderAge,ICharacterBuilderClassType
    {
        private Character _character;
        public CharacterBuilder Create(string name)
        {
            _character = new Character(name);
            return this;
        }
        public ICharacterBuilderAge As(ClassType classType)
        {
            _character.ClassType = classType;
            return this;
        }

        public ICharacterBuilderStats SetAgility(int agility)
        {
            _character.Agility = agility;
            return this;
        }

        public ICharacterBuilderStats SetGold(int gold)
        {
            _character.Gold = gold;
            return this;
        }

        public ICharacterBuilderStats SetHP(int hp)
        {
            _character.HP = hp;
            _character.MaxHP = hp;
            return this;
        }

        public ICharacterBuilderStats SetIntelligence(int intelligence)
        {
            _character.Intelligence = intelligence;
            return this;
        }

        public ICharacterBuilderStats SetStrenght(int strength)
        {
            _character.Strength = strength;
            return this;
        }

        public ICharacterBuilderStats WithAge(int age)
        {
            _character.Age = age;
            return this;
        }

        public Character CreateCharacter()
        {
            return _character;
        }
    }
}
