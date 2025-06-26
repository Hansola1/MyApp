using CarApplication.DataControl;
using CarApplication.Models;
using CarApplication.ViewModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CarApplication.Views.AdminView
{
    public partial class AddPage : Page
    {
        public AddPage()
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

        private void Add_Click(object sender, System.Windows.RoutedEventArgs e)
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
                    var selectedState = StateSelector.SelectedItem.ToString();

                    CarState state = selectedState switch
                    {
                        "В наличии" => CarState.Available,
                        "Выдана" => CarState.Issued,
                        "На обслуживании" => CarState.InMaintenance,
                        _ => throw new InvalidOperationException("Неизвестный статус")
                    };

                    var reader = db.Users.FirstOrDefault(r => r.Name == readerName);
                    if (reader == null) 
                    {
                        MessageBox.Show("НЕТ ТАКОГО ЮЗЕРА!!!");
                        return;
                    }

                    var carToAdd = new Car
                    {
                        VIN = VIN,
                        Name = name,
                        Type = type,
                        Description = description,
                        PublicationDate = Convert.ToDateTime(date),
                        Reader = reader,
                        State = state,
                    };

                    db.Car.Add(carToAdd);
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
