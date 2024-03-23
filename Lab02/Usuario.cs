using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Usuario(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool ValidarUsuario(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
