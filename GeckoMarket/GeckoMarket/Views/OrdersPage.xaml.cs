using GeckoMarket.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace GeckoMarket.Views
{
    public partial class OrdersPage : Page
    {
        public List<OrderData> ordersData { get; set; } = new List<OrderData>();
        public OrdersPage()
        {
            InitializeComponent();
            LoadOrdersItems();
            SetUsersNameLabel();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }
        private void CatalogButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CatalogPage());
        }
        private void BasketButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BasketPage());
        }
        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
        }
        private void ProfileCancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }
        private void Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.CloseProgramm();
        }


        public void LoadOrdersItems()
        {
            if (UserSession.IsLoggedIn == false)
            {
                MessageBox.Show("Создайте аккаунт!!!");
                MainFrame.Navigate(new RegistrationPage());
            }
            else
            {
                LoadOrdersItemsFromDatabase();
            }
        }

        private void LoadOrdersItemsFromDatabase()
        {
            DBControll db = new DBControll();

            string loginCurrentUser = UserSession.CurrentUserLogin;
            int? CurrentUserId = db.GetCurrentUserID(loginCurrentUser);

            ordersData = db.GetOrdersItems(CurrentUserId);
            Orders_DataGrid.ItemsSource = ordersData;
        }


        public void SetUsersNameLabel()
        {
            DBControll db = new DBControll();

            if (UserSession.IsLoggedIn)
            {
                string loginCurrentUser = UserSession.CurrentUserLogin;
                var userData = db.GetUserData(loginCurrentUser);

                if (userData != null)
                {
                    UsersName_TextBlock.Text = userData.nickname;
                }
            }
        }

    }
}
