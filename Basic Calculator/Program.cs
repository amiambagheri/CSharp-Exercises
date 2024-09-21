using Basic_Calculator;

Calculator calculator = new();

do
{
    Console.Clear();
    Console.WriteLine("-------------");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("-------------");
    SetCalculatorOperand(calculator);

    calculator.PrintOptions();
    calculator.Operator = Console.ReadLine() ?? "";
    try
    {
        calculator.Process();
        Console.WriteLine(calculator);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("Would you like to continue? (Y = yes, N = No): ");
} while (Console.ReadLine()?.ToUpper() == "Y");

Console.WriteLine("Bye!");

static void SetCalculatorOperand(Calculator calculator)
{

    Console.Write("Enter number 1:");
    calculator.FirstOperand = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter number 2:");
    calculator.SecondOperand = Convert.ToDouble(Console.ReadLine());

}

