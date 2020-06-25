using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        private void Start()
        {
            // create alarmsystem
            IAlarmSystem alarmSystem = new AlarmSystem();

            // create controller
            IAlarmController controller = new AlarmController(alarmSystem);

            // create displays
            IAlarmObserver alarmDisplay = new AlarmDisplay(alarmSystem);
            IAlarmObserver alarmdisplayextended = new AlarmExtendedDisplay(alarmSystem);
            // activate the alarm system a few times (for testing)
            controller.ActivateAlarm("backdoor is open");
            Console.WriteLine();
            controller.ActivateAlarm("smoke in room H1-10");
            Console.WriteLine();
        }
    }
}
