abstract class Activity
{
    protected string Date;
    protected int Duration; // Minutes
    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({Duration} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}