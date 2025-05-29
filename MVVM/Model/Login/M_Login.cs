using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.Model.Pages
{
    public enum NivelAcesso
    {
        OPERADOR,
        SUPERVISOR,
        GERENTE,
        TECNICO,
        SGLASS,
        DEV
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public NivelAcesso Nivel { get; set; }
    }
}
