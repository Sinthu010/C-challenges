static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;
    

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (archerIsAwake == false) & (prisonerIsAwake == true);
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent == true)
        {
            if(archerIsAwake == false)
            {
                return true;
            }
        }
        else
        {
           if((prisonerIsAwake == true) & (knightIsAwake == false) & (archerIsAwake == false))
           {
               return true;
           }
        }
        return false;
        
    }
}
