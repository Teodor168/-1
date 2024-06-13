namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi neshto s interval: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            var filteredWords = words.Where(word => word.Length <= 3)
                                     .OrderByDescending(word => word);

            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}