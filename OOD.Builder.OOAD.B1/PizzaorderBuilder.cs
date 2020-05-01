namespace OOD.Builder.OOAD.B1
{
    public class PizzaorderBuilder
    {
        private PizzaOrder _order;

        public PizzaorderBuilder()
        {
            _order = new PizzaOrder();
        }
        public void SetMeat(string  meatType)
        {
            _order.Meat = meatType;
        }
        public void SetSausage(bool setSausage)
        {
            _order.UseSausage = setSausage;
        }
        public void SetSpicy(int level)
        {
            _order.SpiceLevel = level;
        }
        public void SetCheese(bool setCheese)
        {
            _order.UseCheese = setCheese;
        }
        public void Print()
        {
            System.Console.WriteLine($"Use Cheese : {_order.UseCheese}\nUse Sausage : {_order.UseSausage}\nMeatType : {_order.Meat}\nSpicyLevel : {_order.SpiceLevel}\nHomeDelivery : {_order.HomeDelivery}");
        }
        public PizzaOrder GetOrder()
        {
            return _order;
        }
    }
}
