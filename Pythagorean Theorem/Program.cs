//coding challenge 1: The Pythagorean Theorem


// NumberFormatInfo provider = new()
// {
//     NumberDecimalSeparator = ".",
//     NumberGroupSeparator = ","
// };

System.Console.WriteLine("\nEnter Side A:");
double sideA = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("\nEnter side B:");
double sideB = Convert.ToDouble(Console.ReadLine());

double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"The result is: {sideC}");
Console.ResetColor();