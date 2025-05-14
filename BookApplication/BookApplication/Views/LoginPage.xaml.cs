using BookApplication.DataControl;
using BookApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace BookApplication.Views
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private bool ValidationData()
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) ||  string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните поля");
                return false;
            }

            using (var db = new ApplicationContext())
            {
                var user = db.Users.FirstOrDefault(p => p.Login == login && p.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Пользователя не существует");
                    return false;
                }

                return true;
            }
        }

        private void BookPageClick(object sender, RoutedEventArgs e)
        {
            if (ValidationData())
            {
                UserSession.CurrentLogin = loginTextBox.Text;
                MainFrame.Navigate(new BookPage());
            }
        }

        private void RegistrationPageClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RegistrationPage());
        }
    }
}
