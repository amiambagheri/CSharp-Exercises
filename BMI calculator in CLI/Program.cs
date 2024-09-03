
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Validation(args);
        Execute(args);
    }
    static void Validation(string[] args)
    {
        if (args.Length == 0 || args[0] != "bmi")
        {
            BmiErrorHandler();
            Environment.Exit(0);
        }
        else if (args[1] == "--helps")
        {
            HelpsBmi();
            Environment.Exit(0);
        }
        else if (args[1] == "--version")
        {
            BmiVersion();
            Environment.Exit(0);
        }
    }
    static void Execute(string[] args)
    {
        switch (args[1])
        {
            case "--height" when args[3] == "--weight":
                BmiCalculater(args[2], args[4]);
                break;
            case "--weight" when args[3] == "--height":
                BmiCalculater(args[4], args[2]);
                break;
            default:
                BmiErrorHandler();
                break;
        }
    }
    static void BmiCalculater(string height, string weight)
    {
        double weightInt = Convert.ToDouble(weight);
        double heightInt = Convert.ToDouble(height);
        var bmi = Math.Round(weightInt / Math.Pow(heightInt, 2));

        switch (bmi)
        {
            case <= 18.4:
                BmiStatus(bmi, "Underweight");
                break;
            case >= 18.5 when bmi <= 24.9:
                BmiStatus(bmi, "Normal");
                break;
            case >= 25 when bmi <= 39.9:
                BmiStatus(bmi, "Overweight");
                break;
            default:
                BmiStatus(bmi, "Obese");
                break;
        }
    }
    static void HelpsBmi()
    {
        Console.WriteLine("Use this switch to run program");
        Console.WriteLine("--height Your height (Centimeters)");
        Console.WriteLine("--weight Your weight (Kilograms)");
        Console.WriteLine("--version    Show current version");
        Console.WriteLine("--helps  Show command list");
    }
    static void BmiErrorHandler()
    {
        Console.WriteLine("Invalid command :(");
        Console.WriteLine("Use \"bmi --helps\" switch to show help");
    }
    static void BmiVersion()
    {
        Console.WriteLine("Current version is: 1.0");
    }
    static void BmiStatus(double BMI, string status)
    {
        Console.WriteLine($"Your BMI Score is:\n{BMI}\nYour Status is: {status}");
    }
}