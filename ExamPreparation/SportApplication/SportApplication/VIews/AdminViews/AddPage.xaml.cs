using SportApplication.DataControl;
using SportApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace SportApplication.VIews.AdminViews
{
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            StatusComboBox.Items.Add("В наличии");
            StatusComboBox.Items.Add("Выдано");
            StatusComboBox.Items.Add("На обслуживании");
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string inventoryNumber = NumberTextBox.Text;
            string title = TitleTextBox.Text;
            string type = TypeTextBox.Text;
            string description = DescriptionTextBox.Text;
            string publicationDate = DatePublicationPicker.Text;
            string? readerName = ReaderTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var selectedStatus = StatusComboBox.SelectedItem.ToString();
                    StateSport state = selectedStatus switch
                    {
                        "В наличии" => StateSport.Available,
                        "Выдано" => StateSport.Issible,
                        "На обслуживании" => StateSport.Servicing
                    };

                    var reader = db.Users.FirstOrDefault(r => r.Name == readerName);
                    var InventoryToAdd = new Inventory
                    {
                        InventoryNumber = inventoryNumber,
                        Name = title,
                        Type = type,
                        Description = description,
                        PublicationDate = DateOnly.Parse(publicationDate),
                        State = state,
                        Reader = reader
                    };
                    db.Add(InventoryToAdd);
                    db.SaveChanges();

                    MainFrame.Navigate(new MainPanelAdmin());
                }
            }
            catch
            {
                MessageBox.Show("Данные не прошли валидацию");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPanelAdmin());
        }
    }
}
