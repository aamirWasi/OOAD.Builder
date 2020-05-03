using System;

namespace OOD.RPG.FluentInterface.Types
{
    public class Character
    {
        public string Name { get; set; }
        public ClassType Class { get; set; }
        public int Age { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Gold { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }
        public Character(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            string result = $"{Name} {Class.ToString()} {Age} {Strength} {Agility} {Intelligence} {Gold} {HP} {MaxHP}";
            return result;
        }

        public string QuickStats()
        {
            string result = $"{Name} {HP}/{MaxHP}";
            return result;
        }
    }
}
