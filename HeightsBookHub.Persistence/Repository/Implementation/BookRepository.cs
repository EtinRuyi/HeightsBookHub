using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Persistence.DbContext;
using HeightsBookHub.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace HeightsBookHub.Persistence.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly HeightsBHDbContext _dbContext;
        public BookRepository(HeightsBHDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(string id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task UpdateStockAsync(string bookId, int quantity)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            if (book != null)
            {
                book.StockQuantity = quantity;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
    














    //        public async void UpdateStockAsync(int bookId, int quantity)
    //        {
    //            var book = await GetBookByIdAsync(bookId.ToString());
    //            book.StockQuantity = quantity;
    //            _dbContext.Update(book);
    //            _dbContext.SaveChanges();
    //        }


    //    public async void UpdateStock2(int bookId, int quantitySold)
    //    {
    //        var book = await GetBookByIdAsync(bookId.ToString());
    //        int qty = book.StockQuantity;
    //        int remaining = qty - quantitySold;
    //        if (remaining > -1)
    //        {
    //            book.StockQuantity = remaining;
    //            _dbContext.Update(book);
    //            _dbContext.SaveChanges();
    //        }
    //    }
    //}
}
