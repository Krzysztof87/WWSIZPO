using Lamps.Interfaces;
using System;

namespace Lamps.LampsClasses
{
    class DeskLamp : ILamp
    {
        private bool isOn = false;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Lampa stołowa zapalona");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Lampa stołowa zgaszona");
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}