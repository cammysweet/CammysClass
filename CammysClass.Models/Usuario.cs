using System;

namespace CammysClass.Models
{
    public class Usuario
    {
        public UsuarioTipo UsuarioTipo { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


    }
}
