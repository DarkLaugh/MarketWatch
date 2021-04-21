using System;

namespace MarketWatch.Application.DTOs.Requests
{
    public class CommentRequestModel
    {
        public Guid StockId { get; set; }
        public string CommentContent { get; set; }
        public string Username { get; set; }
    }
}
