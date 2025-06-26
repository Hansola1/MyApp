using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.Views.AdminView;
using CarApplication.Views.UserViews;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace CarApplication.Views
{
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string phone = PhoneTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Заполните данные!");
                return;
            }

            try
            {
                using (var db = new ApplicationContext())
                {
                    var userRole = db.Roles.FirstOrDefault(r => r.Name == "User");
                    var user = new User
                    {
                        Login = login,
                        Password = password,
                        RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                        Name = name,
                        Surname = surname,
                        Phone = phone,
                        Role = userRole
                    };
                    db.Add(user);
                    db.SaveChanges();
                    MainFrame.Navigate(new Authorization());
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
                return;
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Authorization());
        }
    }
}
