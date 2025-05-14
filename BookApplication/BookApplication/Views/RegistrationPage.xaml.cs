using BookApplication.DataControl;
using BookApplication.Models;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace BookApplication.Views
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private bool ValidationData()
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string fullName = fullNameTextBox.Text;
            string phoneNumber = phoneTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Заполните поля");
                return false;
            }

            using (var db = new ApplicationContext())
            {
                if (db.Users.Any(u => u.Login == login))
                {
                    MessageBox.Show("Логин уже занят!");
                    return false;
                }

                var user = new User
                {
                    Login = login,
                    Password = password,
                    RegistrationDate = DateOnly.FromDateTime(DateTime.Today),
                    FullName = fullName,
                    PhoneNumber = phoneNumber,
                };
                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Вы успешно создали аккаунт");
                return true;
            }
        }

        private void RegistrationPageClick(object sender, RoutedEventArgs e)
        {
            if (ValidationData())
            {
                MainFrame.Navigate(new LoginPage());
            }
        }
        private void LoginPageClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}
