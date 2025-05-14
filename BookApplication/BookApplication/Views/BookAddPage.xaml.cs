using BookApplication.DataControl;
using BookApplication.Models;
using BookApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BookApplication.Views
{
    public partial class BookAddPage : Page
    {
        public BookAddPage(List<BookView> books)
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

        private void AddBook()
        {
            string art = artTextBox.Text;
            string title = titleTextBox.Text;
            string genre = genreTextBox.Text;
            string description = descriptionTextBox.Text;
            string releaseDate = releaseDateTextBox.Text;
            string readerName = readerTextBox.Text;

            if (string.IsNullOrWhiteSpace(art) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(genre) ||
            string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(releaseDate) || string.IsNullOrWhiteSpace(readerName))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (!DateOnly.TryParse(releaseDate, out DateOnly date))
            {
                MessageBox.Show("Неверный формат даты.");
                return;
            }

            using (var db = new ApplicationContext())
            {
                if (db.Books.Any(p => p.ArticleNumber == art))
                {
                    MessageBox.Show($"Книга с артикулом {art} существуте");
                    return;
                }
                var reader = db.Users.FirstOrDefault(r => r.FullName == readerName);
                if (reader == null)
                {
                    MessageBox.Show($"Читатель с именем {readerName} не найден");
                    return;
                }

                var bookToAdd = new Book
                {
                    ArticleNumber = art,
                    Title = title,
                    Genre = genre,
                    Description = description,
                    ReleaseDate = DateOnly.Parse(releaseDate),
                    Status = (StatusSelector.SelectedItem as BookView)?.Status ?? "Доступна",
                    ReaderId = reader.Id
                };

                db.Books.Add(bookToAdd);
                db.SaveChanges();

                MessageBox.Show("Книга успешно добавлена");

            }
        }

        private void AddBookClick(object sender, RoutedEventArgs e)
        {
            AddBook();
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
