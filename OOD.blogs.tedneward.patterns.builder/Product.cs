using System.Collections.Generic;

namespace OOD.blogs.tedneward.patterns.builder
{
    public class Product
    {
        public IList<string> Parts { get; set; } = new List<string>();
    }
}
