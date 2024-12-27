using System;


namespace ForApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            int counter = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(counter);
                counter += 1;
            }
            int even_counter = 1;
            for (int i = 0; i < 20; i++)
            {
                if (even_counter % 2 == 0)
                    Console.WriteLine(even_counter);
                even_counter += 1;
            }

            int sum_numbers = 0;
            for (int i = 51; i < 150; i++)
            {
                sum_numbers += i;
            }
            Console.WriteLine($"50 ve 150 arasındaki tum sayilarin toplami = {sum_numbers}");

            int sum_even_numbers = 0;
            for (int i = 0; i < 120; i++)
            {
                if (i % 2 == 0)
                    sum_even_numbers += i;
            }
            Console.WriteLine($"1'den 120'ye kadar cift sayilarin toplami = {sum_even_numbers}");

            int sum_odd_numbers = 0;

            for (int i = 0; i < 120; i++)
            {
                if (i % 2 != 1)
                    sum_odd_numbers += i;
            }
            Console.WriteLine($"1'den 120'ye kadar tek sayilarin toplami = {sum_odd_numbers}");

        }
    }
}