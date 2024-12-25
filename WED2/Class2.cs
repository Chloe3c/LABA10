using System;

public class DollarCoin : Coin
{
    private double exchangeRate;

    public DollarCoin(int nominal, int quantity, double exchangeRate)
        : base(nominal, quantity)
    {
        this.exchangeRate = exchangeRate;
    }

    public double CalculateValueInCents()
    {
        double totalInHryvnias = CalculateTotal();
        double totalInDollars = totalInHryvnias / exchangeRate;
        return totalInDollars * 100;
    }

    public new string GetInformation()
    {
        return base.GetInformation() + $", Курс доллара в гривне: {exchangeRate}";
    }
}