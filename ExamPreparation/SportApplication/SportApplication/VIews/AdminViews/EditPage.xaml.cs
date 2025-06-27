using SportApplication.DataControl;
using SportApplication.Models;
using SportApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace SportApplication.VIews.AdminViews
{
    public partial class EditPage : Page
    {
        public EditPage()
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

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            string inventoryNumber = NumberTextBox.Text;
            string title = TitleTextBox.Text;
            string type = TypeTextBox.Text;
            string description = DescriptionTextBox.Text;
            string publicationDate = DatePublicationPicker.Text;
            string readerName = ReaderTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var inventoryToUpdate = db.Invetoryes.FirstOrDefault(i => i.InventoryNumber == inventoryNumber);
                    if (inventoryNumber == null) return;

                    var reader = db.Users.FirstOrDefault(r => r.Name == readerName);
                    if (inventoryNumber == null) return;

                    inventoryToUpdate.InventoryNumber = inventoryNumber;
                    inventoryToUpdate.Reader.Id = reader.Id;

                    if(StatusComboBox.SelectedItem is InventoryView selectedState)
                    {
                        inventoryToUpdate.State = selectedState.State;
                    }

                    inventoryToUpdate.Name = title;
                    inventoryToUpdate.Type = type;
                    inventoryToUpdate.Description = description;
                    inventoryToUpdate.PublicationDate = DateOnly.Parse(publicationDate);

                    db.Invetoryes.Update(inventoryToUpdate);
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
