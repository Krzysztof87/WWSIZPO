using Lamps.Interfaces;
using System;

namespace Lamps.LampsClasses
{
    class CellLamp : ILamp
    {
        private bool isOn = false;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Lampa sufitowa zapalona");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Lampa sufitowa zgaszona");
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}