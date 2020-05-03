namespace FluentInterface.Builder_MethodChaining_RPG_Project_Types.ExpressionBuilder.Interfaces
{
    public interface ICharacterBuilderStats
    {
        ICharacterBuilderStats SetHP(int hp);
        ICharacterBuilderStats SetStrenght(int strength);
        ICharacterBuilderStats SetAgility(int agility);
        ICharacterBuilderStats SetIntelligence(int intelligence);
        ICharacterBuilderStats SetGold(int gold);
    }
}
