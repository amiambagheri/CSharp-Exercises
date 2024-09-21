using System;

namespace Basic_Calculator;

public class Calculator
{

    public double FirstOperand { get; set; }
    public double SecondOperand { get; set; }
    private double _result;
    private string? _operator;
    public string Operator
    {
        set
        {
            if (value == "+" ||
                value == "-" ||
                value == "*" ||
                  value == "/")
            {
                _operator = value;
            }

        }
    }

    public void PrintOptions()
    {
        Console.WriteLine("Options: ");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");
        Console.Write("Enter an option: ");
    }

    public void Process()
    {
        switch (_operator)
        {
            case "+":
                _result = FirstOperand + SecondOperand;
                break;
            case "-":
                _result = FirstOperand - SecondOperand;

                break;
            case "*":
                _result = FirstOperand * SecondOperand;

                break;
            case "/":
                _result = FirstOperand / SecondOperand;

                break;
            default:
                throw new Exception("That was not a valid option");
        }
    }

    public override string ToString()
    {
        return $"{FirstOperand} {_operator} {SecondOperand} = {_result}";
    }
}
