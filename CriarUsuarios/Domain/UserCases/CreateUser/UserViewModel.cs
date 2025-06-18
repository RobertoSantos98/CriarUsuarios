namespace CriarUsuarios.Domain.UserCases.CreateUser
{
    public class UserViewModel
    {

        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public UserViewModel(string nome, string email, string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
        }

    }
}
