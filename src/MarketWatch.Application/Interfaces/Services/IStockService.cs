using MarketWatch.Application.DTOs.Requests;
using MarketWatch.Application.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWatch.Application.Interfaces.Services
{
    public interface IStockService
    {
        Task<IEnumerable<StockResponse>> GetAllStocksAsync();
        Task<string[]> GetStockSymbols();
        Task<StockResponse> GetStockByIdAsync(Guid stockId);
        Task<CommentResponse> AddCommentToStock(CommentRequest commentRequest);
    }
}
