namespace Excercises;

public class Pitagoras
{
    static void Main(string[] args)
    {
        CalculateHypotenuse(3.5, 6);
    }
    static void CalculateHypotenuse(double a, double b)
    {
        double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine(result);
    }
}
