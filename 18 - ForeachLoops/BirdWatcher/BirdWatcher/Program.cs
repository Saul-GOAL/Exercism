using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => 
        this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() =>
        [0, 2, 5, 3, 7, 8, 4];

    public int Today() =>
        birdsPerDay[^1];

    public void IncrementTodaysCount() => 
        birdsPerDay[^1] += 1;

    public bool HasDayWithoutBirds()
    {
        bool result = false;
        
        foreach (var item in birdsPerDay)
        {
            if (item == 0)
            {
                result = true;
                break;
            }
        }
        return result;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int result = 0;
        
        for (int i = 0; i < numberOfDays; i++)
        {
            result += birdsPerDay[i];
        }
        return result;
    }

    public int BusyDays()
    {
        int result = 0;
        
        foreach (var item in birdsPerDay)
        {
            if (item > 4)
                result += 1;            
        }
        return result;
    }
}
