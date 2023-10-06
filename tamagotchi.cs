public class Tamagotchi
{
    private bool isAlive;
    private int boredom;
    private List<string> words = new List<string>() { "Helloooo!" };
    private int hunger;

    private Random generator;
    public string name;

    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }

    public void Feed()
    {
        Console.WriteLine("Yummy!");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
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
        Console.WriteLine($"{name} now knows the word {word}, press ENTER to continue");
        Console.ReadLine();
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
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        Console.WriteLine("Yay I'm so happy!");
        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }

}
