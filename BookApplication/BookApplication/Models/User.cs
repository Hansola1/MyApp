using System.ComponentModel.DataAnnotations;

namespace BookApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }          
        public string Password { get; set; }       
        public DateOnly RegistrationDate { get; set; } 
        public string FullName { get; set; }       
        public string PhoneNumber { get; set; }    

        //public List<Book> BorrowedBooks { get; set; } = new(); 
    }
}
