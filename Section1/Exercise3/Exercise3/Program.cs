namespace Exercise3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Troca devida: ");
        double troco = double.Parse(Console.ReadLine());
        troco *= 100;

        int moedas25 = (int)troco / 25;
        int sobra25 = (int) troco % 25;
        Console.WriteLine("Moedas ¢25: " + moedas25);

        int moedas10 = sobra25 / 10;
        int sobra10 = sobra25 % 10;

        if (moedas10 != 0)
            Console.WriteLine("Moedas ¢10: " + moedas10);

        int moedas5 = sobra10 / 5;
        int sobra5 = sobra10 % 5;

        if (moedas5 != 0)
            Console.WriteLine("Moedas ¢5: " + moedas5);

        int moedas1 = sobra5 / 1;

        if (moedas1 != 0)
            Console.WriteLine("Moedas ¢1: " + moedas1);

        int TotalMoedas = moedas1 + moedas5 + moedas10 + moedas25;

        Console.WriteLine("Total moedas: " + TotalMoedas);
    }
}