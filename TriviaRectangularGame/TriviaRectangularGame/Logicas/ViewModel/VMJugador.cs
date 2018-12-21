namespace TriviaRectangularGame
{
    public class VMJugador
    {
        private static string _nombreUsuario = string.Empty;
        private static int _puntosUsuario = 0;
        private static int _intentos = 0;

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

        public static int Intentos
        {
            get { return _intentos; }
            set { _intentos = value; }
        }

    }
}
