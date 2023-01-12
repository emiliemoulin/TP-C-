Village newVillage = new Village("village1");
Console.WriteLine(newVillage.getName()); // "village1"
class Village
{
    private string name;

    public Village(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }
}
class Ressources
{
    private int woods;
    private int stones;

    public Ressources(int woods, int stones)
    {
        this.woods = woods;
        this.stones = stones;
    }

    public int getWood()
    {
        return woods;
    }

    public int getStone()
    {
        return stones;
    }
}




