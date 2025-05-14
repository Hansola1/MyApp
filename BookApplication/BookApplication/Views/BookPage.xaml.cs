using BookApplication.DataControl;
using BookApplication.Models;
using System.Windows;
using System.Windows.Controls;
using BookApplication.ViewModels;

namespace BookApplication.Views
{
    public partial class BookPage : Page
    {
        public BookPage()
        {
            InitializeComponent();
            LoadBookDataGrid();
        }

        List<BookView> books = new();
        public void LoadBookDataGrid()
        {
            using (var db = new ApplicationContext())
            {
                books = db.Books.Select(s => new BookView
                {
                    ArticleNumber = s.ArticleNumber,
                    Title = s.Title,
                    Genre = s.Genre,
                    Description = s.Description,
                    ReleaseDate = s.ReleaseDate,
                    Status = s.Status, //Convert.ToString(s.Status) == "В наличии" ? BookStatus.Available : Convert.ToString(s.Status) == "Выдана" ? BookStatus.CheckedOut : BookStatus.UnderMaintenance,
                    ReaderName = s.ReaderId != null ? db.Users.FirstOrDefault(c => c.Id == s.ReaderId).FullName : null
                }).ToList();
            }

            BookDataGrid.ItemsSource = books;
        }

        private void AddBookClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookAddPage(books));
        }

        private void EditBookClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookEditPage(books));
        }

        private void DeleteBookClick(object sender, RoutedEventArgs e)
        {
            var selectedBook = BookDataGrid.SelectedItem as BookView;
            if (selectedBook != null)
            {
                using (var db = new ApplicationContext())
                {
                    var bookToDelete = db.Books.FirstOrDefault(p => p.ArticleNumber == selectedBook.ArticleNumber);

                    if (bookToDelete != null)
                    {
                        db.Books.Remove(bookToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Книга успешна удалёна!");
                        LoadBookDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите, что удалять");
            }
        }


        private void GetBookClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookEditPage(books));
        }

        private void ReturnBookClick(object sender, RoutedEventArgs e)
        {
            var selectedBook = BookDataGrid.SelectedItem as BookView;
            if (selectedBook != null)
            {
                using (var db = new ApplicationContext())
                {
                    var bookToReturn = db.Books.FirstOrDefault(p => p.ArticleNumber == selectedBook.ArticleNumber);

                    if (bookToReturn != null)
                    {
                        bookToReturn.ReaderId = null;
                        bookToReturn.Status = "Доступна";
                        bookToReturn.Reader = null;

                        db.SaveChanges();

                        MessageBox.Show("Книга успешно возвращена в библиотеку!");
                        LoadBookDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу для возврата");
                return;
            }
        }
    }
}
