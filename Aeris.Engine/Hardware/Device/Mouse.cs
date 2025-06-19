using System.Numerics;
using Aeris.Engine.Hardware.Enums;
using Aeris.Engine.Hardware.Interfaces;

namespace Aeris.Engine.Hardware.Device;

public class Mouse : IInputDevice
{
    public bool[] CurrentButtonStates = new bool[(int)Enum.GetValues<MouseButton>().Max() + 1];
    public bool[] PreviousButtonStates = new bool[(int)Enum.GetValues<MouseButton>().Max() + 1];
    
    public bool IsButtonDown(MouseButton key) => CurrentButtonStates[(int)key] && !PreviousButtonStates[(int)key];
    public bool IsButtonUp(MouseButton key) => !CurrentButtonStates[(int)key] && PreviousButtonStates[(int)key];
    public bool IsButtonHeld(MouseButton key) => CurrentButtonStates[(int)key] && PreviousButtonStates[(int)key];
    private Vector2 GetMousePos() => Win32.PInvoke.GetCursorPos(out var point) ? new Vector2(point.X, point.Y) : new Vector2(0, 0);
    public Vector2 MousePos { get; private set; }
    public Vector2 DeltaMousePos  { get; private set; }
    
    public void Process()
    {
        MousePos = GetMousePos();
        foreach (MouseButton key in Enum.GetValues(typeof(MouseButton)))
        {
            CurrentButtonStates[(int)key] = Win32.PInvoke.GetAsyncKeyState((short)key) != 0;
        }
    }

    public void Update()
    {
        Vector2 CurrentMousePos = GetMousePos();
        DeltaMousePos = MousePos - CurrentMousePos;
        MousePos = CurrentMousePos;
        Array.Copy(CurrentButtonStates, PreviousButtonStates, CurrentButtonStates.Length);
    }
}