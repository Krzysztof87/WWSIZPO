using System;
using Lamps.Interfaces;
using Lamps.LampsClasses;

namespace Lamps
{
    class LampsController
    {
        protected static ILampThatBeeps deskLamp;
        public ILamp[] lampsCollection = new ILamp[3];

        public LampsController()
        {
            lampsCollection[0] = new WallLamp();
            lampsCollection[1] = new CellLamp();
            lampsCollection[2] = new DeskLamp();
        }

        public void Toggle()
        {
            foreach (ILamp l in lampsCollection)
            {
                bool isLampOn = l.IsOn();

                if (isLampOn)
                {
                    l.TurnOff();
                }
                else
                {
                    l.TurnOn();
                }
            }
        }
    }
}