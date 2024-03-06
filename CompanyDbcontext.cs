using Microsoft.EntityFrameworkCore;

namespace appmvc.Models
{
    public class CompanyDbcontext : DbContext
    {
        public CompanyDbcontext(DbContextOptions<CompanyDbcontext> options) : base(options)
        {
            
        }
        public DbSet<CompanyModel> Companies { get; set; }
    }
}
