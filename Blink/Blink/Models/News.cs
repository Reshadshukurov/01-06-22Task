namespace Blink.Models
{
    public class News : BaseEntity
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string LongText { get; set; }

    }
}
