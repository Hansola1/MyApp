using System.Windows;
using CarApplication.Views;

namespace CarApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Authorization());
        }
    }
}