namespace OpenClosedPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Medium);

            Product[] products = { apple, tree, house };
            var pf = new ProductFilter();
            Console.WriteLine("Green proudcts (old): ");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($"- {p.Name} is Green");
            }

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new): ");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($"- {p.Name} is Green");
            }
            
            Console.WriteLine("Large products (new): ");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($"- {p.Name} is Large");
            }
            
            Console.WriteLine("Large and Green products (new): ");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($"- {p.Name} is Large and Green");
            }
            
            //test

        }
    }
}