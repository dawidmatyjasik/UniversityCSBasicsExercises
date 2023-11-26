using System;

public class Kantor
{
    static void Main(string[] args)
    {
        CalculateCurrency();
    }

    static void CalculateCurrency()
    {
        double CHF = 1.12;
        double USD = 3.99;
        double EUR = 1.08;
        double GBP = 1.24;

        Console.WriteLine("Enter amount of PLN:");
        double plnAmount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter currency code (CHF, EUR, GBP):");
        string currencyCode = Console.ReadLine();

        double result = 0;

        switch (currencyCode)
        {
            case "CHF":
                result = Math.Round(plnAmount / USD * CHF, 2);
                break;
            case "EUR":
                result = Math.Round(plnAmount / USD * EUR, 2);
                break;
            case "GBP":
                result = Math.Round(plnAmount / USD * GBP, 2);
                break;
            default:
                Console.WriteLine("Wrong currency code");
                return;
        }

        Console.WriteLine("Converted amount: " + result);
    }
}
