class Ressources
{
    private int woods;
    private int stones;

    public Ressources()
    {
        this.woods = 10;     
        this.stones = 10;
    }

    public int getWood()
    {
        return woods;
    }

    public int getStone()
    {
        return stones;
    }

    public void useWood(int nbr)
    {
        
         if (woods >= nbr)
         {
            woods -= nbr;
            System.Console.WriteLine("Tu peux consommer ton bois .");
         }
         else
         {
            System.Console.WriteLine("Va dans la forêt chercher du bois ");
         }  
    }

    public void useStone(int nbr)
    {
        if(stones >= nbr) 
       {
            stones -= nbr;
            System.Console.WriteLine ( " Tu peux consommer tes pierres ");
       }
        else
       {
             System.Console.WriteLine(" Va dans la clairière pour aller chercher des pierre ");
       }

    }
   
  
} 


