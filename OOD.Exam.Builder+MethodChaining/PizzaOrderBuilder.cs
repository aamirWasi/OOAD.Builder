using System;

namespace OOD.Exam.Builder_MethodChaining
{
    public class PizzaOrderBuilder
    {
        private readonly PizzaOrder _order;

        public PizzaOrderBuilder()
        {
            _order = new PizzaOrder();
        }
        public PizzaOrderBuilder SetCheese(bool isUseCheese)
        {
            _order.UseCheese = isUseCheese;
            Console.WriteLine($"UseCheese : {isUseCheese}");
            return this;
        }
        public PizzaOrderBuilder SetSpicyLevel(SpicyLevel level)
        {
            switch (level)
            {
                case SpicyLevel.high:
                    Console.WriteLine($"You ordered spicy level high");
                    break;
                case SpicyLevel.medium:
                    Console.WriteLine($"You ordered spicy level medium");
                    break;
                case SpicyLevel.low:
                    Console.WriteLine($"You ordered spicy level low");
                    break;
            }
            return this;
        }
        public PizzaOrderBuilder SetMeat(MeatType type)
        {
            switch (type)
            {
                case MeatType.beef:
                    Console.WriteLine("You ordered beef");
                    break;
                case MeatType.chicken:
                    Console.WriteLine("You ordered chicken");
                    break;
            }
            return this;
        }
        public PizzaOrderBuilder SetSize(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.large:
                    Console.WriteLine("You order large size pizza");
                    break;
                case PizzaSize.medium:
                    Console.WriteLine("You order medium size pizza");
                    break;
                case PizzaSize.small:
                    Console.WriteLine("You order small size pizza");
                    break;
            }
            return this;
        }
        public PizzaOrder CreateOrder()
        {
            return _order;
        }
    }
}
