//In case my description of this system isn't clear enough. Yes its C#, just bashing out something extremely quick and dirty here, it likely has big flaws. 
public class CrateRollSystem
{
    private const double BaseChance = 0.1;
    private const double ExtraRollReduction = 0.1;

    // Calculate the chance a player gets for rolling again based on the streak days
    private double CalculateChance(int streakDays)
    {
        double chance = 0.1;
        if(streakDays >= 9){ return 1; }
        chance = chance * streakDays;
        return chance;
    }
      public List<Item> GetCrateReward()
    {
        List<Item> ItemsToGive = new();
        int streakDays = 5; // Replace this with the player's actual streak days
        double chance = CalculateChance(streakDays);
        for (double i = chance; i > 0; i - 0.1) 
        {
          //Insert condition for random here, I'm not trying to write the entire method here
          if(!isSuccess) { return ItemsToGive; }
          else
          {
            var reward = Roll();
            ItemsToGive.Add(reward);
          }
        }
        return ItemsToGive;
        
    }
}
