using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MarketWatch.Domain.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Comment> Comments { get; set; }
    }
}
