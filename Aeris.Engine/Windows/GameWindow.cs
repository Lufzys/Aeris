using Aeris.Engine.Components;
using Aeris.Engine.Components.Interfaces;
using Aeris.Engine.Graphics;
using Aeris.Engine.Hardware;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Aeris.Engine.Windows;

public class GameWindow
{
    public NativeWindow Window { get; private set; }
    public SKGLControl GLControl { get; private set; }
    public GameScene? CurrentScene { get; private set; }
    public SKColor ClearColor { get; set; } = SKColors.CornflowerBlue;
    public bool DrawFPS { get; set; } = true;
    public bool CanRunning { get; set; } = true;
    public bool IsRunning { get; private set; } = false;

    private Thread thRoutine;
    private bool canRender = false;
    
    public string Title
    {
        get => Window.Text;
        set => Window.Text = value;
    }
    
    public int Width
    {
        get => Window.Width;
        set => Window.Width = value;
    }
    
    public int Height
    {
        get => Window.Height;
        set => Window.Height = value;
    }
    
    public int X
    {
        get => Window.Left;
        set => Window.Left = value;
    }
    
    public int Y
    {
        get => Window.Top;
        set => Window.Top = value;
    }
    
    public GameWindow(string title, int width, int height, int x, int y, GameScene scene)
    {
        Window = new NativeWindow();
        Title = title;
        Width = width;
        Height = height;
        X = x;
        Y = y;

        GLControl = new SKGLControl();
        GLControl.VSync = false;
        GLControl.Dock = DockStyle.Fill;
        GLControl.PaintSurface += Render;
        Window.Controls.Add(GLControl);
        
        CurrentScene = scene;
        thRoutine  = new Thread(new ThreadStart(Routine));
        thRoutine.Start();

        Window.FormClosed += (sender, args) =>
        {
            SafeStop();
            Environment.Exit(0);
        };
    }

    public void Start()
    {
        Common.CurrentWindow = this;
        Window.ShowDialog();
    }

    public void Stop()
    {
        Common.CurrentWindow = null;
        Window.Close();
    }

    public void Routine()
    {
        IsRunning = true;
        CurrentScene?.Load();
        while (CanRunning)
        {
            CurrentScene?.Process();
            GLControl.Invalidate(); 
            CurrentScene?.Update();
        }
        CurrentScene?.Unload();
        IsRunning = false;
    }

    public void SafeStop()
    {
        CanRunning = false;
        while (IsRunning) { Thread.Sleep(10); }
    }
    
    private void Render(object? sender, SKPaintGLSurfaceEventArgs e)
    {
        e.Surface.Canvas.Clear(ClearColor);
        if (DrawFPS)
            e.Surface.Canvas.DrawText($"FPS: {(int)CurrentScene.Time.FPS}", 10, 20, Graphic.GetDefaultFont(SKColors.White));   
        CurrentScene.Render();
    }
}