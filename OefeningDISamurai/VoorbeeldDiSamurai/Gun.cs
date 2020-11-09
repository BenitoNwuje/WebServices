using System;
using System.Collections.Generic;
using System.Text;

namespace VoorbeeldDiSamurai
{
    class Gun : IWeapon
    {
        private ITrigger _trigger;
        public Gun(ITrigger trigger)
        {
            this._trigger = trigger;
        }
        public void Hit(string target)
        {
            Console.Write($"{target} got shut by a ");
            this._trigger.Pull();
        }
    }
}
