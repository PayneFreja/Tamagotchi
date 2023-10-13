public class Tamagotchi
{
    private bool isAlive;
    public int boredom;
    private List<string> words = new List<string>() { "Helloooo!" };
    public int hunger;

    public int money = 0;

    private Random generator;
    public string name;


    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }

    public void Feed()
    {
        if (money < 2)
        {
            Console.WriteLine("Not enough money!");
            Thread.Sleep(1000);
            return;
        }

        else
        {
            Console.WriteLine("Yummy!");
            Thread.Sleep(1000);
            money -= 2;
            hunger -= 2;
            if (hunger < 0)
            {
                hunger = 0;
            }
        }
    }

    public void Hi()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($" [{name}] says: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($"{name} now knows the word {word}");
        Thread.Sleep(2000);
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Money {money} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        Console.WriteLine("Yay I'm so happy!");
        money++;
        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }


}
