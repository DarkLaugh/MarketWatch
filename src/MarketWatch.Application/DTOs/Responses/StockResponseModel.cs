using System;
using System.Collections.Generic;

namespace MarketWatch.Application.DTOs.Responses
{
    public class StockResponseModel
    {
        public Guid Id { get; set; }
        public string ClassName { get; set; }
        public string Exchange { get; set; }
        public string Symbol { get; set; }
        public string Status { get; set; }
        public bool Tradable { get; set; }
        public bool Marginable { get; set; }
        public bool Shortable { get; set; }
        public bool EasyToBorrow { get; set; }
        public decimal Price { get; set; }
        public List<CommentResponseModel> Comments { get; set; }
    }
}
