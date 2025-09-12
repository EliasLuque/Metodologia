public class ComparacionPorNombre : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable a1, Comparable a2) => string.Compare(((Alumno)a1).getNombre(), ((Alumno)a2).getNombre()) == 0;
    public bool sosMenor(Comparable a1, Comparable a2) => string.Compare(((Alumno)a1).getNombre(), ((Alumno)a2).getNombre()) < 0;
    public bool sosMayor(Comparable a1, Comparable a2) => string.Compare(((Alumno)a1).getNombre(), ((Alumno)a2).getNombre()) > 0;
}