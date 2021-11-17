using Lamps.Interfaces;
using System;

namespace Lamps.LampsClasses
{
    class WallLampThatBeeps : ILampThatBeeps, ILamp
    {
        private bool isOn = false;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Lampa ścienna dźwiękowa zapalona");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Lampa ścienna dźwiękowa zgaszona");
        }

        public bool IsOn()
        {
            return isOn;
        }

        public void DoBeep()
        {
            Console.WriteLine("Lampa ścienna wydaje dźwięk");
        }
    }
}