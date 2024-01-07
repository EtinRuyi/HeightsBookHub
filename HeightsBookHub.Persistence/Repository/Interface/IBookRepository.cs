using HeightsBookHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Persistence.Repository.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>>GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(string id);
        Task UpdateStockAsync(string bookId, int quantity);
    }
}
