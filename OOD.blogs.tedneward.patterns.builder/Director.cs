namespace OOD.blogs.tedneward.patterns.builder
{
    public class Director
    {
        private Builder _builder = new ConcreteBuilder();
        public Product Construct()
        {
            for (int i = 0; i < 5; i++)
            {
                _builder.BuildPart();
            }
            return _builder.Constructor();
        }
    }
}
