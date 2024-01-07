using HeightsBookHub.Common;
using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Domain.Entities.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Application.Service.Interface
{
    public interface IBookService
    {
        Task<BaseResponse<PageResult<IEnumerable<BookReturnDto>>>> GetAllBooksAsync(int page, int perPage);
        Task<BaseResponse<BookReturnDto>> GetBookByIdAsync(string bookId);
        Task<BaseResponse<string>> UpdateBookStockAsync(string bookId, int newStockQuantity);
    }
}
