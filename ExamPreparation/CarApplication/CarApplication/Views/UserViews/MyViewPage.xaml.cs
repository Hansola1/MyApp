using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CarApplication.Views.UserViews
{
    public partial class MyViewPage : Page
    {
        public MyViewPage()
        {
            InitializeComponent();
            LoadDataGridMy();
        }

        List<CarView> myCars = new();
        private void LoadDataGridMy()
        {
            using (var db = new ApplicationContext())
            {
                myCars = db.Car.Select(s => new CarView
                {
                    Id = s.Id,
                    VIN = s.VIN,
                    Name = s.Name,
                    Type = s.Type,
                    Description = s.Description,
                    PublicationDate = s.PublicationDate,
                    State = s.State,
                    ReaderName = s.Reader != null ? s.Reader.Name : null,

                }).Where(c => c.ReaderName == UserContext.CurrentUser.Name).ToList();
            }

            CarsDataGrid.AutoGenerateColumns = true;
            CarsDataGrid.ItemsSource = myCars;
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewPage());
        }
    }
}
