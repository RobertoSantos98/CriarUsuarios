using CriarUsuarios.Domain.Models;

namespace CriarUsuarios.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        public Task<User> FindByEmail(string email);
        public Task Save(User user);
    }
}
