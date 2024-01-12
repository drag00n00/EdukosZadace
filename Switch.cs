using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukosS.O.L.I.D_
{
    public class LightSwitch
    {
        public void TurnOn()
        {
            // Code to turn on the light
        }

        public void TurnOff()
        {
            // Code to turn off the light
        }
    }

    public class Room
    {
        private LightSwitch lightSwitch = new LightSwitch();

        public void Enter()
        {
            lightSwitch.TurnOn();
        }

        public void Exit()
        {
            lightSwitch.TurnOff();
        }
    }
}
