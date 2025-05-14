using System.ComponentModel.DataAnnotations;

namespace BookApplication.Models
{
    public class Book
    {
        [Key]
        public string ArticleNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly ReleaseDate { get; set; } 
        public string Status { get; set; }     //BookStatus
        public int? ReaderId { get; set; }         
        public User Reader { get; set; }    
    }

    //public enum BookStatus
    //{
    //    Available,      
    //    CheckedOut,     
    //    UnderMaintenance 
    //}
}
