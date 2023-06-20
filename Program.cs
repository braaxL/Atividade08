using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                List<User> users = new List<User>();

                // Adicionando usuários à lista
                users.Add(new User("João", "joao@gmail.com"));
                users.Add(new User("Maria", "maria@hotmail.com"));
                users.Add(new User("Pedro", "pedro@yahoo.com"));

                // Buscando usuário por email
                string email = "maria@hotmail.com";
                User user = users.Find(u => u.Email == email);

                if (user != null)
                {
                    Console.WriteLine($"Usuário encontrado: {user.Name}");
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado");
                }
            }
        }

        class User
        {
            public string Name { get; set; }
            public string Email { get; set; }

            public User(string name, string email)
            {
                Name = name;
                Email = email;
            }

            
        }
    }
}
