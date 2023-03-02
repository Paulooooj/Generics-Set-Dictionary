using RestrictionForGenerics.Entities;
using System.Globalization;

namespace RestrictionForGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N:");
            int quantity = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Número {i + 1}: ");
                string[] vector = Console.ReadLine().Split(',');
                string name = vector[0];
                double price = double.Parse(vector[1], CultureInfo.InvariantCulture);
                
                
                
                list.Add(new Product(name, price));

            }
           

            CalculationService cs = new CalculationService();
            Product max = cs.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);

            Console.WriteLine();
            foreach(Product product in list){
                Console.WriteLine(product);
            }
        }
    }
}