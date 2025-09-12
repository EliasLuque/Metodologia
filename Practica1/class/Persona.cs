public abstract class Persona : Comparable
{
    private string nombre;
    private int dni;
    public Persona(string nombre, int dni)
    {
        this.nombre = nombre;
        this.dni = dni;
    }

    public string getNombre() => this.nombre;
    public int getDni() => this.dni;

    public abstract bool sosIgual(Comparable c);

    public abstract bool sosMenor(Comparable c);

    public abstract bool sosMayor(Comparable c);
}