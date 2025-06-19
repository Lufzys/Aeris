using Aeris.Engine.Windows;

namespace Aeris.Game;

class Program
{
    private static GameWindow game = new GameWindow("Aeris", 800, 600, 100, 100, new MainScene());
    static void Main(string[] args)
    {
        game.Start();
    }
}