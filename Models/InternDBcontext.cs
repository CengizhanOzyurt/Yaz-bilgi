using Microsoft.EntityFrameworkCore;
 
namespace ProjectForm.Models
{
    public partial class InternDBcontext : DbContext
    {
        public InternDBcontext()
        {
        }

        public InternDBcontext(DbContextOptions options) : base(options)
       {

       }
        public DbSet<UsersModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=C:\\USERS\\CENGIZHAN.OZYURT\\DOCUMENTS\\INTERN.MDF;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
