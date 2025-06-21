class Champion
{
    public string name { get; }
    public int age { get; set; }
    private string location;

    private List<string> locationHistory;
    public int health { get; private set; }
    public int attack { get; }
    public Champion(string _name, int age, string location, int health, int attack)
    {
        name = _name;
        this.age = age;
        this.location = location;
        this.locationHistory = new List<string>();
        this.health = health;
        this.attack = attack;
    }
    public string GetLocation() { return location; }
    public void SetLocation(string location)
    {
        locationHistory.Add(this.location);
        this.location = location;
    }
    public void ShowLocationHistory()
    {
        foreach (string location in locationHistory)
        {
            Console.WriteLine("////////////////");
            Console.WriteLine(location);
            Console.WriteLine("////////////////");
        }
    }
    public void GetDamaged(int damage)
    {
        health = health - damage;
    }
}
class Program
{
    static void Main()
    {
        Champion katarina = new Champion("Katarina", 16, "Noxus", 100, 45);
        Champion Garen = new Champion("Garen", 25, "Demacia", 200, 35);
        Console.WriteLine(katarina.name);
        Console.WriteLine(katarina.age);

        katarina.age = 17;
        Console.WriteLine(katarina.age);
        Console.WriteLine(katarina.GetLocation());
        katarina.ShowLocationHistory();   
        katarina.SetLocation("Demacia");
        katarina.ShowLocationHistory();       
        katarina.SetLocation("Ionia");
        katarina.ShowLocationHistory();
        katarina.GetDamaged(Garen.attack);
    }
}