public class Jugador : Persona
{
    private List<int> mazo;
    private int puntos;
    EstrategiaDeComparacion estrategia;
    public Jugador(string nombre, int dni) : base(nombre, dni)
    {
        this.mazo = new List<int>();
        this.puntos = 0;
        estrategia = new ComparacionPorPuntaje();
    }

    // Setters Getters
    public void setPuntos(int puntos) => this.puntos = puntos;
    public void setMazo(List<int> mazo) => this.mazo = mazo;
    public int getPuntos() => this.puntos;
    public List<int> getMazo() => this.mazo;

    // Comportamiento
    public void sumarPunto() => this.puntos++;
    public bool manoVacia() => this.mazo.Count() == 0;
    public void agregarCarta(int carta) => this.mazo.Add(carta);
    public int obtenerCarta()
    {
        int carta = this.mazo[0];
        this.mazo.RemoveAt(0);
        return carta;
    }

    // Intefaz Comparable
    public override bool sosIgual(Comparable c) => estrategia.sosIgual(this, c);
    public override bool sosMayor(Comparable c) => estrategia.sosMayor(this, c);
    public override bool sosMenor(Comparable c) => estrategia.sosMenor(this, c);
}