namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] likes = new int[31];

            Console.WriteLine("Laikni mi snimkata: ");
            for (int i = 0; i < 31; i++)
            {
                Console.Write($"Den {i + 1}: ");
                likes[i] = int.Parse(Console.ReadLine());
            }

            var sortedLikes = likes.OrderByDescending(like => like);

            Console.WriteLine();
            Console.WriteLine("Vuv nizhodqsht red");

            foreach (var like in sortedLikes)
            {
                Console.WriteLine(like);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Den ili dni s nai-malko haresvaniq:");
            Console.WriteLine("------------------------------------------");

            int minLikes = likes.Min();
            for (int i = 0; i < 31; i++)
            {
                if (likes[i] == minLikes)
                {
                    Console.WriteLine($"Den {i + 1}");
                }
            }
        }
    }
}