using InterfaceIComparable.Entities;

namespace InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Projetos C#\Seção 14 - Interfaces\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employees = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));
                    }
                    employees.Sort();

                    foreach(Employee ep in employees)
                    {
                        Console.WriteLine(ep);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}