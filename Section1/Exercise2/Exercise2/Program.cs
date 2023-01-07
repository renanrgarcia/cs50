namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            do
            {
                Console.Write("Height: ");
                height = int.Parse(Console.ReadLine());
            } while (height < 1 || height > 8);

            for (int i = height - 1; i >= 0; i--)
            {
                space(i);
                hashtag(height - i);
                Console.Write("  ");
                hashtag(height - i);
                space(i);
                Console.WriteLine();
            }
        }

        static void space(int x)
        {
            for (int i = 0; i < x; i++)
                Console.Write(" ");
        }

        static void hashtag(int y)
        {
            for (int i = 0; i < y; i++)
                Console.Write("#");
        }
    }
}