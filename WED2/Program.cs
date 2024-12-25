using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номинал монеты (1, 2, 5 или 10): ");
        int nominal = int.Parse(Console.ReadLine());

        if (nominal != 1 && nominal != 2 && nominal != 5 && nominal != 10)
        {
            Console.WriteLine("Номинал монеты должен быть 1, 2, 5 или 10.");
            return; 
        }

        Console.Write("Введите количество монет: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.Write("Введите стоимость одного доллара в гривне: ");
        double exchangeRate = double.Parse(Console.ReadLine());

        DollarCoin dollarCoin = new DollarCoin(nominal, quantity, exchangeRate);

        Console.WriteLine(dollarCoin.GetInformation());

        double valueInCents = dollarCoin.CalculateValueInCents();
        Console.WriteLine($"Стоимость монет в центах: {valueInCents}");
    }
}