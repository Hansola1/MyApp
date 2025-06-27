using SportApplication.DataControl;
using SportApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace SportApplication.VIews.UsersViews
{
    public partial class MyInventory : Page
    {
        public MyInventory()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        //List<InventoryView> inventories = new();
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
                }).Where(c => c.ReaderName == Session.CurrentUser.Name).ToList();
            }
            InvetoryDataGrid.AutoGenerateColumns = true;
            //InvetoryDataGrid.ItemsSource = inventories;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPanelUser());
        }
    }
}
