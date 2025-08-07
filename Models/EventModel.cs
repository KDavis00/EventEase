using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Location { get; set; } = string.Empty;

        public List<string> Attendees { get; set; } = new();
    }
}
