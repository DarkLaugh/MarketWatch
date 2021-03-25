using MarketWatch.Domain.Common;
using System;

namespace MarketWatch.Domain.Entities
{
    public class Comment : AuditableEntity<Guid>
    {
        public Guid StockId { get; set; }
        public Stock Stock { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string CommentContent { get; set; }
    }
}
