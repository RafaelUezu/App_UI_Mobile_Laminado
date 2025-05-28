using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Authentication.Login
{
    public class Login_System
    {
        public class Usuario
        {
            public string Nome { get; set; }
            public string Senha { get; set; }
            public UserRole Role { get; set; }
        }

        public enum UserRole
        {
            Operador,
            Supervisor,
            Administrador,
            Tecnico,
            Sglass,
            DEV
        }
    }

    public static class SessaoUsuario
    {
        public static Usuario UsuarioAtual { get; private set; }

        public static void Login(Usuario usuario)
        {
            UsuarioAtual = usuario;
        }

        public static void Logout()
        {
            UsuarioAtual = null;
        }

        public static bool EstaLogado => UsuarioAtual != null;
    }

}
