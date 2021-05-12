using MarketWatch.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MarketWatch.WebUI.Controllers
{
    [Authorize]
    public class StockController : BaseController
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            this._stockService = stockService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStocks()
        {
            var result = await _stockService.GetAllStocksAsync();

            return Ok(result);
        }

        [HttpGet("{stockId}")]
        public async Task<IActionResult> GetStockById(Guid stockId)
        {
            var result = await _stockService.GetStockByIdAsync(stockId);

            return Ok(result);
        }
    }
}
