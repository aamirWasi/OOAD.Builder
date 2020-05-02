namespace OOD.Exam.Builder_MethodChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PizzaOrderBuilder();
            builder
                .SetCheese(true)
                .SetMeat(MeatType.beef)
                .SetSize(PizzaSize.medium)
                .SetSpicyLevel(SpicyLevel.high);
        }
    }
}
