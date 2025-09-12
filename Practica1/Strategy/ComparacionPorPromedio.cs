public class ComparacionPorPromedio : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable a1, Comparable a2) => ((Alumno)a1).getPromedio() == ((Alumno)a2).getPromedio();
    public bool sosMenor(Comparable a1, Comparable a2) => ((Alumno)a1).getPromedio() < ((Alumno)a2).getPromedio();
    public bool sosMayor(Comparable a1, Comparable a2) => ((Alumno)a1).getPromedio() > ((Alumno)a2).getPromedio();
}