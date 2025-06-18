using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CriarUsuarios.Domain.UserCases.CreateUser
{
    [ApiController]
    [Route("/v1/createUser")]
    public class CreateUserController : ControllerBase
    {

        private readonly CreateUserUseCase _userCase;

        public CreateUserController(CreateUserUseCase repository)
        {
            _userCase = repository;
        }



        [HttpPost]
        public async Task<IActionResult> CreateUser(UserViewModel user)
        {
            try
            {
                await _userCase.Execute(user);

                return Ok();

            } catch(Exception ex)
            {
                throw new Exception("Não foi possivel fazer a solicitação!", ex);
            }
        }
    }
}
