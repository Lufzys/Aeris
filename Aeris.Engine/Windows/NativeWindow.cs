namespace Aeris.Engine.Windows;

public class NativeWindow : System.Windows.Forms.Form
{
    public NativeWindow()
    {
        this.DoubleBuffered = true;
    }
    
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
    }
}