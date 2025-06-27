using SportApplication.DataControl;
using SportApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace SportApplication.VIews
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string passwrod = PasswordTextBox.Text;
            string surname = SurnameTextBox.Text;
            string name = NameTextBox.Text;
            string phone = PhoneTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var userRole = db.Roles.FirstOrDefault(r => r.Name == "User");
                    var user = new User
                    {
                        Login = login,
                        Password = passwrod,
                        RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                        Surname = surname,
                        Name = name,
                        Phone = phone,
                        Role = userRole
                    };
                    db.Add(user);
                    db.SaveChanges();

                    MainFrame.Navigate(new AuthorizationPage());
                }
            }
            catch
            {
                MessageBox.Show("Данные не прошли валидацию");
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AuthorizationPage());
        }
    }
}
