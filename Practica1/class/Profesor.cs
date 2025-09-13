public class Profesor : Persona
{
    private int antiguedad;
    EstrategiaDeComparacion estrategia;
    public Profesor(string nombre, int dni, int antiguedad) :
    base(nombre, dni)
    {
        this.antiguedad = antiguedad;
        this.estrategia = new ComparacionPorAntiguedad();
    }

    public int getAntiguedad() => this.antiguedad;
    public void cambiarEstrategia(EstrategiaDeComparacion e) => this.estrategia = e;

    public override bool sosIgual(Comparable c) => estrategia.sosIgual(this, (Profesor)c);

    public override bool sosMayor(Comparable c) => estrategia.sosMayor(this, (Profesor)c);

    public override bool sosMenor(Comparable c) => estrategia.sosMenor(this, (Profesor)c);
    public override string ToString() => $"Nombre: {base.getNombre()}, DNI: {base.getDni()}, Antigüedad: {this.antiguedad}";

    public void hablarALaClase() => Console.WriteLine("Hablando de algún tema.");
    public void escribirEnElPizarron() => Console.WriteLine("Escribiendo en el pizarrón.");
} 