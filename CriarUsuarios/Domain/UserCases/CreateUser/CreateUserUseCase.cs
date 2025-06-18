using CriarUsuarios.Domain.Models;
using CriarUsuarios.Infrastructure.Repositories;

namespace CriarUsuarios.Domain.UserCases.CreateUser
{
    public class CreateUserUseCase
    {
        private readonly IUserRepository _repository;

        public CreateUserUseCase(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task Execute(UserViewModel createUser)
        {
            var userAlreadyExist = await _repository.FindByEmail(createUser.email);

            if (userAlreadyExist != null)
            {
                throw new Exception("User alredy exist");
            }

            var user = new User(createUser.nome, createUser.email, createUser.password);

            _repository.Save(user);
        }
    }
}
