namespace OOD.RPG.FluentInterface.Types.ExpressionBuilder.Interfaces
{
    public interface ICharacterBuilderStats
    {
        ICharacterBuilderStats HP(int hp);
        ICharacterBuilderStats Strength(int strength);
        ICharacterBuilderStats Agi(int agility);
        ICharacterBuilderStats Int(int intelligence);
        ICharacterBuilderStats Gold(int gold);
    }
}
