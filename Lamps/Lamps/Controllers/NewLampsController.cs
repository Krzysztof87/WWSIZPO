using System;
using Lamps.Interfaces;
using Lamps.LampsClasses;

namespace Lamps
{
    class NewLampsController : LampsController
    {
        private ILampThatBeeps[] lampsCollection = new ILampThatBeeps[2];
        
        public NewLampsController()
        {
            lampsCollection[0] = new WallLampThatBeeps();
            lampsCollection[1] = new CellLampThatBeeps();
            //lampsCollection[2] = LampsController.WallLamp();
            //lampsCollection[3] = LampsController.CellLamp();
            //lampsCollection[4] = LampsController.deskLamp;
        }

        public void MakeSound()
        {
            foreach (ILampThatBeeps bl in lampsCollection)
            {
                bl.DoBeep();
            }
        }

        public void Toggle()
        {
            foreach (ILampThatBeeps l in lampsCollection)
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