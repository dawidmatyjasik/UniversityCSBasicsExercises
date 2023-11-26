public class Bmi
{
    static void Main(string[] args)
    {
        CalculateBmi();
    }
    static void CalculateBmi()
    {
        double weight, height;
        Console.WriteLine("Enter your height in meters:");
        height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your weight in kg:");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your BMI is:");
        double result = weight / Math.Pow(height, 2);
        Console.WriteLine(result);
    }
}
