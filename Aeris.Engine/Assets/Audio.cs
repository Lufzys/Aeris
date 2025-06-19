using Aeris.Engine.Assets.Interfaces;
using NAudio.Wave;

namespace Aeris.Engine.Assets;

public class Audio : IEngineAudio
{
    public static string[] Extensions { get; } = new[] { ".wav", ".mp3" };
    public string Path { get; }
    public uint Id { get; set; }
    public byte[] Data { get; set; }
    public WaveOut WaveOut { get; set; }
    public WaveStream WaveStream { get; set; }

    public Audio(string path)
    {
        Path = path;
        Data = File.ReadAllBytes(Path);
        var memoryStream = new MemoryStream(Data);
        WaveStream = new RawSourceWaveStream(memoryStream, new WaveFormat());
        WaveOut = new WaveOut();
        WaveOut.Init(WaveStream);
        Id = (uint)Assets.Audio.Count;
        Assets.Audio.Add(this);
    }
    
    public void Play()
    {
        if (WaveOut.PlaybackState != PlaybackState.Playing)
        {
            WaveStream.Position = 0;
            WaveOut.Play();
        }
    }

    public void Stop()
    {
        WaveOut?.Stop();
    }
    
    public void Dispose()
    {
        Stop();
        WaveOut?.Dispose();
        WaveStream?.Dispose();
    }
}