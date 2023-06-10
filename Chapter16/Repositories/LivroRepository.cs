using Chapter16.Contexts;
using Chapter16.Models;

namespace Chapter16.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _context;
        public LivroRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Livro> ListarR()
        {
            return _context.Livros.ToList();
        }       
    }
}
