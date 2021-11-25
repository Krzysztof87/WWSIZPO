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
                bl.TurnOn();
                bl.TurnOff();
            }
        }

    }
}