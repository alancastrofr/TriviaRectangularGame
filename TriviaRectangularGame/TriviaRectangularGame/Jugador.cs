namespace TriviaRectangularGame
{
    public class Jugador
    {
        private static string _nombreUsuario = string.Empty;
        private static int _puntosUsuario = 0;

        public static string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public static int PuntosJugador
        {
            get { return _puntosUsuario; }
            set { _puntosUsuario = value; }
        }

    }
}
