using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Communication.Variable;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    public class AlarmConfig
    {

    }

    public enum AlarmType
    {
        None = 0,
        Info = 1,
        Warning = 2,
        Low = 3,
        Medium = 4,
        High = 5,
        Critical = 6
    }
    
}
