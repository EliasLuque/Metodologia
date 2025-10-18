public class Truco : JuegoCartas
{
    public Truco(Jugador j1, Jugador j2) : base(j1, j2)
    { }

    public override bool existeGanador() => jugador1.getPuntos() == 15 || jugador2.getPuntos() == 15;

    public override void jugar()
    {
        while (!existeGanador())
        {
            mezclarMazo();
            repartir();
            jugarMano();
        }
        int[] puntos = [jugador1.getPuntos(), jugador2.getPuntos()];
        if(puntos[0] > puntos[1])
        {
            Console.WriteLine($"{jugador1.getNombre()} ha ganado el juego!");
        } else
        {
            Console.WriteLine($"{jugador2.getNombre()} ha ganado el juego!");
        }
    }

    public override void jugarMano()
    {
        int[] contadorPunto = [0, 0]; // Cuenta los puntos obtenidos en cada ronda
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\nRonda " + (i+1));
            int cartaJugador1 = jugador1.obtenerCarta();
            Console.WriteLine($"{jugador1.getNombre()} juega la carta {cartaJugador1}");
            int cartaJugador2 = jugador2.obtenerCarta();
            Console.WriteLine($"{jugador2.getNombre()} juega la carta {cartaJugador2}");
            mazo.Add(cartaJugador1);
            mazo.Add(cartaJugador2);

            if (cartaJugador1 > cartaJugador2)
            {
                contadorPunto[0]++;
            }
            else
            {
                contadorPunto[1]++;
            }

            switch(i)
            {
                case 1:
                    if(contadorPunto[0] == 2 || contadorPunto[1] == 2)
                    {
                        // Se gano en la segunda ronda, se deben descartar las manos de los jugadores
                        mazo.Add(jugador1.obtenerCarta());
                        mazo.Add(jugador2.obtenerCarta());
                        i++;
                    }
                    break;
            }
        }
        
        if (contadorPunto[0] > contadorPunto[1])
            {
                Console.WriteLine($"{jugador1.getNombre()} suma puntos!");
                jugador1.sumarPunto();
            }
            else
            {
                Console.WriteLine($"{jugador2.getNombre()} suma puntos!");
                jugador2.sumarPunto();
            }
    }

    public override void repartir()
    {
        Console.WriteLine("Repartiendo Cartas...");
        for(int i = 0; i < 6; i++)
        {
            if (i % 2 == 0)
            {
                jugador1.agregarCarta(sacarCarta());
            }
            else
            {
                jugador2.agregarCarta(sacarCarta());
            }
        }
    }
}