using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }
        public Character()
        {
            Weapon = new KnifeBehaviour();
        }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
