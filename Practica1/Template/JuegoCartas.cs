public abstract class JuegoCartas
{
    protected List<int> mazo;
    protected Jugador jugador1;
    protected Jugador jugador2;
    public JuegoCartas(Jugador j1, Jugador j2)
    {
        this.jugador1 = j1;
        this.jugador2 = j2;

        this.mazo = new List<int>();
        for (int i = 1; i <= 40; i++)
        {
            mazo.Add(i);
        }
    }
    public bool mazoVacio() => mazo.Count == 0;
    public void mezclarMazo()
    {
        Console.WriteLine("Mezclando mazo...");
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

        for (int i = 0; i < 40; i++)
        {
            int j = gen.numeroAleatorio(40);
            int temp = mazo[i];
            mazo[i] = mazo[j];
            mazo[j] = temp;
        }
    }
    public int sacarCarta()
    {
        int carta = mazo[0];
        mazo.RemoveAt(0);
        return carta;
    }
    public abstract void jugar();
    public abstract void repartir();
    public abstract void jugarMano();
    public abstract bool existeGanador();
}