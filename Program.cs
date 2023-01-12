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
       private Ressources myRessources;

    public Village()
    {
        myRessources = new Ressources();
    }
}




