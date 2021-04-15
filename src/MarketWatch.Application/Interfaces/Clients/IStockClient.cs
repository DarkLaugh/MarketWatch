using MarketWatch.Application.DTOs.Responses;
using System.Threading.Tasks;

namespace MarketWatch.Application.Interfaces.Clients
{
    public interface IStockClient
    {
        Task StockUpdate(StockChangedResponseModel data);
        Task AddedComment(CommentResponseModel comment);
    }
}
