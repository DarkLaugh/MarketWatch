using MarketWatch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketWatch.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Stock> Stocks { get; set; }
    }
}
