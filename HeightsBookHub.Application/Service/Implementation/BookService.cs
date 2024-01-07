using HeightsBookHub.Application.Service.Interface;
using HeightsBookHub.Common;
using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Domain.Entities.SharedEntities;
using HeightsBookHub.Persistence.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Application.Service.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        //public async Task<BaseResponse<IEnumerable<BookReturnDto>>> GetAllBooksAsync(int page, int perPage)
        //{
        //    try
        //    {
        //        var allBooks = await _bookRepository.GetAllBooksAsync();
        //        var pagedBooks = await Pagination<Book>.GetPager(allBooks, perPage, page, b => b.Title, b => b.Id.ToString());

        //        var bookDtoList = pagedBooks.Data.Select(book => new BookReturnDto
        //        {
        //            Id = book.Id,
        //            Title = book.Title,
        //            Description = book.Description,
        //            Content = book.Content,
        //            Author = book.Author,
        //            ISBN = book.ISBN,
        //            Publisher = book.Publisher,
        //            PublishedDate = book.PublishedDate,
        //            TotalPageCount = book.TotalPageCount,
        //            StockQuantity = book.StockQuantity,
        //            CreatedAt = book.CreatedAt,
        //            UpdatedAt = book.UpdatedAt
        //        }).ToList();

        //        var pagedBookDto = new PageResult<IEnumerable<BookReturnDto>>
        //        {
        //            Data = bookDtoList,
        //            TotalPageCount = pagedBooks.TotalPageCount,
        //            CurrentPage = pagedBooks.CurrentPage,
        //            PerPage = pagedBooks.PerPage,
        //            TotalCount = pagedBooks.TotalCount
        //        };

        //        return BaseResponse<PageResult<IEnumerable<BookReturnDto>>>.Success(pagedBookDto, "Books retrieved successfully", 200);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BaseResponse<PageResult<IEnumerable<BookReturnDto>>>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
        //    }
        //}

        public async Task<BaseResponse<PageResult<IEnumerable<BookReturnDto>>>> GetAllBooksAsync(int page, int perPage)
        {
            try
            {
                var allBooks = await _bookRepository.GetAllBooksAsync();
                var pagedBooks = await Pagination<Book>.GetPager(allBooks, perPage, page, b => b.Title, b => b.Id.ToString());

                var bookDtoList = pagedBooks.Data.Select(book => new BookReturnDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    Content = book.Content,
                    Author = book.Author,
                    ISBN = book.ISBN,
                    Publisher = book.Publisher,
                    PublishedDate = book.PublishedDate,
                    TotalPageCount = book.TotalPageCount,
                    StockQuantity = book.StockQuantity,
                    CreatedAt = book.CreatedAt,
                    UpdatedAt = book.UpdatedAt
                }).ToList();

                var pagedBookDto = new PageResult<IEnumerable<BookReturnDto>>
                {
                    Data = bookDtoList,
                    TotalPageCount = pagedBooks.TotalPageCount,
                    CurrentPage = pagedBooks.CurrentPage,
                    PerPage = pagedBooks.PerPage,
                    TotalCount = pagedBooks.TotalCount
                };

                return BaseResponse<PageResult<IEnumerable<BookReturnDto>>>.Success(pagedBookDto, "Books retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return BaseResponse<PageResult<IEnumerable<BookReturnDto>>>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }


        public async Task<BaseResponse<BookReturnDto>> GetBookByIdAsync(string bookId)
        {
            try
            {
                var book = await _bookRepository.GetBookByIdAsync(bookId);

                if (book == null)
                    return BaseResponse<BookReturnDto>.Failed(false, "Book not found", 404, new List<string> { "Book not found" });

                var bookDto = new BookReturnDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    Content = book.Content,
                    Author = book.Author,
                    ISBN = book.ISBN,
                    Publisher = book.Publisher,
                    PublishedDate = book.PublishedDate,
                    TotalPageCount = book.TotalPageCount,
                    StockQuantity = book.StockQuantity,
                    CreatedAt = book.CreatedAt,
                    UpdatedAt = book.UpdatedAt
                };

                return BaseResponse<BookReturnDto>.Success(bookDto, "Book retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return BaseResponse<BookReturnDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }

        public async Task<BaseResponse<string>> UpdateBookStockAsync(string bookId, int newStockQuantity)
        {
            try
            {
                await _bookRepository.UpdateStockAsync(bookId, newStockQuantity);
                return BaseResponse<string>.Success("Stock quantity updated successfully", "Stock quantity updated successfully", 200);
            }
            catch (Exception ex)
            {
                return BaseResponse<string>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using HeightsBookHub.Application.Service.Interface;
//using HeightsBookHub.Common;
//using HeightsBookHub.Domain.DTOs;
//using HeightsBookHub.Domain.Entities;
//using HeightsBookHub.Domain.Entities.SharedEntities;
//using HeightsBookHub.Persistence.Repository.Interface;

//namespace HeightsBookHub.Application.Service.Implementation
//{
//    public class BookService : IBookService
//    {
//        private readonly IBookRepository _bookRepository;

//        public BookService(IBookRepository bookRepository)
//        {
//            _bookRepository = bookRepository;
//        }

//        public async Task<BaseResponse<IEnumerable<BookReturnDto>>> GetAllBooksAsync(int page, int perPage)
//        {
//            try
//            {
//                var allBooks = await _bookRepository.GetAllBooksAsync();

//                var pagedBooks = await Pagination<Book>.GetPager(allBooks, perPage, page, b => b.Title, b => b.Id);

//                var bookReturnDtos = new List<BookReturnDto>();
//                foreach (var book in pagedBooks.Data)
//                {
//                    bookReturnDtos.Add(MapBookEntityToDto(book));
//                }

//                var response = new BaseResponse<IEnumerable<BookReturnDto>>(
//                    true, "Books retrieved successfully.", pagedBooks.TotalPageCount)
//                {
//                    Data = bookReturnDtos
//                };

//                return response;
//            }
//            catch (Exception ex)
//            {
//                return new BaseResponse<IEnumerable<BookReturnDto>>(
//                    false, $"Error retrieving books: {ex.Message}", 500);
//            }
//        }

//        public async Task<BaseResponse<BookReturnDto>> GetBookByIdAsync(string bookId)
//        {
//            try
//            {
//                var book = await _bookRepository.GetBookByIdAsync(bookId);

//                if (book == null)
//                {
//                    return new BaseResponse<BookReturnDto>(false, "Book not found.", 404);
//                }

//                var bookReturnDto = MapBookEntityToDto(book);

//                return new BaseResponse<BookReturnDto>(true, "Book retrieved successfully.", 200);
//            }
//            catch (Exception ex)
//            {
//                return new BaseResponse<BookReturnDto>(false, $"Error retrieving book: {ex.Message}", 500);
//            }
//        }

//        public async Task<BaseResponse<string>> UpdateBookStockAsync(string bookId, int newStockQuantity)
//        {
//            try
//            {
//                var existingBook = await _bookRepository.GetBookByIdAsync(bookId);

//                if (existingBook == null)
//                {
//                    return new BaseResponse<string>(false, "Book not found.", 404);
//                }

//                await _bookRepository.UpdateStockAsync(bookId, newStockQuantity);

//                return new BaseResponse<string>(true, "Book stock updated successfully.", 200);
//            }
//            catch (Exception ex)
//            {
//                return new BaseResponse<string>(false, $"Error updating book stock: {ex.Message}", 500);
//            }
//        }

//        private BookReturnDto MapBookEntityToDto(Book book)
//        {
//            return new BookReturnDto
//            {
//                Id = book.Id,
//                Title = book.Title,
//                Description = book.Description,
//                Content = book.Content,
//                Author = book.Author,
//                ISBN = book.ISBN,
//                Publisher = book.Publisher,
//                PublishedDate = book.PublishedDate,
//                TotalPageCount = book.TotalPageCount,
//                StockQuantity = book.StockQuantity,
//                CreatedAt = book.CreatedAt,
//                UpdatedAt = book.UpdatedAt
//            };
//        }
//    }
//}
