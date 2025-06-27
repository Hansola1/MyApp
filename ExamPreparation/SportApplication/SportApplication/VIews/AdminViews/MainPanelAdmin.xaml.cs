using Microsoft.EntityFrameworkCore;
using SportApplication.DataControl;
using SportApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace SportApplication.VIews.AdminViews
{
    public partial class MainPanelAdmin : Page
    {
        public MainPanelAdmin()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        //List<InventoryView> inventories = new();
        List<UserView> users = new();
        private void LoadDataGrid()
        {
            using (var db = new ApplicationContext())
            {
                InvetoryDataGrid.ItemsSource = db.Invetoryes.Select(s => new InventoryView
                {
                    InventoryNumber = s.InventoryNumber,
                    Name = s.Name,
                    Type = s.Type,
                    Description = s.Description,
                    PublicationDate = s.PublicationDate,
                    State = s.State,
                    ReaderName = s.Reader != null ? s.Reader.Name : null
                }).ToList();
            }
            InvetoryDataGrid.AutoGenerateColumns = true;
            //InvetoryDataGrid.ItemsSource = inventories;

            using (var db = new ApplicationContext())
            {
                users = db.Users.Include(r => r.Role).Select(s => new UserView
                {
                    Id = s.Id,
                    Login = s.Login,
                    Password = s.Password,
                    RegistrationDate = s.RegistrationDate,
                    Surname = s.Surname,
                    Name = s.Name,
                    Phone = s.Phone,
                    RoleName = s.Role != null ? s.Role.Name : null
                }).ToList();
            }
            UsersDataGrid.AutoGenerateColumns = true;
            UsersDataGrid.ItemsSource = users;
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddPage());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedInventory = InvetoryDataGrid.SelectedItem as InventoryView;
            if (selectedInventory != null)
            {
                using (var db = new ApplicationContext())
                {
                    var inventoryToDelete = db.Invetoryes.FirstOrDefault(db => db.Id == selectedInventory.Id);
                    if (inventoryToDelete == null) return;

                    db.Invetoryes.Remove(inventoryToDelete);
                    db.SaveChanges();
                }
                LoadDataGrid();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EditPage());
        }
    }
}
