
namespace TriviaRectangularGame.Logica
{
    public class Pantalla
    {
        public static string ConfigurarAudio(int x)
        {
            string nombreAudio = string.Empty;
            switch (x)
            {
                case 1: nombreAudio = @"C:\soundButton.mp3"; break; 
                case 2: nombreAudio = @"\\Resources\\DisfigureBlank.mp3"; break;
                default:
                    break;
            }

            return nombreAudio;
        }
    }
}
