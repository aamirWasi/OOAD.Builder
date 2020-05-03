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
            _order.Water = water;
        }
        public void SetMilk(int milk)
        {
            _order.Milk = milk;
        }
        public void SetSugar(int sugar)
        {
            _order.Sugar = sugar;
        }
        public void SetPowderQuantity(int quantity)
        {
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
