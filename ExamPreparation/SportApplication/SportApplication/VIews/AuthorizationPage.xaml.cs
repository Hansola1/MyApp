using Microsoft.EntityFrameworkCore;
using SportApplication.DataControl;
using SportApplication.Models;
using SportApplication.VIews.AdminViews;
using SportApplication.VIews.UsersViews;
using System.Windows;
using System.Windows.Controls;

namespace SportApplication.VIews
{
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var user = db.Users.Include(r => r.Role).FirstOrDefault(u => u.Login == login && u.Password == password);
                    if(user != null)
                    {
                        if(user.Role.Name == "Admin")
                        {
                            MainFrame.Navigate(new MainPanelAdmin());
                        }
                        else
                        {
                            Session.CurrentUser = user;
                            MainFrame.Navigate(new MainPanelUser());
                        }
                    }
                }
        }
            catch
            {
                MessageBox.Show("Данные не прошли валидацию");
            }
}

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RegistrationPage());
        }
    }
}
