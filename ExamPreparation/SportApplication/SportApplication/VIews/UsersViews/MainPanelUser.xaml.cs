using SportApplication.ViewModels;
using SportApplication.Models;
using System.Windows;
using System.Windows.Controls;
using SportApplication.DataControl;
using Microsoft.EntityFrameworkCore;

namespace SportApplication.VIews.UsersViews
{
    public partial class MainPanelUser : Page
    {
        public MainPanelUser()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        //List<InventoryView> inventories = new();
        private void LoadDataGrid()
        {
            using(var db = new ApplicationContext())
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
        }

        private void MyInventory_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyInventory());
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            var selectedInventory = InvetoryDataGrid.SelectedItem as InventoryView;
            try
            {
                using (var db = new ApplicationContext())
                {
                    var inventory = db.Invetoryes.Include(c => c.Reader).FirstOrDefault(i => i.Id == selectedInventory.Id);
                    if (inventory == null) return;

                    inventory.Reader = null;
                    inventory.State = StateSport.Issible;

                    db.SaveChanges();
                }
                LoadDataGrid();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, упс");
            }
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            var selectedInventory = InvetoryDataGrid.SelectedItem as InventoryView;
            try
            {
                using (var db = new ApplicationContext())
                {
                    var inventory = db.Invetoryes.Include(c => c.Reader).FirstOrDefault(i => i.Id == selectedInventory.Id);
                    if (inventory == null) return;

                    inventory.Reader = Session.CurrentUser;
                    inventory.State = StateSport.Available;

                    db.SaveChanges();
                }
                LoadDataGrid();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, упс");
            }
        }
    }
}
