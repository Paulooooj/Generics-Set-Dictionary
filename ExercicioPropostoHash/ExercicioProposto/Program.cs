namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("How many students for course A? ");
            int quantity = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                courseA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                courseB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                courseC.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine();
            Console.WriteLine("Total Students " + all.Count);

        }
    }
}