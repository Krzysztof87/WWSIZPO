using Lamps.Interfaces;
using System;

namespace Lamps.LampsClasses
{
    class CellLampThatBeeps : ILampThatBeeps
    {
        private bool isOn = false;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Lampa sufitowa dźwiękowa zapalona");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Lampa sufitowa dźwiękowa zgaszona");
        }

        public bool IsOn()
        {
            return isOn;
        }

        public void DoBeep()
        {
            Console.WriteLine("Lampa sufitowa wydaje dźwięk");
        }
    }
}