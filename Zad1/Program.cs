namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int product = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Vavedi chislo {i+1}: ");
                int number = int.Parse(Console.ReadLine());
                while (number >= 100)
                {
                    Console.Write($"Vavadi chislo {i+1} (<100): ");
                    number = int.Parse(Console.ReadLine());
                }
                numbers[i] = number;

                if (number != 0)
                {
                    product *= number;
                }
                
            }Console.WriteLine($"Proizvedenieto im e {product}");
        }
    }
}
