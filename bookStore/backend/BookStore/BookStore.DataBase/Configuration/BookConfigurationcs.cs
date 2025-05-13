using BookStore.Core.Models;
using BookStore.DataBase.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataBase.Configuration
{
    public class BookConfigurationcs : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.Title).HasMaxLength(250).IsRequired(); //Обязательный

            builder.Property(b => b.Description).IsRequired();
            builder.Property(b => b.Price).IsRequired();
        }
    }
}
