using System;
namespace OOD.blogs.tedneward.patterns.builder
{
    public class ProductBuilder
    {
        private Product _product;
        public ProductBuilder()
        {
            _product = new Product();
        }
        public ProductBuilder Begin()
        {
            Console.WriteLine("Starts");
            return this;
        }
        public ProductBuilder Engine
        {
            get
            {
                _product.Parts.Add("Engine");
                return this;
            }
        }
        public ProductBuilder SteeringWheel
        {
            get
            {
                _product.Parts.Add("SteeringWheel");
                return this;
            }
        }
        public ProductBuilder Tire
        {
            get
            {
                _product.Parts.Add("Tire");
                return this;
            }
        }
        public ProductBuilder WindShield
        {
            get
            {
                _product.Parts.Add("WindShield");
                return this;
            }
        }
        public ProductBuilder Model
        {
            get
            {
                _product.Parts.Add("Model");
                return this;
            }
        }
        public ProductBuilder Chasis
        {
            get
            {
                _product.Parts.Add("Chasis");
                return this;
            }
        }
        public ProductBuilder Seat
        {
            get
            {
                _product.Parts.Add("Seat");
                return this;
            }
        }
        public ProductBuilder HeadLight
        {
            get
            {
                _product.Parts.Add("HeadLight");
                return this;
            }
        }
        public ProductBuilder BackGlass
        {
            get
            {
                _product.Parts.Add("BackGlass");
                return this;
            }
        }
        public ProductBuilder Break
        {
            get
            {
                _product.Parts.Add("Stop");
                return this;
            }
        }
        public Product GetProduct()
        {
            return _product;
        }
    }
}
