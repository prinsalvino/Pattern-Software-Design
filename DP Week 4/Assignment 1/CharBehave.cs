using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Queen : Character
    {
        public Queen()
        {
            Weapon = new KnifeBehaviour();
        }
    }
    class Knight : Character
    {

        public Knight()
        {
            Weapon = new SwordBehaviour();
        }
    }
    class Troll : Character
    {

        public Troll()
        {
            Weapon = new AxeBehaviour();
        }
    }
    class King : Character
    {

        public King()
        {
            Weapon = new BowAndArrowBehaviour();
        }
    }
}
