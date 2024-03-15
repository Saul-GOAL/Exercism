static class QuestLogic
{
    public static void Main(string[] args)
    {

    }

    public static bool CanFastAttack(bool knightIsAwake) => 
        !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => 
        (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) =>
        archerIsAwake == false && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => 
        petDogIsPresent ? archerIsAwake == false : (prisonerIsAwake) && ((archerIsAwake == false) && (knightIsAwake == false));
}
