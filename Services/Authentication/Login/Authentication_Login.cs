using App_UI_Mobile_Laminado.MVVM.Model.Pages;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages;
using App_UI_Mobile_Laminado.Services.db.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Authentication.Login
{
    public static class ControleAcesso
    {
        public static bool TemPermissao(NivelAcesso requerido)
        {
            /*
            if (Application.Current.Properties.TryGetValue("NivelAcesso", out var nivelObj)
                && nivelObj is int nivel)
            {
                return nivel >= (int)requerido;
            }
            */
            return false;
        }
    }
}
