using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("03 Nov 2022", 30, 20),
            new Swimming("03 Nov 2022", 30, 20)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}