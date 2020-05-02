namespace OOD.blogs.tedneward.patterns.builder
{
    public class ConcreteBuilder : Builder
    {
        private Product _product;
        private int part=0;

        public ConcreteBuilder()
        {
            _product = new Product();
        }

        public override void BuildPart()
        {
            _product.Parts.Add($"Adding Parts #{part++}");
        }

        public override Product Constructor()
        {
            return _product;
        }
    }
}
