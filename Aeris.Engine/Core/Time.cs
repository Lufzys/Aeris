using System.Diagnostics;
using Aeris.Engine.Components.Interfaces;

namespace Aeris.Engine.Components;

public class Time : IEngineScript
{
    private Stopwatch stopWatch;
    private long lastFrameTicks;
    private float elapsedTime;
    private float intervalElapsedMs;

    public float FPS { get; private set; }
    public float FrameCount { get; private set; }
    public float DeltaTime { get; private set; }
    public float FrameTime { get; private set; }
    public float TimeScale { get; set; } = 1.0f;
    
    public void Start()
    {
        stopWatch = Stopwatch.StartNew();
        lastFrameTicks = stopWatch.ElapsedTicks;
    }
    
    public void Process() { }
    public void Update()
    {
        long currentTicks = stopWatch.ElapsedTicks;
        long elapsedTicks = currentTicks - lastFrameTicks;
        lastFrameTicks = currentTicks;

        elapsedTime = elapsedTicks / (float)Stopwatch.Frequency;
        intervalElapsedMs+=elapsedTime;
        DeltaTime = Math.Max(elapsedTime * TimeScale, 0.0001f); 
        FrameTime = DeltaTime * 1000.0f;
        FrameCount++;
        if (intervalElapsedMs > 1f) {
            intervalElapsedMs = 0;
            FPS = 1.0f / DeltaTime;
        }
    }
}
