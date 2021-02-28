using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain.Data
{
    public class DataContext: IdentityDbContext<AppUser>
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }
    }

}
