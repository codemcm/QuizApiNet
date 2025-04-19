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
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> AddNew(Categoria categoria)
        {
            var categoriaNew = _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return categoriaNew.Entity;
        }

        public async Task<Categoria> Update(Categoria categoria)
        {
            var categoriaUpdate = _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
            return categoriaUpdate.Entity;
        }
    }
}
