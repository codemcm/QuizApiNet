using DataQuiz.Context;
using Dto;
using Microsoft.EntityFrameworkCore;

namespace DataQuiz
{
    public class CategoriaEntity
    {
        private readonly ApplicationDbContext _context;

        public CategoriaEntity(string connectionString)
        {
            _context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>(), connectionString);
        }
        public async Task<List<Categoria>> GetAllCategoriasAsync()
        {
            return await _context.Categoria.ToListAsync();
        }

        public async Task<Categoria> AddNew(Categoria categoria)
        {
            var categoriaNew = _context.Categoria.Add(categoria);
            await _context.SaveChangesAsync();
            return categoriaNew.Entity;
        }

        public async Task<Categoria> Update(Categoria categoria)
        {
            var categoriaUpdate = _context.Categoria.Update(categoria);
            await _context.SaveChangesAsync();
            return categoriaUpdate.Entity;
        }
    }
}
