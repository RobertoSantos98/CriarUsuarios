using CriarUsuarios.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CriarUsuarios.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ConnectionContext _context;

        public UserRepository(ConnectionContext context)
        {
            _context = context;
        }

        public async Task<User> FindByEmail(string email)
        {
            try
            {
                var dados = await _context.User.FirstOrDefaultAsync(user => user.email == email);

                if (dados == null)
                {
                    throw new Exception("Usuario não encontrado!");
                }

                return dados;
            } catch(Exception ex)
            {
                throw new Exception("Erro no servidor!", ex);
            }
        }

        public async Task Save(User user)
        {
            try
            {
                await _context.User.AddAsync(user);
                await _context.SaveChangesAsync();

            } catch(Exception ex)
            {
                throw new Exception("Erro no servidor!", ex);
            }
        }
    }
}
