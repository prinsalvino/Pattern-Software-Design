using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class AlarmSystem : IAlarmSystem
    {
        List<IAlarmObserver> observers;
        public DateTime AlarmDateTime { get; set; }
        public string AlarmMessage { get; set; }
        public AlarmSystem()
        {
            observers = new List<IAlarmObserver>();
        }
        public void ActivateAlarm(string message)
        {
            this.AlarmMessage = message;
            AlarmDateTime = DateTime.Now;
            UpdateObserver();
        }

        public void AddObserver(IAlarmObserver alarmObserver)
        {
            observers.Add(alarmObserver);
        }

        public void RemoveObserver(IAlarmObserver alarmObserver)
        {
            observers.Remove(alarmObserver);
        }
        private void UpdateObserver()
        {
            foreach (IAlarmObserver observer in observers)
            {
                observer.Update(AlarmDateTime, AlarmMessage);
            }
        }
    }
}
