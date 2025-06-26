using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.Views.AdminView;
using CarApplication.Views.UserViews;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace CarApplication.Views
{
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните данные!");
                return;
            }

            using (var db = new ApplicationContext()) 
            { 
                var user = db.Users.Include(r => r.Role).FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null) 
                {
                    if(user.Role.Name == "Admin")
                    {
                        MainFrame.Navigate(new MainPanel());
                    }
                    else
                    {
                        MainFrame.Navigate(new ViewPage());
                        UserContext.CurrentUser = user;
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя не существует!");
                }
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Registration());  
        }
    }
}
