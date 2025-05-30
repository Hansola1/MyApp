﻿using GeckoMarket.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace GeckoMarket.Views
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if(validationData())
            {
                CreatUser();
                MainFrame.Navigate(new LogInPage());
            }
        }
        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LogInPage());
        }
        private void visitor_Click(object sender, RoutedEventArgs e)
        {
            UserSession.Visitor = true;
            MainFrame.Navigate(new CatalogPage());
        }

        public void SetRegistrationData(string name, string login, string email, string password, string passwordDuplicate)
        {
            Name_TextBox.Text = name;
            Login_TextBox.Text = login;
            Email_TextBox.Text = email;
            PasswordBox.Password = password;
            PasswordBoxDuplicate.Password = passwordDuplicate;
        }

        public bool validationData()
        {
            DBControll db = new DBControll();

            string nickname = Name_TextBox.Text.Trim();
            string login = Login_TextBox.Text.Trim();
            string email = Email_TextBox.Text.Trim();
            string password = PasswordBox.Password.Trim();
            string passwordDuplicate = PasswordBoxDuplicate.Password.Trim();
            // Trim() - убирает пробелы из строки.

            if (string.IsNullOrEmpty(login) || login.Length < 5)
            {
                MessageBox.Show("Логин должен содержать минимум 5 символов.");
                return false;
            }
            else if(string.IsNullOrEmpty(email) || !email.Contains('@')) //|| !email.Contains('.'))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.");
                return false;
            }
            else if (string.IsNullOrEmpty(password) || password.Length < 5)
            {
                MessageBox.Show("Пароль должен содержать минимум 5 символов.");
                return false;
            }
            else if (string.IsNullOrEmpty(passwordDuplicate) || password != passwordDuplicate)
            {
                MessageBox.Show("Пароли не совпадают.");
                return false;
            }
            else if (db.UserExists(login) == true)
            {
                MessageBox.Show("Такой аккаунт существует");
                return false;
            }
            return true;
        }

        private void CreatUser()
        {
            DBControll db = new DBControll();
            db.AddUsers(Name_TextBox.Text, Login_TextBox.Text, PasswordBox.Password, Email_TextBox.Text);       
        }
    }
}
