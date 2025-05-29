using App_UI_Mobile_Laminado.MVVM.Model.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.db.Login
{
    public static class UsuariosDB
    {
        public static List<Usuario> Usuarios = new()
        {
            new Usuario { Nome = "OPERADOR", Senha = "OPE299", Nivel = NivelAcesso.OPERADOR },
            new Usuario { Nome = "SUPERVISOR", Senha = "SUP792", Nivel = NivelAcesso.SUPERVISOR },
            new Usuario { Nome = "GERENTE", Senha = "GER458", Nivel = NivelAcesso.GERENTE },
            new Usuario { Nome = "TECNICO", Senha = "TECACF", Nivel = NivelAcesso.TECNICO },
            new Usuario { Nome = "SGLASS", Senha = "ACF", Nivel = NivelAcesso.SGLASS },
            new Usuario { Nome = "DEV", Senha = "DEV!@#", Nivel = NivelAcesso.DEV }
        };

        public static Usuario? ValidarLogin(string nome, string senha)
        {
            return Usuarios.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);
        }
    }
}
