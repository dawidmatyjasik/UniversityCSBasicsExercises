using System;

public class Access
{
    static void Main(string[] args)
    {
        VerifyAge();
    }

    static void VerifyAge()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Access granted");
        }
        else if (age >= 15 && age < 18)
        {
            Console.WriteLine("Do you have parental consent? (yes/no)");
            string consent = Console.ReadLine();

            if (consent.ToLower() == "yes")
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
        else
        {
            Console.WriteLine("Access denied");
        }
    }
}
