public class Alumno : Persona
{
    private int legajo;
    private double promedio;

    public Alumno(string n, int d, int l, double p) :
    base(n, d)
    {
        this.legajo = l;
        this.promedio = p;
    }

    public int getLegajo() => this.legajo;
    public double getPromedio() => this.promedio;

    public override bool sosIgual(Comparable c) => this.promedio == ((Alumno)c).getPromedio();

    public override bool sosMayor(Comparable c) => this.promedio > ((Alumno)c).getPromedio();

    public override bool sosMenor(Comparable c) => this.promedio < ((Alumno)c).getPromedio();
}