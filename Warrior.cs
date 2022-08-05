public class Warrior
{

    public Warrior(int height, int weight, string name)
    {
        Height = height;
        Weight = weight;
        Name = name;
    }
    private int height;
    private int weight;
    private string name;

    public int Height { get => height; set => height = value; }
    public int Weight { get => weight; set => weight = value; }
    public string Name { get => name; set => name = value; }


    public void Greetings(Warrior warrior) //le estoy pasando todo el objeto?
    {
        Console.WriteLine($@"Greetings, {warrior.Name}!");
    }

}