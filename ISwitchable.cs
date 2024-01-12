using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukosS.O.L.I.D_
{
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }

    public class LightSwitch : ISwitchable
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
        private ISwitchable switchable;

        public Room(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Enter()
        {
            switchable.TurnOn();
        }

        public void Exit()
        {
            switchable.TurnOff();
        }
    }
}
