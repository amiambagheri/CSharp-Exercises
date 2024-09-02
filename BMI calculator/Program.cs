// BMI calculator
Console.WriteLine("Enter yorur weight(kg):");
var weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter yorur height(meter):");
var height = Convert.ToDouble(Console.ReadLine());
var BMI = weight / Math.Pow(height, 2);

// if (BMI <= 18.4)
// {
//     Console.WriteLine("Underweight");
// }
// else if (BMI > 18.5 && BMI < 24.9)
// {
//     Console.WriteLine("Normal");
// }
// else if (BMI > 25 && BMI < 39.9)
// {
//     Console.WriteLine("Overweight");
// }
// else
// {
//     Console.WriteLine("Obese");
// }


switch (BMI)
{
    case <= 18.4:
        Console.WriteLine("Underweight");
        break;
    case > 18.5 when BMI < 24.9:
        Console.WriteLine("Normal");
        break;
    case > 25 when BMI < 39.9:
        Console.WriteLine("Overweight");
        break;
    default:
        Console.WriteLine("Obese");
        break;
}
