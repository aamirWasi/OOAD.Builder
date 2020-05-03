using System;

namespace OOD.BeverageBuilder_BuilderPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new BeverageBuilder();
            builder.SetBeverageType("Tea");
            builder.SetWater(100);
            builder.SetSugar(60);
            builder.SetMilk(50);
            builder.SetPowderQuantity(45);
            var order = builder.CreateBeverage(); 
            Console.WriteLine(order.ShowBeverageDetails());
        }
    }
}
