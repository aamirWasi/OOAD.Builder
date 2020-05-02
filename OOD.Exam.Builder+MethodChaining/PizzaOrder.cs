namespace OOD.Exam.Builder_MethodChaining
{
    public class PizzaOrder
    {
        public bool UseCheese { get; set; } = false;
        public SpicyLevel SpicyLevel { get; set; } = SpicyLevel.medium;
        public MeatType Meat { get; set; } = MeatType.chicken;
        public PizzaSize Size { get; set; } = PizzaSize.large;
    }
}
