using UnitTest.Data.Context;
using UnitTest.Data.Interface;
using UnitTest.Data.Model;

namespace UnitTest.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly TestDbContext _context;

        public ClienteRepository(TestDbContext context)
        {
            _context = context;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }
    }
}
