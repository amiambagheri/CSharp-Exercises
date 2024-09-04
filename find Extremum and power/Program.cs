

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Power());
        Console.WriteLine(FindExtremum());
    }
    static string Power()
    {
        Console.Clear();
        Console.WriteLine("Enter two number to power it:");
        var numbers = InputList(2);
        double result = numbers[0];
        for (int i = 1; i < numbers[1]; i++)
        {
            result *= numbers[0];
        }
        return $"{numbers[0]} power {numbers[1]}: {result}";
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

    static string FindExtremum()
    {
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter 5 number to find max and min:");
        var numberList = InputList(5);
        double maxItem = numberList[0];
        double minItem = numberList[0];
        foreach (var item in numberList)
        {
            maxItem = maxItem > item ? maxItem : item;
            minItem = minItem < item ? minItem : item;
        }
        return $"Maximum number is:{maxItem}\nMinimum number is:{minItem}";
    }

}