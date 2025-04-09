using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>
        {
            new Lecture("Tech Innovations", "A talk on the latest in tech.", "March 25, 2025", "10:00 AM", new Address("100 Tech Blvd", "San Francisco", "CA", "USA"), "Dr. John Smith", 200),
            new Reception("Networking Night", "An evening of networking with professionals.", "April 10, 2025", "6:00 PM", new Address("456 Business Rd", "New York", "NY", "USA"), "rsvp@example.com"),
            new OutdoorGathering("Spring Festival", "A day of fun and festivities.", "May 5, 2025", "12:00 PM", new Address("789 Park Lane", "Austin", "TX", "USA"), "Sunny, 75°F")
        };
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("------------------------------------\n");
        }
    }
}