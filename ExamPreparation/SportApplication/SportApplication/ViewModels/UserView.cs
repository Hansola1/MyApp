namespace SportApplication.ViewModels
{
    public class UserView
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? RoleName { get; set; }
    }
}
