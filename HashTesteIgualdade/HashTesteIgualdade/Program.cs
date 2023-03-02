using Course.Entities;

namespace HashTesteIgualdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> product = new HashSet<Product>();

            product.Add(new Product("TV", 900.0));
            product.Add(new Product("Notebook ", 1200.0));


            Product pd = new Product("Notebook ", 1200.0);

            Console.WriteLine("Product: ");
            Console.WriteLine(product.Contains(pd));

            HashSet<Point> points = new HashSet<Point>();

            points.Add(new Point(3, 4));
            points.Add(new Point(5, 14));

            Point p = new Point(3, 4);
            Console.WriteLine("Struct: ");
            Console.WriteLine(points.Contains(p));

        }
    }
}