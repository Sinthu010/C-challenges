class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0,2,5,3,7,8,4];

    public int Today() => birdsPerDay[birdsPerDay.Length-1];
    

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1] += 1;
    }

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);
    

    public int CountForFirstDays(int numberOfDays)
    {
        var totalCount = 0;
        for (var i=0; i<numberOfDays; i++)
        {
            totalCount += birdsPerDay[i];
        }
        return totalCount;
    }

    public int BusyDays()
    {
        var busyDaysCount = 0;
        foreach(var count in birdsPerDay)
        {
            if (count >= 5)
            {
                busyDaysCount += 1;
            }
        }
        return busyDaysCount;
    }
}
