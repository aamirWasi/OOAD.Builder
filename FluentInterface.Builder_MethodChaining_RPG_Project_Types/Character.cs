namespace FluentInterface.Builder_MethodChaining_RPG_Project_Types
{
    public class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Gold { get; set; }
        public int Age { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public ClassType ClassType { get; set; }
        public Character(string name)
        {
            Name = name;
        }
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }
        public override string ToString()
        {
            var result = $"Name:{Name}\nType:{ClassType}\nHP:{HP}\nAge:{Age}\nStrength({Strength})/Agility({Agility})/Intelligence({Intelligence})\nGold:{Gold}";
            return result;
        }
        public string QuickStats()
        {
            var result = $"{Name} ({HP})/({MaxHP})";
            return result;
        }
    }
}
