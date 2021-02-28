using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.Models
{
    public class AppUser : IdentityUser
    {
        public short UserType { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
