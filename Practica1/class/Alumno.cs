public class Alumno : Persona, IObservador
{
    private int legajo;
    private double promedio;
    private EstrategiaDeComparacion estrategia;
    private double calificaion;

    public Alumno(string n, int d, int l, double p) :
    base(n, d)
    {
        this.legajo = l;
        this.promedio = p;
        this.estrategia = new ComparacionPorDni();
    }

    // Métodos
    public int getLegajo() => this.legajo;
    public double getPromedio() => this.promedio;
    public void cambiarEstrategia(EstrategiaDeComparacion e) => this.estrategia = e;
    public double getCalificacion() => this.calificaion;
    public void setCalificacion(double cal) => this.calificaion = cal;
    public virtual int responderPregunta(int pregunta) => new GeneradorDeDatosAleatorios().numeroAleatorio(3) + 1;
    public string mostrarCalificacion() => $"{this.getNombre}\t{this.calificaion}";

    // Interface Comparable
    public override bool sosIgual(Comparable c) => this.estrategia.sosIgual(this, (Alumno)c);
    public override bool sosMayor(Comparable c) => this.estrategia.sosMayor(this, (Alumno)c);
    public override bool sosMenor(Comparable c) => this.estrategia.sosMenor(this, (Alumno)c);

    // Interface Obervador
    public void prestarAtencion() => Console.WriteLine("Prestando atención");
    public void distraerse()
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        switch (generador.numeroAleatorio(3))
        {
            case 0:
                Console.WriteLine("Mirando el celular");
                break;
            case 1:
                Console.WriteLine("Dibujando en el margen de la carpeta");
                break;
            case 2:
                Console.WriteLine("Tirando aviones de papel");
                break;
        }
    }
    public void actualizar(IObservado observado)
    {
        if (((Profesor)observado).getHablando())
        {
            this.prestarAtencion();
        }
        else
        {
            this.distraerse();
        }
    }
    
    public override string ToString() => $"Nombre: {base.getNombre()}, DNI: {base.getDni()}, Legajo: {this.legajo}, Promedio: {this.promedio}";
}