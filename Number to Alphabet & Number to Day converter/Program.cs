var exit = false;

while (!exit)
{
    Console.Clear();
    Console.WriteLine("WELCOME");
    Console.WriteLine("Enter anumber to execute :");
    Console.WriteLine("1) Convert number to alphabet");
    Console.WriteLine("2) Convert number to day of week");
    Console.WriteLine("3) Exit");
    Console.Write("-->");
    var input = Console.ReadLine();


    switch (input)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Enter a number between 1 to 10 :");
            var inputNum = Console.ReadLine();
            string outNumber = "";
            switch (inputNum)
            {
                case "1":
                    outNumber = "one";
                    break;
                case "2":
                    outNumber = "two";
                    break;
                case "3":
                    outNumber = "Three";
                    break;
                case "4":
                    outNumber = "Four";
                    break;
                case "5":
                    outNumber = "Five";
                    break;
                case "6":
                    outNumber = "Six";
                    break;
                case "7":
                    outNumber = "Seven";
                    break;
                case "8":
                    outNumber = "Eight";
                    break;
                case "9":
                    outNumber = "Nine";
                    break;
                case "10":
                    outNumber = "Ten";
                    break;
                default:
                    Console.WriteLine("You entered out of range!");
                    break;
            }
            if (!string.IsNullOrEmpty(outNumber))
                Console.WriteLine($"--> Result : {outNumber}");
            // Console.Write(string.IsNullOrEmpty(outNumber) ? "" : $"--> Result : {outNumber}\n");
            Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Enter a number between 1 to 7 :");
            var inputDay = Console.ReadLine();
            string outputDay = "";
            switch (inputDay)
            {
                case "1":
                    outputDay = "Saturday";
                    break;
                case "2":
                    outputDay = "Sunday";
                    break;
                case "3":
                    outputDay = "Monday";
                    break;
                case "4":
                    outputDay = "Tuesday";
                    break;
                case "5":
                    outputDay = "Wednesday";
                    break;
                case "6":
                    outputDay = "Thursday";
                    break;
                case "7":
                    outputDay = "Friday";
                    break;
                default:
                    Console.WriteLine("You entered out of range!");
                    break;
            }
            if (!string.IsNullOrEmpty(outputDay))
                Console.WriteLine($"--> Today is {outputDay} :)");
            // Console.Write(string.IsNullOrEmpty(outputDay) ? "" : $"--> Today is {outputDay} :)\n");
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            exit = true;
            Console.WriteLine("Good bye :)");
            break;
        default:
            Console.Clear();
            Console.WriteLine("You entered wrong item.)");
            Console.WriteLine("Try again.");
            Console.ReadKey();
            break;
    }
}