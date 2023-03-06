using Microsoft.EntityFrameworkCore;


namespace LePortail.Models
{
    public class PortailDB:DbContext
    {
        public DbSet<Candidat> Candidat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-39MFKEK; initial catalog=PortailDB; integrated security=SSPI; TrustServerCertificate=True; ");

        }
    }
}
