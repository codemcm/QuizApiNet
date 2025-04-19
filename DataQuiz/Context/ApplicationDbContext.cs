using Dto;
using Microsoft.EntityFrameworkCore;

namespace DataQuiz.Context;

    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, string connectionString) :
            base(options)
        {
            this._connectionString = connectionString;
        }
        public DbSet<Categoria> Categoria { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}
        
