using System.Runtime.InteropServices;

namespace Aeris.Engine.Win32.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct POINT
{
    public int X;
    public int Y;
}
