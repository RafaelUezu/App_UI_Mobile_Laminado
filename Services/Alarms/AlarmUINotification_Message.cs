using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    public sealed partial class AlarmUINotification
    {
        private readonly AlarmEngine _engine;
        private bool _attached;
        public AlarmUINotification(AlarmEngine engine)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        public void Attach()
        {
            if (_attached) return;

            _engine.AlarmActivated += OnAlarmActivated;
            _engine.AlarmCleared += OnAlarmCleared;
            _engine.AlarmReadError += OnAlarmReadError;

            _attached = true;
        }

        private void OnAlarmActivated(AlarmInput alarm, DateTimeOffset whenUtc)
        {

        }

        private void OnAlarmCleared(AlarmInput alarm, DateTimeOffset whenUtc)
        {

        }

        private void OnAlarmReadError(AlarmInput alarm, Exception ex)
        {

        }

        private void LabelMessage

    }
}
