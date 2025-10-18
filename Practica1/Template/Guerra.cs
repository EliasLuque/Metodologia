public class Guerra : JuegoCartas
{
    public Guerra(Jugador j1, Jugador j2) : base(j1, j2)
    { }

    public override bool existeGanador() => jugador1.manoVacia() || jugador2.manoVacia();

    public override void jugar()
    {
        mezclarMazo();
        repartir();
        while (!existeGanador())
        {
            jugarMano();
            Console.WriteLine();
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
        int cartaJugador1 = jugador1.obtenerCarta();
        Console.WriteLine($"{jugador1.getNombre()} juega la carta {cartaJugador1}");

        int cartaJugador2 = jugador2.obtenerCarta();
        Console.WriteLine($"{jugador2.getNombre()} juega la carta {cartaJugador2}");

        if (cartaJugador1 > cartaJugador2)
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
        int i = 0;
        while(!mazoVacio())
        {
            if (i % 2 == 0)
            {
                jugador1.agregarCarta(sacarCarta());
            }
            else
            {
                jugador2.agregarCarta(sacarCarta());
            }
            i++;
        }
    }
}