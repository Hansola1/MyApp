using BookApplication.DataControl;
using BookApplication.Models;
using BookApplication.ViewModels;
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Controls;

namespace BookApplication.Views
{
    public partial class BookEditPage : Page
    {
        public BookEditPage(List<BookView> books)
        {
            InitializeComponent();
            StatusSelector.ItemsSource = books;
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            StatusSelector.DisplayMemberPath = "Status";
            StatusSelector.SelectedValuePath = "Status";
        }


        private void EditBook()
        {
            string art = artTextBox.Text;
            string readerName = readerTextBox.Text;

            if (string.IsNullOrWhiteSpace(art) || string.IsNullOrWhiteSpace(readerName))
            {
                MessageBox.Show("Добавьте данныe");
            }

            using (var db = new ApplicationContext())
            {
                var bookToUpdate = db.Books.FirstOrDefault(p => p.ArticleNumber == art);
                if (bookToUpdate == null)
                {
                    MessageBox.Show($"Книга с артикулом {art} не найдена");
                    return;
                }

                var reader = db.Users.FirstOrDefault(r => r.FullName == readerName);
                if (reader == null)
                {
                    MessageBox.Show($"Читатель с именем {reader} не найден");
                    return;
                }

                if (StatusSelector.SelectedItem is BookView selectedBook)
                {
                    bookToUpdate.Status = selectedBook.Status;
                }
                bookToUpdate.ReaderId = reader.Id;

                db.Books.Update(bookToUpdate);
                db.SaveChanges();

                MessageBox.Show("Книга успешно изменена");
            }
        }

        private void EditBookClick(object sender, RoutedEventArgs e)
        {
            EditBook();
            BookPage bookPage = new BookPage();
            bookPage.LoadBookDataGrid();

            MainFrame.Navigate(new BookPage());
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookPage());
        }
    }
}
