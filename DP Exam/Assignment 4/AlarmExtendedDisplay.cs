using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class AlarmExtendedDisplay : IAlarmObserver
    {
        IAlarmSystem alarmSystem;
        public AlarmExtendedDisplay(IAlarmSystem alarmSystem)
        {
            this.alarmSystem = alarmSystem;
            alarmSystem.AddObserver(this);
        }
  
        public void Update(DateTime dateTime, string message)
        {
            Console.WriteLine($"[extended alarm-display]: Alarm activated at {dateTime} - {message}");
        }
    }
}
