using System;

public class DeltaSolver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = CalculateDiscriminant(a, b, c);

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Roots of the equation: root1 = {root1:F2}, root2 = {root2:F2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"The equation has one root: root = {root:F2}");
        }
        else
        {
            Console.WriteLine("The equation has no real roots.");
        }
    }

    static double CalculateDiscriminant(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }
}
