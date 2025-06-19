using Aeris.Engine.Hardware;
using Aeris.Engine.Windows;

namespace Aeris.Engine.Components.Interfaces;

public abstract class GameScene
{
    public List<IEngineComponent> Components { get; } = new List<IEngineComponent>();
    public Time Time { get; } = new Time();
    public Input Input { get; } = new Input();

    public virtual void Load()
    {
        Time.Start();
        Input.Start();
    }

    public virtual void Process()
    {
        Time.Process();
        Input.Process();
    }
    public virtual void Render() {}

    public virtual void Update()
    {
        Time.Update();
        Input.Update();
    }
    public virtual void Unload() { }
}