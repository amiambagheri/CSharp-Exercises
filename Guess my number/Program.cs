// Console.Clear();
// Random random = new();
// var myNumber = random.Next(1, 101);
// var roundCounter = 0;
// int guessNumber;
// do
// {
//     Console.WriteLine("Guess a number between 1 - 100 :");
//     guessNumber = Convert.ToInt32(Console.ReadLine());
//     if (myNumber == guessNumber)
//     {
//         Console.WriteLine($"Number : {myNumber}");
//         Console.WriteLine("YOU WIN!");
//         Console.WriteLine($"Round: {roundCounter}");
//         Console.WriteLine("Would you like to play again? (Y/N)");
//         var playAgain = Console.ReadLine();
//         switch (playAgain)
//         {
//             case "y":
//             case "Y":
//                 myNumber = random.Next(1, 101);
//                 roundCounter = 0;
//                 Console.Clear();
//                 break;
//             case "n":
//             case "N":
//                 Console.WriteLine("Tanks for playing!");
//                 break;
//         }
//     }
//     else if (myNumber > guessNumber)
//     {
//         Console.WriteLine($"Guess: {guessNumber}");
//         Console.WriteLine($"{guessNumber} is too low!");
//         roundCounter++;
//     }
//     else if (myNumber < guessNumber)
//     {
//         Console.WriteLine($"Guess: {guessNumber}");
//         Console.WriteLine($"{guessNumber} is too high!");
//         roundCounter++;
//     }
// } while (myNumber != guessNumber);



Console.Clear();
Random random = new();
bool playAgain = true;
do
{
    var myNumber = random.Next(1, 101);
    var roundCounter = 0;
    int guessNumber = 0;
    while (myNumber != guessNumber)
    {
        Console.WriteLine("Guess a number between 1 - 100 :");
        guessNumber = Convert.ToInt32(Console.ReadLine());

        if (myNumber > guessNumber)
        {
            Console.WriteLine($"Guess: {guessNumber}");
            Console.WriteLine($"{guessNumber} is too low!");
        }
        else if (myNumber < guessNumber)
        {
            Console.WriteLine($"Guess: {guessNumber}");
            Console.WriteLine($"{guessNumber} is too high!");
        }
        roundCounter++;
    }
    Console.Clear();
    Console.WriteLine($"Number : {myNumber}");
    Console.WriteLine("YOU WIN!");
    Console.WriteLine($"Round: {roundCounter}");
    Console.WriteLine("Would you like to play again? (Y/N)");
    var again = Console.ReadLine();
    playAgain = again?.ToUpper() == "Y";

} while (playAgain);

Console.WriteLine("Tanks for playing!");

