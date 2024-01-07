using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Persistence.DbContext;

namespace HeightsBookHub.Persistence.Seeders
{
    public class BookSeeder
    {
        private readonly HeightsBHDbContext _dbContext;
        public BookSeeder(HeightsBHDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task SeedBooksAsync()
        {
            if (!_dbContext.Books.Any())
            {
                var books = new[]
                {
                    new Book
                    {
                        Title = "Book1",
                        Description = "Description of Book1",
                        Content = "Content of Book1",
                        Author = "Author1",
                        ISBN = "ISBN123",
                        Publisher = "Publisher1",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 300,
                        StockQuantity = 50
                    },
                    new Book
                    {
                        Title = "Book2",
                        Description = "Description of Book2",
                        Content = "Content of Book2",
                        Author = "Author2",
                        ISBN = "ISBN456",
                        Publisher = "Publisher2",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book3",
                        Description = "Description of Book3",
                        Content = "Content of Book3",
                        Author = "Author3",
                        ISBN = "ISBN789",
                        Publisher = "Publisher3",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book4",
                        Description = "Description of Book4",
                        Content = "Content of Book4",
                        Author = "Author3",
                        ISBN = "ISBN0123",
                        Publisher = "Publisher4",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book5",
                        Description = "Description of Book5",
                        Content = "Content of Book5",
                        Author = "Author5",
                        ISBN = "ISBN0456",
                        Publisher = "Publisher5",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book6",
                        Description = "Description of Book6",
                        Content = "Content of Book6",
                        Author = "Author6",
                        ISBN = "ISBN0789",
                        Publisher = "Publisher6",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book7",
                        Description = "Description of Book7",
                        Content = "Content of Book7",
                        Author = "Author7",
                        ISBN = "ISBN1123",
                        Publisher = "Publisher7",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book8",
                        Description = "Description of Book8",
                        Content = "Content of Book8",
                        Author = "Author8",
                        ISBN = "ISBN1456",
                        Publisher = "Publisher8",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book9",
                        Description = "Description of Book9",
                        Content = "Content of Book9",
                        Author = "Author9",
                        ISBN = "ISBN1789",
                        Publisher = "Publisher9",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book10",
                        Description = "Description of Book10",
                        Content = "Content of Book10",
                        Author = "Author10",
                        ISBN = "ISBN2123",
                        Publisher = "Publisher10",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book11",
                        Description = "Description of Book11",
                        Content = "Content of Book11",
                        Author = "Author11",
                        ISBN = "ISBN2456",
                        Publisher = "Publisher11",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book12",
                        Description = "Description of Book12",
                        Content = "Content of Book12",
                        Author = "Author12",
                        ISBN = "ISBN2789",
                        Publisher = "Publisher12",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book13",
                        Description = "Description of Book13",
                        Content = "Content of Book13",
                        Author = "Author13",
                        ISBN = "ISBN3123",
                        Publisher = "Publisher13",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book14",
                        Description = "Description of Book14",
                        Content = "Content of Book14",
                        Author = "Author14",
                        ISBN = "ISBN3456",
                        Publisher = "Publisher14",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book15",
                        Description = "Description of Book15",
                        Content = "Content of Book15",
                        Author = "Author15",
                        ISBN = "ISBN3789",
                        Publisher = "Publisher15",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book16",
                        Description = "Description of Book16",
                        Content = "Content of Book16",
                        Author = "Author16",
                        ISBN = "ISBN4123",
                        Publisher = "Publisher16",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book17",
                        Description = "Description of Book17",
                        Content = "Content of Book17",
                        Author = "Author17",
                        ISBN = "ISBN4456",
                        Publisher = "Publisher17",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book18",
                        Description = "Description of Book18",
                        Content = "Content of Book18",
                        Author = "Author18",
                        ISBN = "ISBN4789",
                        Publisher = "Publisher18",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book19",
                        Description = "Description of Book19",
                        Content = "Content of Book19",
                        Author = "Author19",
                        ISBN = "ISBN5123",
                        Publisher = "Publisher19",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book20",
                        Description = "Description of Book20",
                        Content = "Content of Book20",
                        Author = "Author20",
                        ISBN = "ISBN5456",
                        Publisher = "Publisher20",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book21",
                        Description = "Description of Book21",
                        Content = "Content of Book21",
                        Author = "Author21",
                        ISBN = "ISBN5789",
                        Publisher = "Publisher21",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book22",
                        Description = "Description of Book22",
                        Content = "Content of Book22",
                        Author = "Author22",
                        ISBN = "ISBN6123",
                        Publisher = "Publisher22",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 250,
                        StockQuantity = 40
                    },
                    new Book
                    {
                        Title = "Book23",
                        Description = "Description of Book23",
                        Content = "Content of Book23",
                        Author = "Author23",
                        ISBN = "ISBN6456",
                        Publisher = "Publisher23",
                        PublishedDate = DateTime.UtcNow,
                        TotalPageCount = 200,
                        StockQuantity = 30
                    },
                };

                _dbContext.Books.AddRange(books);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
