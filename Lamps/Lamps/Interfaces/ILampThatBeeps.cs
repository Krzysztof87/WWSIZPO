namespace Lamps.Interfaces
{
    interface ILampThatBeeps
    {
        void TurnOn();
        void TurnOff();
        void DoBeep();
        bool IsOn();
    }
}