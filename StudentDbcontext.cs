using Microsoft.EntityFrameworkCore;

namespace appmvc.Models
{
    public class StudentDbcontext : DbContext
    {
        public StudentDbcontext(DbContextOptions<StudentDbcontext> options) : base(options) 
        {
            
        }
        public DbSet<SDIstudent> Students { get; set; }
    }
}
