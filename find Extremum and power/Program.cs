
using System;
using System.Net.Mail;

internal class Program
{
    private static void Main(string[] args)
    {
        ControlFlow();
    }
    static void ControlFlow()
    {
        Console.Clear();
        Console.WriteLine("Enter two number to power it:");
        var numbers = InputList(2);
        Console.WriteLine($"{numbers[0]} power {numbers[1]}: {Power(numbers[0], numbers[1])}");

        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter 5 number to find max and min:");
        var numberList = InputList(5);
        Console.WriteLine($"Maximum number is:{FindMaximum(numberList)}\nMinimum number is:{FindMinimum(numberList)}");
        Console.ReadLine();
    }
    static double Power(double x, double y)
    {
        double result = x;
        for (int i = 0; i < y - 1; i++)
        {
            result *= x;
        }
        return result;
    }


    static double[] InputList(int inputLength)
    {
        var numberList = new double[inputLength];
        for (int i = 0; i < inputLength; i++)
        {
            numberList[i] = Convert.ToDouble(Console.ReadLine());
        }
        return numberList;
    }

    static double FindMaximum(double[] numberList)
    {
        double maxItem = numberList[0];
        foreach (var item in numberList)
        {
            maxItem = maxItem > item ? maxItem : item;
        }
        return maxItem;
    }
    static double FindMinimum(double[] numberList)
    {
        double minItem = numberList[0];
        foreach (var item in numberList)
        {
            minItem = minItem < item ? minItem : item;
        }
        return minItem;
    }

}