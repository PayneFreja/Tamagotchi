using System;

Tamagotchi tamagotchi = new Tamagotchi();

Console.WriteLine("Name your Tamagotchi");

tamagotchi.name = Console.ReadLine();

Console.WriteLine($"Your pets name is {tamagotchi.name}");
Console.WriteLine("Press ENTER to continue");

Console.ReadLine();


while (tamagotchi.GetAlive() == true)
{
    Console.Clear();
    tamagotchi.PrintStats();
    Console.WriteLine("What would you like to do with your Tamagotchi?");
    Console.WriteLine($"1. Teach {tamagotchi.name} a new word");
    Console.WriteLine($"2. Talk to {tamagotchi.name}");
    Console.WriteLine($"3. Feed {tamagotchi.name}");
    Console.WriteLine($"4. Nothing");

    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {
        Console.WriteLine("What word would you like your tamagotchi to learn?");
        string word = Console.ReadLine();
        tamagotchi.Teach(word);
    }

    if (doWhat == "2")
    {
        tamagotchi.Hi();
    }

    if (doWhat == "3")
    {
        tamagotchi.Feed();
    }

    else
    {
        Console.WriteLine("Okay then :(");
    }
    tamagotchi.Tick();
}

Console.WriteLine($" You killed {tamagotchi.name}!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();