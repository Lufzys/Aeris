using Aeris.Engine.Components;
using Aeris.Engine.Components.Interfaces;
using Aeris.Engine.Hardware;
using Aeris.Engine.Hardware.Enums;
using Aeris.Engine.Windows;

namespace Aeris.Game;

public class MainScene : GameScene
{
    public override void Load()
    {
        Console.WriteLine("[x] Scene loaded.");
        base.Load();
    }

    public override void Process()
    {
        base.Process();
    }

    public override void Render() { base.Render();}

    public override void Update()
    {   
        if (Input.IsKeyDown(VirtualKey.Escape))
        {
            Console.WriteLine(VirtualKey.Escape);
        }
        base.Update();
    }

    public override void Unload()
    {
        Console.WriteLine("[x] Scene unloaded.");
        base.Unload();
    }
}