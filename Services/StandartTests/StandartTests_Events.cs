using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.StandartTests
{
    #region Eventos da classe StandartTests_Evento
    public static class StandartTests_Events
    {
        public static event Func<Task>? Evento1;
        public static event Func<Task>? Evento2;
        public static event Func<Task>? Evento3;
        private static async Task DispararAsync(Func<Task>? evento)
        {
            if (evento != null)
            {
                var handlers = evento.GetInvocationList().Cast<Func<Task>>();
                foreach (var handler in handlers)
                {
                    await handler();
                }
            }
        }
        public static Task DispararEvento1() => DispararAsync(Evento1);
        public static Task DispararEvento2() => DispararAsync(Evento2);
        public static Task DispararEvento3() => DispararAsync(Evento3);
    }
    #endregion
}
