using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace CarApplication.Views.AdminView
{
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
            LoadStateComboBox();
        }

        private void LoadStateComboBox()
        {
            StateSelector.Items.Add("В наличии");
            StateSelector.Items.Add("Выдана");
            StateSelector.Items.Add("На обслуживании");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            string VIN = VINTextBox.Text;
            string? name = NameTextBox.Text;
            string type = TypeTextBox.Text;
            string description = DescriptionTextBox.Text;
            string readerName = readerTextBox.Text;
            string date = DateTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var carToUpdate = db.Car.FirstOrDefault(p => p.VIN == VIN);
                    if (carToUpdate == null)
                    {
                        MessageBox.Show($"{VIN} не найден");
                        return;
                    }

                    var reader = db.Users.FirstOrDefault(r => r.Name == readerName);
                    if (reader != null) carToUpdate.Reader.Id = reader.Id;

                    carToUpdate.VIN = VIN;
                    carToUpdate.Name = name;
                    carToUpdate.Type = type;
                    carToUpdate.Description = description;
                    carToUpdate.PublicationDate = Convert.ToDateTime(date);

                    if (StateSelector.SelectedItem is CarView selectedState)
                    {
                        carToUpdate.State = selectedState.State;
                    }

                    db.Car.Update(carToUpdate);
                    db.SaveChanges();

                    MainFrame.Navigate(new MainPanel());
                }
            }
            catch
            {
                MessageBox.Show("Данные неверные!!!");
            }

        }
        private void Cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPanel());
        }
    }
}
