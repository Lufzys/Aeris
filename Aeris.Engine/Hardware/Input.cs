using System.Numerics;
using Aeris.Engine.Components.Interfaces;
using Aeris.Engine.Hardware.Device;
using Aeris.Engine.Hardware.Enums;
using Aeris.Engine.Hardware.Interfaces;

namespace Aeris.Engine.Hardware;

public class Input : IInputSystem, IEngineScript
{
    public readonly Keyboard Keyboard = new Keyboard();
    public readonly Mouse Mouse = new Mouse();

    public bool IsKeyDown(VirtualKey key) => Keyboard.IsKeyDown(key);

    public bool IsKeyUp(VirtualKey key) => Keyboard.IsKeyUp(key);

    public bool IsKeyHeld(VirtualKey key) => Keyboard.IsKeyHeld(key);

    public bool IsButtonDown(MouseButton button) => Mouse.IsButtonDown(button);

    public bool IsButtonUp(MouseButton button) => Mouse.IsButtonUp(button);

    public bool IsButtonHeld(MouseButton button) => Mouse.IsButtonHeld(button);

    public Vector2 MousePos => Mouse.MousePos;

    public Vector2 DeltaMousePos => Mouse.DeltaMousePos;
    
    public void Start() { }
    
    public void Process()
    {
        Keyboard.Process();
        Mouse.Process();
    }

    public void Update()
    {
        Keyboard.Update();
        Mouse.Update();
    }
}