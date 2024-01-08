using HeightsBookHub.Domain.Entities;

namespace HeightsBookHub.Persistence.Repository.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>>GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(string id);
        Task UpdateStockAsync(string bookId, int quantity);
    }
}
