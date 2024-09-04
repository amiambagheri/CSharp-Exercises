using System;

class Program
{
    static void Main()
    {
        Random random = new();
        Console.Clear();
        ControlFlow(random);
    }
    static void ControlFlow(Random random)
    {
        var playGame = true;
        while (playGame)
        {
            var player = PlayerChoice();
            var computer = ComputerChoice(random);
            Console.WriteLine($"Player: {player}");
            Console.WriteLine($"Computer: {computer}");
            CompareChoice(player, computer);
            playGame = PlayAgain();
        }

        Console.WriteLine("Thanks for playing!");
    }
    static string ComputerChoice(Random random)
    {
        string[] choices = ["ROCK", "PAPER", "SCISSORS"];
        return choices[random.Next(0, 3)];
    }
    static string PlayerChoice()
    {

        var input = "";
        while (input != "ROCK" && input != "PAPER" && input != "SCISSORS")
        {
            Console.Write("Enter ROCK , PAPER OR SCISSORS: ");
            input = Console.ReadLine().ToUpper();
            if (input != "ROCK" && input != "PAPER" && input != "SCISSORS")
                BadCommand();
        }

        return input;
    }
    static void CompareChoice(string playerChoice, string computerChoice)
    {
        // Rock wins against scissors.
        // Scissors win against paper.
        // Paper wins against rock.
        string result = "";
        if (playerChoice != computerChoice)
        {
            switch (playerChoice)
            {
                case "ROCK":
                    result = computerChoice switch
                    {
                        "SCISSORS" => "You win!",
                        "PAPER" => "You lose!",
                    };
                    break;
                case "PAPER":
                    result = computerChoice switch
                    {
                        "SCISSORS" => "You lose!",
                        "ROCK" => "You win!",
                    };
                    break;
                case "SCISSORS":
                    result = computerChoice switch
                    {
                        "PAPER" => "You win!",
                        "ROCK" => "You lose!",
                    };
                    break;
            }
        }
        else
            result = "it`s a draw!";

        Console.WriteLine(result);
    }
    static void BadCommand()
    {
        Console.WriteLine("invalid command!");
    }
    static bool PlayAgain()
    {
        Console.Write("Would you like to play again(Y/N): ");
        var input = Console.ReadLine().ToUpper();
        return input == "Y";
    }

}
