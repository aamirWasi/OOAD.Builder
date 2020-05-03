namespace OOD.BeverageBuilder_BuilderPatter
{
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public string BeverageName { get; set; }
        public int PowderQuantity { get; set; }
        public string ShowBeverageDetails()
        {
            System.Console.WriteLine($"You want to make {BeverageName}");
            return $"Hot {BeverageName} {Water}ml of water {Milk}ml of milk {Sugar}gm of sugar {PowderQuantity}gm of {BeverageName}";
        }
    }
}
