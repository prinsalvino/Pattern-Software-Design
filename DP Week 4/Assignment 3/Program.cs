using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {

            // create a tank (and assign it to a driver)
            Tank tank = new Tank();
            tank.AssignDriver();
            // create a robot (and let it move by a person)
            Robot robot = new Robot();
            RobotAdapter robotadapter = new RobotAdapter(robot);
            robotadapter.AssignDriver();

            Console.WriteLine();

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(robotadapter);
            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
