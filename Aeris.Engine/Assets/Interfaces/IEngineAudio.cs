using NAudio.Wave;

namespace Aeris.Engine.Assets.Interfaces;

public interface IEngineAudio : IEngineAsset
{
    public byte[] Data { get; set; }
    public WaveOut WaveOut { get; set; }
    public WaveStream WaveStream { get; set; }
    
    public void Play();
    public void Stop();
}