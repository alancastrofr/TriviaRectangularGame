namespace TriviaRectangularGame.Logicas
{
    public class Jugador
    {
        public static void ValidarNombreJugador(string nombreJugador)
        {
            if (nombreJugador.Equals("") || nombreJugador == string.Empty)
                VMJugador.NombreUsuario = "Jugador 1";
            else
                VMJugador.NombreUsuario = nombreJugador;
        }
    }
}
