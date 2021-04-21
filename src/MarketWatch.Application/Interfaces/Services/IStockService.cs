using MarketWatch.Application.DTOs.Requests;
using MarketWatch.Application.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWatch.Application.Interfaces.Services
{
    public interface IStockService
    {
        Task<IEnumerable<StockResponseModel>> GetAllStocksAsync();
        Task<string[]> GetStockSymbols();
        Task<StockResponseModel> GetStockByIdAsync(Guid stockId);
        Task<CommentResponseModel> AddCommentToStock(CommentRequestModel commentRequest);
    }
}
