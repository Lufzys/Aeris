using System.Runtime.InteropServices;
using Aeris.Engine.Win32.Structs;

namespace Aeris.Engine.Win32;

public class PInvoke
{
    [DllImport("user32.dll")]
    public static extern short GetAsyncKeyState(int virtualKey);
    
    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out POINT lpPoint);
    
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool AllocConsole();
    
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool FreeConsole();
    
    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

}