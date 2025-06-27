using System.Text;
using System.Windows;
using SportApplication.VIews;

namespace SportApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthorizationPage());
        }
    }
}