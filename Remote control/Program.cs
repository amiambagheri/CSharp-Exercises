var changeChannel = true;
var channel = 1;
do
{
    Console.Clear();
    Console.WriteLine($"**CHANNEL {channel++}**");
    Console.WriteLine("Do you love this channel(Y/N)?");
    var isFavChannel = Console.ReadLine();
    // changeChannel = isFavChannel != "y";
    switch (isFavChannel)
    {
        case "y":
            changeChannel = false;
            Console.WriteLine($"Enjoy watching CHANNEL {channel}");
            break;
    }
}
while (changeChannel);