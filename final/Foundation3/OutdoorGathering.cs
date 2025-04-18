class OutdoorGathering : Event
{
    private string weatherForecast;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }
    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {weatherForecast}";
    }
}