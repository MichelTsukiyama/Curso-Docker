using MVC2.Data;

namespace MVC2.Models
{
    public class ProdutoRepository : IRepository
    {
        private AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos;
    }
}