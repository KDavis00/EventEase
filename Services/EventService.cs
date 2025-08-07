using EventEase.Models;

namespace EventEase.Services
{
    public static class EventService
    {
        public static List<EventModel> Events { get; set; } = new()
        {
            new EventModel { Id = 1, Name = "Tech Conference", Date = DateTime.Today.AddDays(5), Location = "New York" },
            new EventModel { Id = 2, Name = "Music Festival", Date = DateTime.Today.AddDays(10), Location = "Los Angeles" },
            new EventModel { Id = 3, Name = "Art Expo", Date = DateTime.Today.AddDays(15), Location = "Chicago" }
        };

        public static int GetNextId() => Events.Count > 0 ? Events.Max(e => e.Id) + 1 : 1;
    }
}
