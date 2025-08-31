public class ComparcionPorPromedio : EstrategiaDeComparacion
{
    public bool sosIgual(Alumno a1, Alumno a2) => a1.getPromedio() == a2.getPromedio();
    public bool sosMenor(Alumno a1, Alumno a2) => a1.getPromedio() < a2.getPromedio();
    public bool sosMayor(Alumno a1, Alumno a2) => a1.getPromedio() > a2.getPromedio();
}