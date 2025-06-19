using System.Numerics;
using Aeris.Engine.Hardware.Enums;

namespace Aeris.Engine.Hardware.Interfaces;

public interface IInputSystem
{
    public bool IsKeyDown(VirtualKey key);
    public bool IsKeyUp(VirtualKey key);
    public bool IsKeyHeld(VirtualKey key);
    
    public bool IsButtonDown(MouseButton key);
    public bool IsButtonUp(MouseButton key);
    public bool IsButtonHeld(MouseButton key);
    public Vector2 MousePos { get; }
    public Vector2 DeltaMousePos { get; }

    public void Process();
    public void Update();
}