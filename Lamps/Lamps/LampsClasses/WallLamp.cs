using Lamps.Interfaces;
using System;

namespace Lamps.LampsClasses
{
    class WallLamp : ILamp
    {
        private bool isOn = false;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Lampa ścienna zapalona");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Lampa ścienna zgaszona");
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}