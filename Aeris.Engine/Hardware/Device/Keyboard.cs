using Aeris.Engine.Hardware.Enums;
using Aeris.Engine.Hardware.Interfaces;

namespace Aeris.Engine.Hardware.Device;

public class Keyboard : IInputDevice
{
    public bool[] CurrentKeyStates = new bool[(int)Enum.GetValues<VirtualKey>().Max() + 1];
    public bool[] PreviousKeyStates = new bool[(int)Enum.GetValues<VirtualKey>().Max() + 1];

    public bool IsKeyDown(VirtualKey key) => CurrentKeyStates[(int)key] && !PreviousKeyStates[(int)key];
    public bool IsKeyUp(VirtualKey key) => !CurrentKeyStates[(int)key] && PreviousKeyStates[(int)key];
    public bool IsKeyHeld(VirtualKey key) => CurrentKeyStates[(int)key] && PreviousKeyStates[(int)key];
    
    public void Process() 
    {
        foreach (VirtualKey key in Enum.GetValues(typeof(VirtualKey)))
        {
            CurrentKeyStates[(int)key] = Win32.PInvoke.GetAsyncKeyState((short)key) != 0;
        }
    }

    public void Update()
    {
        Array.Copy(CurrentKeyStates, PreviousKeyStates, CurrentKeyStates.Length);
    }
}