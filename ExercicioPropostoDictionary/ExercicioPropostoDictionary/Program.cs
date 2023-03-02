namespace ExercicioPropostoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string nome = line[0];
                        int votos = int.Parse(line[1]);


                        if (dictionary.ContainsKey(nome))
                        {

                            dictionary[nome] += votos;

                        }
                        else
                        {

                            dictionary[nome] = votos;

                        }

                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}