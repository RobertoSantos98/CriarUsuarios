using System.ComponentModel.DataAnnotations;

namespace CriarUsuarios.Domain.Models
{
    public class User
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }

        public User(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }

    }
}
