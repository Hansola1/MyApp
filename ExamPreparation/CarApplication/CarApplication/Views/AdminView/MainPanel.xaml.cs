using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CarApplication.Views.AdminView
{
    public partial class MainPanel : Page
    {
        public MainPanel()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        List<UserView> user = new();
        List<CarView> car = new();

        private void LoadDataGrid()
        {
            using (var db = new ApplicationContext())
            {
                user = db.Users.Include(r => r.Role).Select(s => new UserView
                {
                    Id = s.Id,
                    Login = s.Login,
                    Password = s.Password,
                    RegistrationDate = s.RegistrationDate,
                    Surname = s.Surname,
                    Name = s.Name,
                    Phone = s.Phone,
                    RoleName = s.Role != null ? s.Role.Name : null,

                }).ToList();
            }
            UsersDataGrid.AutoGenerateColumns = true;
            UsersDataGrid.ItemsSource = user;

            using (var db = new ApplicationContext())
            {
                car = db.Car.Select(s => new CarView
                {
                    Id = s.Id,
                    VIN = s.VIN,
                    Name = s.Name,
                    Type = s.Type,
                    Description = s.Description,
                    PublicationDate = s.PublicationDate,
                    State = s.State,
                    ReaderName = s.Reader != null ? s.Reader.Name : null,
                }).ToList();
            }
            CarsDataGrid.AutoGenerateColumns = true;
            CarsDataGrid.ItemsSource = car;
        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            var selectedCar = CarsDataGrid.SelectedItem as CarView;
            if (selectedCar != null)
            {
                using (var db = new ApplicationContext())
                {
                    var carToDelete = db.Car.FirstOrDefault(p => p.Id == selectedCar.Id);

                    if (carToDelete != null)
                    {
                        db.Car.Remove(carToDelete);
                        db.SaveChanges();

                        LoadDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите, что удалять");
            }
        }

        private void Add_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddPage());
        }

        private void Edit_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EditPage());
            //var selectedCar = CarsDataGrid.SelectedItem as CarView;
            //if (selectedCar != null)
            //{
            //    using (var db = new ApplicationContext())
            //    {
            //        var carToEdit = db.Car.FirstOrDefault(p => p.Id == selectedCar.Id);

            //        if (carToEdit != null)
            //        {
            //            MainFrame.Navigate(new EditPage());
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Выберите, что изменять");
            //}
        }

        private void Set_click(object sender, RoutedEventArgs e) //Отвязка
        {
            var selectedCar = CarsDataGrid.SelectedItem as CarView;

            if (selectedCar != null)
            {
                using (var db = new ApplicationContext())
                {
                    var car = db.Car.Include(c => c.Reader).FirstOrDefault(c => c.Id == selectedCar.Id);
                    if (car == null) return;

                    car.Reader = null;
                    car.State = CarState.Available;

                    db.SaveChanges();
                }

                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите машину");
            }
        }

        private void Get_click(object sender, RoutedEventArgs e) //Выдать
        {
            var selectedCar = CarsDataGrid.SelectedItem as CarView;
            var selectedUser = UsersDataGrid.SelectedItem as UserView;

            if (selectedCar != null && selectedUser != null)
            {
                using (var db = new ApplicationContext())
                {
                    var car = db.Car.Include(c => c.Reader).FirstOrDefault(c => c.Id == selectedCar.Id);
                    if (car == null) return;

                    // Загружаем пользователя из БД
                    var user = db.Users.Find(selectedUser.Id);
                    if (user == null) return;

                    // Прикрепляем существующего пользователя
                    db.Users.Attach(user);

                    car.Reader = user;
                    car.State = CarState.Issued;

                    db.SaveChanges();
                }

                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите пользователя и машину");
            }
        }
    }
}
