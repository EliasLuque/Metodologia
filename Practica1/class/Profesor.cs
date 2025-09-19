public class Profesor : Persona, IObservado
{
    private int antiguedad;
    EstrategiaDeComparacion estrategia;
    List<IObservador> observadores;
    private bool hablando;

    public Profesor(string nombre, int dni, int antiguedad) :
    base(nombre, dni)
    {
        this.antiguedad = antiguedad;
        this.estrategia = new ComparacionPorAntiguedad();
        observadores = new List<IObservador>();
        this.hablando = false;
    }

    // Métodos
    public int getAntiguedad() => this.antiguedad;
    public bool getHablando() => this.hablando;
    public void cambiarEstrategia(EstrategiaDeComparacion e) => this.estrategia = e;
    public void hablarALaClase()
    {
        this.hablando = true;
        Console.WriteLine("Hablando de algún tema.");
        this.notificar();
    }
    public void escribirEnElPizarron()
    {
        this.hablando = false;
        Console.WriteLine("Escribiendo en el pizarrón.");
        this.notificar();
    }

    // Inteface Comparable
    public override bool sosIgual(Comparable c) => estrategia.sosIgual(this, (Profesor)c);

    public override bool sosMayor(Comparable c) => estrategia.sosMayor(this, (Profesor)c);

    public override bool sosMenor(Comparable c) => estrategia.sosMenor(this, (Profesor)c);

    // Inteface Observado
    public void agregarObservador(IObservador observador) => observadores.Add(observador);

    public void quitarObservador(IObservador observador) => observadores.Remove(observador);

    public void notificar()
    {
        foreach (IObservador observador in observadores)
        {
            observador.actualizar(this);
        }
    }

    public override string ToString() => $"Nombre: {base.getNombre()}, DNI: {base.getDni()}, Antigüedad: {this.antiguedad}";
} 