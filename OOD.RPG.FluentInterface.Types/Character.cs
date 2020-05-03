using System;

namespace OOD.RPG.FluentInterface.Types
{
    public class Character
    {
        public string Name { get; set; }
        public ClassType ClassType { get; set; }
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
            string result = $"Name : {Name}\nClassType : {ClassType.ToString()}\nAge : {Age}\nStrength : {Strength} /Agility : {Agility} / Intelligence : {Intelligence}\nGold : {Gold}\nHealthPower/MaxHealthPower : {HP}/{MaxHP}";
            return result;
        }

        public string QuickStats()
        {
            string result = $"{Name} ({HP}/{MaxHP})";
            return result;
        }
    }
}
