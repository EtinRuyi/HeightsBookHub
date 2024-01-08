using HeightsBookHub.Common;
using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace HeightsBookHub.Application.Service.Interface
{
    public interface IBookService
    {
        Task<BaseResponse<PageResult<IEnumerable<BookReturnDto>>>> GetAllBooksAsync(int page, int perPage);
        Task<BaseResponse<BookReturnDto>> GetBookByIdAsync(string bookId);
        Task<BaseResponse<string>> UpdateBookStockAsync(string bookId, int newStockQuantity);
    }
}
