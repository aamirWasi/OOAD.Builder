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
        public PizzaOrder GetOrder()
        {
            return _order;
        }
    }
}
