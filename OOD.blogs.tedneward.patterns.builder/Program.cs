using System;

namespace OOD.blogs.tedneward.patterns.builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ProductBuilder();
            builder
                .Begin()
                .Chasis
                .Engine
                .BackGlass
                .Seat
                .Tire
                .Break
                .GetProduct();
        }
    }
}
