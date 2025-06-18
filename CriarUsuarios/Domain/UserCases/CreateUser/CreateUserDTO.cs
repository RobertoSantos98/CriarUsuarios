namespace CriarUsuarios.Domain.UserCases.CreateUser
{
    public class CreateUserDTO
    {
        public string nome { get; set; }
        public string email { get; set; }

        public CreateUserDTO(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
