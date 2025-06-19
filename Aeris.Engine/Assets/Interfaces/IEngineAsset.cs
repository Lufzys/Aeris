namespace Aeris.Engine.Assets.Interfaces;

public interface IEngineAsset : IDisposable
{
    public uint Id { get; set; }
    public string Path { get; }
}