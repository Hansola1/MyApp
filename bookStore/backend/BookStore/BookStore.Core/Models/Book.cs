namespace BookStore.Core.Models
{
    public class Book
    {
        //public const int MAX_TITLE_LENGTH = 250;

        private Book(Guid id, string title, string description, decimal price) //задавать св-ва будем
        { 
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public Guid Id { get; } //Guid тип данных, который используется для уникальных ID.
        public string Title { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; }

        public static Book Create(Guid id, string title, string description, decimal price)
        {
            // Валидация данных
            if (string.IsNullOrEmpty(title) || title.Length > 250)
            {
                throw new ArgumentException("Название слишком длинное или пустое", nameof(title));
            }

            return new Book(id, title, description, price);
        }
    }
}
