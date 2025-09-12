public class Alumno : Persona
{
    private int legajo;
    private double promedio;
    private EstrategiaDeComparacion estrategia;

    public Alumno(string n, int d, int l, double p) :
    base(n, d)
    {
        this.legajo = l;
        this.promedio = p;
        this.estrategia = new ComparacionPorDni();
    }

    public int getLegajo() => this.legajo;
    public double getPromedio() => this.promedio;
    public void cambiarEstrategia(EstrategiaDeComparacion e) => this.estrategia = e;

    public override bool sosIgual(Comparable c) => this.estrategia.sosIgual(this, (Alumno)c);

    public override bool sosMayor(Comparable c) => this.estrategia.sosMayor(this, (Alumno)c);

    public override bool sosMenor(Comparable c) => this.estrategia.sosMenor(this, (Alumno)c);
    public override string ToString() => $"Nombre: {base.getNombre()}, DNI: {base.getDni()}, Legajo: {this.legajo}, Promedio: {this.promedio}";
}