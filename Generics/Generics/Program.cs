namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> pservice = new PrintService<int>();
            Console.Write("How many values?");
            int manyValues = int.Parse(Console.ReadLine());

            for(int i = 0; i < manyValues; i++)
            {
                Console.Write($"Value {i + 1}: ");
                int x = int.Parse(Console.ReadLine());
                pservice.AddValue(x);
            }
            Console.WriteLine();
            pservice.Print();
            Console.WriteLine("First: " + pservice.First());

            PrintService<string> pService = new PrintService<string>();

            Console.WriteLine();
            Console.Write("How many values?");
            manyValues = int.Parse(Console.ReadLine());

            for (int i = 0; i < manyValues; i++)
            {
                Console.Write($"Name {i + 1}: ");
                string x = Console.ReadLine();
                pService.AddValue(x);
            }
            Console.WriteLine();
            pService.Print();
            Console.WriteLine("First: " + pService.First());
        }
    }
}