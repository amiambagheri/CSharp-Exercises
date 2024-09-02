//converting miles to kilometers

Console.WriteLine("\nEnter the distance in miles:");

double milesDistance = Convert.ToDouble(Console.ReadLine());
double kmOutput = milesDistance * 1.60934;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\n{milesDistance} mile is equal to {kmOutput} kilometers.");
Console.ResetColor();