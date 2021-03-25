using MarketWatch.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketWatch.Domain.Entities
{
    public class Stock : BaseEntity<Guid>
    {
        public string ClassName { get; set; }
        public string Exchange { get; set; }
        public string Symbol { get; set; }
        public string Status { get; set; }
        public bool Tradable { get; set; }
        public bool Marginable { get; set; }
        public bool Shortable { get; set; }
        public bool EasyToBorrow { get; set; }
        public decimal Price { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
