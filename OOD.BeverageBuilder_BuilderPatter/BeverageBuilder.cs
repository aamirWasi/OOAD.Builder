namespace OOD.BeverageBuilder_BuilderPatter
{
    public class BeverageBuilder
    {
        private readonly Beverage _order;

        public BeverageBuilder()
        {
            _order = new Beverage();
        }
        public void SetWater(int water)
        {
            System.Console.WriteLine($"Boiling Water");
            _order.Water = water;
        }
        public void SetMilk(int milk)
        {
            System.Console.WriteLine($"Adding {milk}ml milk");
            _order.Milk = milk;
        }
        public void SetSugar(int sugar)
        {
            System.Console.WriteLine($"Adding {sugar}gm sugar");
            _order.Sugar = sugar;
        }
        public void SetPowderQuantity(int quantity)
        {
            System.Console.WriteLine($"Adding {quantity}gm {_order.BeverageName}powder");
            _order.PowderQuantity = quantity;
        }
        public void SetBeverageType(string type)
        {
            _order.BeverageName = type;
        }
        public Beverage CreateBeverage()
        {
            return _order;
        }
    }
}
