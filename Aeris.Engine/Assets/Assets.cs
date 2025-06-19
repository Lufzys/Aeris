namespace Aeris.Engine.Assets;

public class Assets
{
    public static List<Texture2D> Texture = new List<Texture2D>(); 
    public static List<Audio> Audio = new List<Audio>();

    public static Texture2D GetTextureById(uint id) => Texture.ElementAt((int)id);
    public static Audio GetAudioById(uint id) => Audio.ElementAt((int)id);
}