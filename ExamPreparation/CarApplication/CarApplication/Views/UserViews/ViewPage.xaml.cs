using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;
using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.ViewModel;

namespace CarApplication.Views.UserViews
{
    public partial class ViewPage : Page
    {
        public ViewPage()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        List<CarView> car = new();
        public void LoadDataGrid()
        {
            using (var db = new ApplicationContext())
            {
                CarsDataGrid.ItemsSource = db.Car.Select(s => new CarView
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

        private void Get_click(object sender, RoutedEventArgs e)
        {
            var selectedCar = CarsDataGrid.SelectedItem as CarView;

            if (selectedCar != null)
            {
                using (var db = new ApplicationContext())
                {
                    var car = db.Car.Include(c => c.Reader) .FirstOrDefault(c => c.Id == selectedCar.Id);
                    if (car == null) return;

                    if (car.State != CarState.Available)
                    {
                        MessageBox.Show("Эта машина недоступна для взятия.");
                        return;
                    }

                    car.Reader = UserContext.CurrentUser; 
                    car.State = CarState.Issued;

                    db.SaveChanges();
                }

                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите машину");
            }
        }

        private void Set_click(object sender, RoutedEventArgs e)
        {
            var selectedCar = CarsDataGrid.SelectedItem as CarView;
            if (selectedCar != null)
            {
                using (var db = new ApplicationContext())
                {
                    var car = db.Car.Include(c => c.Reader).FirstOrDefault(c => c.Id == selectedCar.Id);
                    if (car == null) return;
                    
                    if (car.Reader == null || car.Reader.Id != UserContext.CurrentUser.Id)
                    {
                        MessageBox.Show("Вы не можете вернуть эту машину.");
                        return;
                    }

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

        private void MyCar_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyViewPage());
        }
    }
}
