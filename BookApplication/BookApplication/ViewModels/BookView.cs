using BookApplication.Models;

namespace BookApplication.ViewModels
{
    public class BookView
    {
        public string ArticleNumber { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string Status { get; set; } //BookStatus
        public string ReaderName { get; set; }
    }
}
