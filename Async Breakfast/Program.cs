﻿using System.Diagnostics;
using System.Runtime.CompilerServices;


Stopwatch stopwatch = new();
stopwatch.Start();


Coffee cup = PourCoffee();
Console.WriteLine("coffee is ready");

Task<Egg> eggsTask = FryEggsAsync(2);
Task<Bacon> baconTask = FryBaconAsync(3);
Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);


var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
while (breakfastTasks.Count > 0)
{
    Task finishedTask = await Task.WhenAny(breakfastTasks);
    if (finishedTask == eggsTask)
    {
        Console.WriteLine("eggs are ready");
    }
    else if (finishedTask == baconTask)
    {
        Console.WriteLine("bacon is ready");
    }
    else if (finishedTask == toastTask)
    {
        Console.WriteLine("toast is ready");
    }
    await finishedTask;
    breakfastTasks.Remove(finishedTask);
}



Juice orangeJuice = PourOrangeJuice();
Console.WriteLine("Orange juice is ready");


Console.WriteLine("Breakfast is ready!");


stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);



static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
{
    var toast = await ToastBreadAsync(number);
    ApplyButter(toast);
    ApplyJam(toast);

    return toast;
}
static Juice PourOrangeJuice()
{
    Console.WriteLine("Pouring orange juice");
    return new Juice();
}

static void ApplyJam(Toast toast) =>
    Console.WriteLine("Putting jam on the toast");

static void ApplyButter(Toast toast) =>
   Console.WriteLine("Putting butter on the toast");


static async Task<Toast> ToastBreadAsync(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Putting a slice of bread in the toaster");
    }
    Console.WriteLine("Start toasting...");
    await Task.Delay(3000);
    Console.WriteLine("Remove toast from toaster");

    return new Toast();
}
static async Task<Bacon> FryBaconAsync(int slices)
{
    Console.WriteLine($"putting {slices} slices of bacon in the pan");
    Console.WriteLine("cooking first side of bacon...");
    await Task.Delay(3000);
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("flipping a slice of bacon");
    }
    Console.WriteLine("cooking the second side of bacon...");
    await Task.Delay(3000);
    Console.WriteLine("Put bacon on plate");

    return new Bacon();
}


static async Task<Egg> FryEggsAsync(int howMany)
{
    Console.WriteLine("Warming the egg pan...");
    await Task.Delay(3000);
    Console.WriteLine($"cracking {howMany} eggs");
    Console.WriteLine("cooking the eggs ...");
    await Task.Delay(3000);
    Console.WriteLine("Put eggs on plate");
    return new Egg();
}

static Coffee PourCoffee()
{
    Console.WriteLine("Purring coffee...");
    return new Coffee();
}

class Bacon { }
class Egg { }
class Coffee { }
class Juice { }
class Toast { }

