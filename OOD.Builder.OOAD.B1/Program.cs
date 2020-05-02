using System;

namespace OOD.Builder.OOAD.B1
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderBuilder = new PizzaorderBuilder();
            orderBuilder.SetCheese(false);
            orderBuilder.SetMeat("Chicken");
            orderBuilder.SetSausage(true);
            orderBuilder.SetSpicy(3);
            orderBuilder.GetOrder();
            orderBuilder.Print();
        }
    }
}
