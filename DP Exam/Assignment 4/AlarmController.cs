using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class AlarmController : IAlarmController
    {
        IAlarmSystem alarmSystem;
       
        public AlarmController(IAlarmSystem alarmSystem)
        {
            this.alarmSystem = alarmSystem;
        }
        public void ActivateAlarm(string message)
        {
            alarmSystem.ActivateAlarm(message);
        }
    }
}
